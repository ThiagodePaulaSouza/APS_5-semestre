using System;
using System.Windows.Forms;
namespace prjAps
{
    public partial class FormLogin : Form
    {
        private string name, state, city;
        private bool analista, denunciante;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            analista = ratioBtn_analista.Checked;
            denunciante = ratioBtn_denuncia.Checked;
            name = txf_nome.Text;
            state = txf_estado.Text;
            city = txf_cidade.Text;

            if (name != ""
                && (analista == true || denunciante == true)
                && state != ""
                && city != "")
            {
                if (analista == true)
                {
                    Cursor = Cursors.WaitCursor;
                    FormAnalista frmAnalista = new FormAnalista(name, state, city);
                    Cursor = Cursors.Default;
                    frmAnalista.ShowDialog();
                    if (frmAnalista.IsDisposed)
                    {
                        this.Close();
                    }
                }
                else
                {
                    Cursor = Cursors.WaitCursor;
                    FormChat frmChat = new FormChat(name);
                    Cursor = Cursors.Default;
                    frmChat.ShowDialog();
                    if (frmChat.IsDisposed)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha Todos os Campos!");
            }
        }

        private void RemoveText(TextBox txt, object sender, EventArgs e)
        {
            if (txf_nome.Text == "Digite seu Nome...")
            {
                txf_nome.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txf_nome.Text))
                txf_nome.Text = "Enter text here...";
        }
    }
}
