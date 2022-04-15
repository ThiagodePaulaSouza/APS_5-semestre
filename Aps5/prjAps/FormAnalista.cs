using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace prjAps
{
    public partial class FormAnalista : Form
    {
        public FormAnalista(string name, string lastname, string state, string city, int typeUser)
        {
            InitializeComponent();
            txt_nome.Text = $"{name} {lastname}";
            txt_estado.Text = state;
            txt_cidade.Text = city;
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            txt_IP.Text = $"{ip[1].ToString()}";
            txt_ID.Text = $"{name[0]}IDP{lastname[0]}{typeUser}{ip[1]}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txf_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txf_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txf_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txf_regiao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txf_longitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void txf_latitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void txf_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txf_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAnalista_Load(object sender, EventArgs e)
        {

        }

        private void link_chat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //chamar chat
            if (Application.OpenForms.OfType<FormChat>().Count() > 0 )
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
}
