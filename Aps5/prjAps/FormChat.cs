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
        private string NomeDoUsuario /*= pegar nome do analista ou nome do denunciante */;
        private StreamWriter StwEnvia;
        private StreamReader StrRecebe;
        private TcpClient TcpServidor;
        //definindo o ip e porta global
        private IPAddress EndIP = IPAddress.Parse("127.0.0.1");
        private int PortaHost = 1000;

        //atualiza formulario com a mensagem de outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        //Define o formulario para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);

        private bool Conectado;
        private Thread MsgThread;

        //passo o nome do usuario por aqui
        public FormChat(string nome, string lastname)
        {
            this.NomeDoUsuario = $"{nome} {lastname}";
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

        private void InicializaConexao()
        {
            try
            {
                TcpServidor = new TcpClient();
                TcpServidor.Connect(EndIP, PortaHost);
                Conectado = true;

                //inicializa componentes
                txtMensagem.Enabled = true;
                btnEnviar.Enabled = true;

                //envia o nome do user para o servidor
                StwEnvia = new StreamWriter(TcpServidor.GetStream());
                StwEnvia.WriteLine(NomeDoUsuario);
                StwEnvia.Flush();

                MsgThread = new Thread(new ThreadStart(RecebeMensagem));
                MsgThread.IsBackground = true;
                MsgThread.Start();
            }
            catch (Exception ex)
            {
                FechaConexao("Não foi possivel estabelecer conexão com o servidor...");
                return;
            }
        }

        private void RecebeMensagem()
        {
            StrRecebe = new StreamReader(TcpServidor.GetStream());
            string ConResposta = StrRecebe.ReadLine();

            if (ConResposta[0] == '1')
            {
                //atualiza o formulário (do servidor) para informar que está conectado 
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
            }
            else
            {
                string Motivo = "Não Conectado: ";
                //extrai o motivo da mensagem resposta o motivo começa no 3char
                Motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                //atualiza o formulário (do servidor) para informar que está conectado 
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { Motivo });
                return;
            }

            while (Conectado)
            {
                //ERRO 
                //- ele não notifica quando sai/ não sai dai fica preso aqui

                //exibe mensagem no txtLog
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { StrRecebe.ReadLine() });

                //ERRO 
            }
        }

        private void AtualizaLog(string strMensagem)
        {
            txtLog.AppendText($"{strMensagem} \r\n");
        }

        private void FechaConexao(string Motivo)
        {
            //mostra motivo do porque fechou
            txtLog.AppendText($"{Motivo} \r\n");
            //desabilita e abilita os campos apropriados
            txtMensagem.Enabled = false;
            btnEnviar.Enabled = false;

            //fecha os objetos
            Conectado = false;
            TcpServidor.Close();
            try
            {
                StwEnvia.Close();
                StrRecebe.Close();
            }
            catch (Exception ex)
            {
                //mostra motivo do porque fechou
                txtLog.AppendText($"{Motivo} \r\n");
            }
        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado)
            {
                // Fecha as conexões, streams, etc...
                Conectado = false;
                StwEnvia.Close();
                StrRecebe.Close();
                TcpServidor.Close();

                //labelStatus.Invoke(new Action(() => {
                //    labelStatus.ForeColor = Color.Green;
                //    labelStatus.Text = $"Desconectado do servidor de Chat {enderecoIP}:{portaHost}";
                //}));
            }
        }
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
        private void button1_Click(object sender, EventArgs e)
        {
            //envia mensagem
            EnviaMensagem();
        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se precionou a tecla enter
            if (e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }

        private void lbl_denunciante_Click(object sender, EventArgs e)
        {

        }
    }
}
