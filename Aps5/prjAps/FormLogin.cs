using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
namespace prjAps
{
    public partial class FormLogin : Form
    {
        public class RJButton : Button
        {
            private int borderSize = 0;
            private int borderRadius = 20;
            private Color borderColor = Color.PaleVioletRed;
        }
        public bool TextWasChanged = false;

        public FormLogin()
        {
            InitializeComponent();
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string name, state, city;
            bool analista, denunciante;
            int type;

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
                    type = 0;
                    if (Application.OpenForms.OfType<FormAnalista>().Count() > 0)
                    {
                        MessageBox.Show("O FORMULÁRIO JÁ ESTÁ ABERTO!");
                    }
                    else
                    {
                        Cursor = Cursors.WaitCursor;
                        FormAnalista frmAnalista = new FormAnalista(name, state, city, type);
                        Cursor = Cursors.Default;
                        frmAnalista.ShowDialog();
                        if (frmAnalista.IsDisposed)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    type = 1;
                    if (Application.OpenForms.OfType<FormChat>().Count() > 0)
                    {
                        MessageBox.Show("O CHAT JÁ ESTÁ ABERTO!");
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
            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS!");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
