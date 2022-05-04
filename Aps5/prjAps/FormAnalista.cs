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
        private string NameAnalista, LastnameAnalista;

        public FormAnalista(string name, string lastname, string state, string city, int typeUser)
        {
            this.NameAnalista = name;
            this.LastnameAnalista = lastname;

            InitializeComponent();
            txt_nome.Text = $"{name} {lastname}";
            txt_estado.Text = state;
            txt_cidade.Text = city;

            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            txt_IP.Text = $"{ip[1].ToString()}";
            if (name == "" && lastname == "")
            {
                txt_ID.Text = $"IDP{typeUser}{ip[1]}";
            }
            else
            {
                txt_ID.Text = $"{name[0]}IDP{lastname[0]}{typeUser}{ip[1]}";
            }

            //conectar no server
            //atualizar log do atendimento
        }

        #region propriedades

        private void FormAnalista_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void link_chat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //chamar chat
            if (Application.OpenForms.OfType<FormChat>().Count() > 0 )
            {
                MessageBox.Show("O ATENDIMENTO JÁ ESTÁ SENDO REALIZADO!");
            }
            else
            {
                FormChat frmChat = new FormChat(NameAnalista, LastnameAnalista);
                frmChat.Show();
            }
        }
    }
}
