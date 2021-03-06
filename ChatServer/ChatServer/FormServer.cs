using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class FormServer : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);

        bool conectado = false;

        public FormServer()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                Application.Exit();
                return;
            }

            if (txtIP.Text == string.Empty)
            {
                MessageBox.Show("Informe o endereço IP.");
                txtIP.Focus();
                return;
            }

            try
            {
                IPAddress enderecoIP = IPAddress.Parse(txtIP.Text);
                int portaHost = int.Parse(numPorta.Text);

                Servidor mainServidor = new Servidor(enderecoIP, portaHost);

                // Vincula o evento StatusChanged a atualização do formulario (mainServidor_StatusChanged)
                Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                // Inicia o atendimento das conexões
                mainServidor.IniciaAtendimento();

                // Mostra que nos iniciamos o atendimento para conexões
                listaLog.Items.Add("Servidor ativo, aguardando usuários conectarem-se...");
                listaLog.SetSelected(listaLog.Items.Count - 1, true);
            }
            catch (Exception ex)
            {
                listaLog.Items.Add("Erro de conexão : " + ex.Message);
                listaLog.SetSelected(listaLog.Items.Count - 1, true);
                return;
            }

            conectado = true;
            txtIP.Enabled = false;
            numPorta.Enabled = false;
            btnStartServer.BackColor = Color.FromArgb(255, 88, 88);
            btnStartServer.Text = "Sair";
        }

        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Chama o método que atualiza o formulário
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
        }

        private void AtualizaStatus(string strMensagem)
        {
            // Atualiza o logo com mensagens
            listaLog.Items.Add(strMensagem);
            listaLog.SetSelected(listaLog.Items.Count - 1, true);
        }
        
    }
}