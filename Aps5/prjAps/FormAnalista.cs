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
        private string NameAnalista, LastnameAnalista;

        private StreamWriter StwEnvia;
        private StreamReader StrRecebe;
        private TcpClient TcpServidor;

        private IPAddress EndIP = IPAddress.Parse("127.0.0.1");
        private int PortaHost = 1000;

        //atualiza formulario com a mensagem de outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        //Define o formulario para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);

        private bool Conectado;
        private Thread MsgThread;

        public FormAnalista(string name, string lastname, string state, string city, int typeUser)
        {
            this.NameAnalista = name;
            this.LastnameAnalista = lastname;

            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            InitializeComponent();

            txt_nome.Text = $"{name} {lastname}";
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

            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            txt_IP.Text = $"{ip[1].ToString()}";

            //refatorar if else
            if (name == "" && lastname == "")
            {
                txt_ID.Text = $"IDP{typeUser}{ip[1]}";
            }
            else
            {
                txt_ID.Text = $"{name[0]}IDP{lastname[0]}{typeUser}{ip[1]}";
            }
        }

        #region propriedades

        private void FormAnalista_Load(object sender, EventArgs e)
        {

        }

        #endregion
        
        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado)
            {
                // Fecha as conexões, streams, etc...
                Conectado = false;
                StwEnvia.Close();
                StrRecebe.Close();
                TcpServidor.Close();
                
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
                StwEnvia.WriteLine($"{NameAnalista} {LastnameAnalista}");
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

        private void AtualizaLog(string strMensagem)
        {
            atendimentoLog.AppendText($"{strMensagem} \r\n");
        }

        private void RecebeMensagem()
        {
            StrRecebe = new StreamReader(TcpServidor.GetStream());
            string ConResposta = StrRecebe.ReadLine();

            //ta dando erro aqui...
            //o erro é: não é possivel chamar invoke 
            //em um controle antes da criação do identificador de janela
            try
            {
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

                    //Varificar oq muda...
                    this.Invoke(new FechaConexaoCallBack(this.AtualizaLog), new object[] { Motivo });
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("o problema é \r\n" + ex);
            }
            while (Conectado)
            {
                //ERRO 
                //provavelmente o erro n é aqui, mas sim no try catch acima

                // não é possivel chamar invoke em um controle antes da criação do identificador de janela

                //exibe mensagem no txtLog
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { StrRecebe.ReadLine() });

                //ERRO 
            }
        }
        
        private void FechaConexao(string Motivo)
        {
            //mostra motivo do porque fechou
            atendimentoLog.AppendText($"{Motivo} \r\n");
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
            catch
            {
                //mostra motivo do porque fechou
                atendimentoLog.AppendText($"{Motivo} \r\n");
            }
        }
        
        private void FormAnalista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviaMensagem();
        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }

        private void link_chat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //chamar chat
            //if (Application.OpenForms.OfType<FormChat>().Count() > 0)
            //{
            //    MessageBox.Show("O ATENDIMENTO JÁ ESTÁ SENDO REALIZADO!");
            //}
            //else
            //{
            //    FormChat frmChat = new FormChat(NameAnalista, LastnameAnalista);
            //    frmChat.ShowDialog();
            //}
    }
    }
}
