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
    public partial class FormChat : Form
    {
        #region Variaveis
        private string name;
        private StreamWriter StwEnvia;
        private StreamReader StrRecebe;
        private TcpClient TcpServidor;

        //definindo o ip e porta global
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
        //passo o nome do usuario por aqui
        public FormChat(string name)
        {
            this.name = name;
            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            InitializeComponent();
            if (!Conectado)
            {
                InicializaConexao();
            }
            else
            {
                FechaConexao("Desconectado a pedido do usuário");
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
                btnEnviar.ForeColor = Color.Black;
                btnEnviar.Text = "Enviar";
                txtLog.Enabled = false;

                //envia o nome do user para o servidor
                StwEnvia = new StreamWriter(TcpServidor.GetStream());
                StwEnvia.WriteLine(name);
                StwEnvia.Flush();

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
                //atualiza o formulário (do servidor) para informar que está conectado 
                try
                {
                    this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Olha o erro" + ex);
                }
                //this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
            }
            else
            {
                // Se o primeiro caractere não for 1 a conexão falhou
                string Motivo = "Não Conectado: ";

                //extrai o motivo da mensagem resposta o motivo começa no 3char
                Motivo += ConResposta.Substring(2, ConResposta.Length - 2);

                // Atualiza o formulário com o motivo da falha da conexão
                // WTF como isso funciona! kkkkkkkkkkkkkkkkkk //
                try
                {
                    this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] { Motivo });
                }
                catch (Exception ex)
                {
                    this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] { Motivo });
                    Console.WriteLine("Olha o erro" + ex);
                }

                // Sai do metodo
                return;
            }
            // Enquanto estiver conectado lê as linhas que estão chegando do servidor
            while (Conectado)
            {
                //exibe mensagem no txtLog
                try
                {
                    this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { StrRecebe.ReadLine() });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Olha o erro" + ex);

                    // Atualiza o formulário com o motivo da falha da conexão
                    this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] { "Não foi possivel estabelecer conexão com o servidor! \r\nClique no botão Reconectar... Para tentar novamente.\r\n" });
                }
            }
        }

        // Fecha a conexão com o servidor
        private void FechaConexao(string Motivo = null)
        {
            // se não tiver motivo significa que apenas quer fechar a aplicação
            if (Motivo != null)
            {
                txtLog.AppendText($"{Motivo} \r\n");
            }

            //desabilita e abilita os campos apropriados
            btnEnviar.ForeColor = Color.Red;
            btnEnviar.Text = "Reconectar...";
            txtMensagem.Enabled = false;

            //fecha os objetos
            Conectado = false;
            TcpServidor.Close();

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
            //envia mensagem pro servidor
            if (txtMensagem.Lines.Length >= 1)
            {
                StwEnvia.WriteLine(txtMensagem.Text);
                StwEnvia.Flush();
                txtMensagem.Lines = null;
            }
            txtMensagem.Text = "";
        }

        // Atualiza a mensagem no atendimentoLog
        private void AtualizaLog(string strMensagem)
        {
            txtLog.AppendText($"{strMensagem} \r\n");
        }
        #endregion

        #region Eventos
        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado)
            {
                FechaConexao();
            }
        }

        private void FormChat_Closing(object sender, CancelEventArgs e)
        {
            //testar quando estiver conectado!
            if (Conectado)
            {
                FechaConexao();
            }
        }

        private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (btnEnviar.ForeColor == Color.Red)
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
