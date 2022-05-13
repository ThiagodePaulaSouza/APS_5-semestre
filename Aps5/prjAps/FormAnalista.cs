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
            txt_nome.Text = name;
            txt_estado.Text = state;
            txt_cidade.Text = city;

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
                txtMensagem.Enabled = true;
                btnEnviar.Enabled = true;
                btnEnviar.ForeColor = Color.FromArgb(5, 215, 88);
                btnEnviar.Text = "Enviar";
                atendimentoLog.Enabled = false;
                //IP e ID
                IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
                txt_IP.Text = ip[1].ToString();
                txt_ID.Text = $"IDP{typeUser}{ip[1]}";

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
                    //return;
                }
            }
        }

        // Fecha a conexão com o servidor
        private void FechaConexao(string Motivo = null)
        {
            //se não tiver motivo significa que apenas quer fechar a aplicação
            if (Motivo != null)
            {
                atendimentoLog.AppendText($"{Motivo} \r\n");
            }

            //fecha os objetos
            Conectado = false;
            TcpServidor.Close();

            //desabilita e abilita os campos apropriados
            btnEnviar.ForeColor = Color.FromArgb(255, 88, 88);
            btnEnviar.Text = "Reconectar...";

            txtMensagem.Enabled = false;
            atendimentoLog.Enabled = false;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void atendimentoLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_regiao_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_nomeAnalista_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (btnEnviar.ForeColor == Color.FromArgb(255, 88, 88))
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
    }
}
