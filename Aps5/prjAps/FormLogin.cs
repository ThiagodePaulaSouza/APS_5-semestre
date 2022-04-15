using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAps
{
    public partial class FormLogin : Form
    {
        public bool TextWasChanged = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void txf_sobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAnalista_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnDenuncia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string name, lastname, state, city;
            bool analista, denunciante;
            int type;

            analista = ratioBtn_analista.Checked;
            denunciante = ratioBtn_denuncia.Checked;
            name = txf_nome.Text;
            lastname = txf_sobrenome.Text;
            state = cbox_estado.Text;
            city = cbox_cidade.Text;

            if (name != null
                && lastname != null
                && (analista == true || denunciante == true)
                && state != null
                && city != null)
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
                        FormAnalista frmAnalista = new FormAnalista(name, lastname, state, city, type);
                        frmAnalista.Show();
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
                        FormChat frmChat = new FormChat();
                        frmChat.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS!");
            }

        }
    }

}
