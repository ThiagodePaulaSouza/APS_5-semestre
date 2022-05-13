using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace prjAps
{
    public partial class FormAnalista : Form
    {
        #region Variaveis
        private string name;
        private int typeUser;

        private StreamWriter StwEnvia;
        private StreamReader StrRecebe;
        private TcpClient TcpServidor;

        private IPAddress EnderecoIP;
        private int PortaHost;

        //atualiza formulario com a mensagem de outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        //Define o formulario para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);

        private bool Conectado;
        private Thread MsgThread;
        #endregion

        #region Construtor
        public FormAnalista(string name, string state, string city, int typeUser)
        {
            //atualiza variaveis locais
            this.name = name;
            this.typeUser = typeUser;

            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            InitializeComponent();

            //carrega dados no form
            txtNome.Text = name;
            txtEstado.Text = state;
            txtCidade.Text = city;

            if (!Conectado)
            {
                InicializaConexao();
            }
            else
            {
                FechaConexao("Desconectado a pedido do analista");
            }
        }
        #endregion

        #region Conexao com o Servidor / Lógica
        // Inicia conexão com o servidor
        private void InicializaConexao()
        {
            try
            {
                //hard coded
                EnderecoIP = IPAddress.Parse("127.0.0.1");
                PortaHost = 1000;

                //inicia uma nova conexão tcp com o chat server
                TcpServidor = new TcpClient();
                TcpServidor.Connect(EnderecoIP, PortaHost);
                Conectado = true;

                //inicializa componentes
                Point ptTxtOriginal = new Point(23, 6);
                Point ptPnlOriginal = new Point(0, 389);
                txtMensagem.Location = ptTxtOriginal;
                pnlTxtMensagem.Location = ptPnlOriginal;
                txtMensagem.Enabled = true;
                btnEnviar.Enabled = true;
                btnEnviar.ForeColor = Color.Black;
                btnEnviar.Text = "Enviar";
                atendimentoLog.ForeColor = Color.FromArgb(5, 215, 88);
                //IP e ID
                IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
                txtIP.Text = ip[1].ToString();
                //envia o nome do user para o servidor
                StwEnvia = new StreamWriter(TcpServidor.GetStream());
                StwEnvia.WriteLine(name);
                StwEnvia.Flush();

                // Inicializa a thread para receber mensagens e nova comunicação
                MsgThread = new Thread(new ThreadStart(RecebeMensagem));
                MsgThread.IsBackground = true;
                MsgThread.Start();

            }
            catch
            {
                FechaConexao("Não foi possivel estabelecer conexão com o servidor! \r\nClique no botão Reconectar... Para tentar novamente.\r\n");
            }
        }

        // Recebe mensagem do servidor
        private void RecebeMensagem()
        {
            // Recebe a resposta do servidor
            StrRecebe = new StreamReader(TcpServidor.GetStream());
            string ConResposta = StrRecebe.ReadLine();

            // Se o primeiro caractere da resposta é 1 a conexão foi feita com sucesso
            if (ConResposta[0] == '1' && Conectado == true)
            {
                // Atualiza o formulário (do servidor) para informar que está conectado
                try
                {
                    // AtualizaLog o formulario com "Conectado com sucesso!"
                    this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Olha o erro" + ex);
                }
            }
            else
            {
                // Se o primeiro caractere não for 1 a conexão falhou
                string Motivo = "Não Conectado: ";

                // Extrai o motivo da mensagem resposta. O motivo começa no 3o. caractere
                Motivo += ConResposta.Substring(2, ConResposta.Length - 2);

                try
                {
                    this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] { Motivo });

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Olha o erro" + ex);
                }

                // Sai do método
                return;
            }

            // Enquanto estiver conectado lê as linhas que estão chegando do servidor
            while (Conectado)
            {
                // Exibe mensagens no TextBox
                try
                {
                    this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { StrRecebe.ReadLine() });
                }
                catch (Exception ex)
                {
                    // Atualiza o formulário com o motivo da falha da conexão
                    this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] { "Não foi possivel estabelecer conexão com o servidor! \r\nClique no botão Reconectar... Para tentar novamente.\r\n" });
                    Console.WriteLine("Olha o erro" + ex);
                }
            }
        }

        // Fecha a conexão com o servidor
        private void FechaConexao(string Motivo = null)
        {
            //se não tiver motivo significa que apenas quer fechar a aplicação
            if (Motivo != null)
            {
                atendimentoLog.ForeColor = Color.Yellow;
                atendimentoLog.AppendText($"{Motivo} \r\n");
            }

            //fecha os objetos
            Conectado = false;
            TcpServidor.Close();

            //desabilita e abilita os campos apropriados
            btnEnviar.ForeColor = Color.Black;
            btnEnviar.Text = "Reconectar";
            Point ptTxt = new Point(1, 492);
            pnlTxtMensagem.Location = ptTxt;
            txtMensagem.Location = ptTxt;
            txtMensagem.Enabled = false;

            //n foi iniciado
            if (StwEnvia != null)
            {
                StwEnvia.Close();
                StrRecebe.Close();
            }
        }

        // Envia mensagem ao servidor
        private void EnviaMensagem()
        {
            if(Conectado)
            {
                //envia mensagem pro servidor
                if (txtMensagem.Lines.Length >= 1)
                {
                    StwEnvia.WriteLine(txtMensagem.Text);
                    StwEnvia.Flush();
                    txtMensagem.Lines = null;
                }

                txtMensagem.Text = "";
            } else
            {
                FechaConexao();
            }
        }

        // Atualiza a mensagem no atendimentoLog
        private void AtualizaLog(string strMensagem)
        {
            atendimentoLog.AppendText($"{strMensagem} \r\n");
        }
        #endregion

        #region Eventos
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (btnEnviar.Text == "Reconectar")
            {
                this.Cursor = Cursors.WaitCursor;
                InicializaConexao();
                this.Cursor = Cursors.Default;
            }
            else
            {
                EnviaMensagem();
            }
        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            //testar quando estiver conectado!
            if (Conectado)
            {
                FechaConexao();
            }
        }

        private void FormAnalista_Closing(object sender, CancelEventArgs e)
        {
            //testar quando estiver conectado!
            if (Conectado)
            {
                FechaConexao();
            }
        }

        private void FormAnalista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se precionou a tecla enter
            if (e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }
        #endregion



    }
}
