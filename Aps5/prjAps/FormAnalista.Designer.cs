namespace prjAps
{
    partial class FormAnalista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_info = new System.Windows.Forms.Panel();
            this.panel_lblChats = new System.Windows.Forms.Panel();
            this.panel_chats = new System.Windows.Forms.Panel();
            this.panel_lblAtendimento = new System.Windows.Forms.Panel();
            this.panel_atendimentos = new System.Windows.Forms.Panel();
            this.lbl_nomeAnalista = new System.Windows.Forms.Label();
            this.lbl_cidadeAnalista = new System.Windows.Forms.Label();
            this.lbl_estadoAnalista = new System.Windows.Forms.Label();
            this.lbl_regiao = new System.Windows.Forms.Label();
            this.lbl_longitude = new System.Windows.Forms.Label();
            this.lbl_latitude = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_chats = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.link_chat = new System.Windows.Forms.LinkLabel();
            this.txt_nome = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.Label();
            this.txt_regiao = new System.Windows.Forms.Label();
            this.txt_longitude = new System.Windows.Forms.Label();
            this.txt_latitude = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.Label();
            this.panel_info.SuspendLayout();
            this.panel_lblChats.SuspendLayout();
            this.panel_chats.SuspendLayout();
            this.panel_lblAtendimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_info
            // 
            this.panel_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_info.Controls.Add(this.txt_ID);
            this.panel_info.Controls.Add(this.txt_IP);
            this.panel_info.Controls.Add(this.txt_latitude);
            this.panel_info.Controls.Add(this.txt_longitude);
            this.panel_info.Controls.Add(this.txt_regiao);
            this.panel_info.Controls.Add(this.txt_cidade);
            this.panel_info.Controls.Add(this.txt_estado);
            this.panel_info.Controls.Add(this.txt_nome);
            this.panel_info.Controls.Add(this.lbl_ID);
            this.panel_info.Controls.Add(this.lbl_IP);
            this.panel_info.Controls.Add(this.lbl_latitude);
            this.panel_info.Controls.Add(this.lbl_longitude);
            this.panel_info.Controls.Add(this.lbl_regiao);
            this.panel_info.Controls.Add(this.lbl_estadoAnalista);
            this.panel_info.Controls.Add(this.lbl_cidadeAnalista);
            this.panel_info.Controls.Add(this.lbl_nomeAnalista);
            this.panel_info.Location = new System.Drawing.Point(12, 12);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(924, 78);
            this.panel_info.TabIndex = 0;
            // 
            // panel_lblChats
            // 
            this.panel_lblChats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lblChats.Controls.Add(this.lbl_chats);
            this.panel_lblChats.Location = new System.Drawing.Point(13, 97);
            this.panel_lblChats.Name = "panel_lblChats";
            this.panel_lblChats.Size = new System.Drawing.Size(135, 39);
            this.panel_lblChats.TabIndex = 1;
            // 
            // panel_chats
            // 
            this.panel_chats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_chats.Controls.Add(this.link_chat);
            this.panel_chats.Location = new System.Drawing.Point(12, 143);
            this.panel_chats.Name = "panel_chats";
            this.panel_chats.Size = new System.Drawing.Size(136, 295);
            this.panel_chats.TabIndex = 2;
            // 
            // panel_lblAtendimento
            // 
            this.panel_lblAtendimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lblAtendimento.Controls.Add(this.label1);
            this.panel_lblAtendimento.Location = new System.Drawing.Point(155, 97);
            this.panel_lblAtendimento.Name = "panel_lblAtendimento";
            this.panel_lblAtendimento.Size = new System.Drawing.Size(781, 39);
            this.panel_lblAtendimento.TabIndex = 3;
            // 
            // panel_atendimentos
            // 
            this.panel_atendimentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_atendimentos.Location = new System.Drawing.Point(155, 143);
            this.panel_atendimentos.Name = "panel_atendimentos";
            this.panel_atendimentos.Size = new System.Drawing.Size(781, 295);
            this.panel_atendimentos.TabIndex = 4;
            // 
            // lbl_nomeAnalista
            // 
            this.lbl_nomeAnalista.AutoSize = true;
            this.lbl_nomeAnalista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_nomeAnalista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeAnalista.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_nomeAnalista.Location = new System.Drawing.Point(3, 0);
            this.lbl_nomeAnalista.Name = "lbl_nomeAnalista";
            this.lbl_nomeAnalista.Size = new System.Drawing.Size(124, 16);
            this.lbl_nomeAnalista.TabIndex = 0;
            this.lbl_nomeAnalista.Text = "Nome do Analista:";
            // 
            // lbl_cidadeAnalista
            // 
            this.lbl_cidadeAnalista.AutoSize = true;
            this.lbl_cidadeAnalista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_cidadeAnalista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidadeAnalista.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_cidadeAnalista.Location = new System.Drawing.Point(3, 58);
            this.lbl_cidadeAnalista.Name = "lbl_cidadeAnalista";
            this.lbl_cidadeAnalista.Size = new System.Drawing.Size(132, 16);
            this.lbl_cidadeAnalista.TabIndex = 0;
            this.lbl_cidadeAnalista.Text = "Cidade do Analista:";
            // 
            // lbl_estadoAnalista
            // 
            this.lbl_estadoAnalista.AutoSize = true;
            this.lbl_estadoAnalista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_estadoAnalista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoAnalista.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_estadoAnalista.Location = new System.Drawing.Point(3, 30);
            this.lbl_estadoAnalista.Name = "lbl_estadoAnalista";
            this.lbl_estadoAnalista.Size = new System.Drawing.Size(129, 16);
            this.lbl_estadoAnalista.TabIndex = 1;
            this.lbl_estadoAnalista.Text = "Estado do Analista:";
            // 
            // lbl_regiao
            // 
            this.lbl_regiao.AutoSize = true;
            this.lbl_regiao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_regiao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regiao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_regiao.Location = new System.Drawing.Point(261, 0);
            this.lbl_regiao.Name = "lbl_regiao";
            this.lbl_regiao.Size = new System.Drawing.Size(228, 16);
            this.lbl_regiao.TabIndex = 6;
            this.lbl_regiao.Text = "Região de atendimento ao cliente:";
            this.lbl_regiao.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_longitude
            // 
            this.lbl_longitude.AutoSize = true;
            this.lbl_longitude.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_longitude.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_longitude.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_longitude.Location = new System.Drawing.Point(261, 30);
            this.lbl_longitude.Name = "lbl_longitude";
            this.lbl_longitude.Size = new System.Drawing.Size(76, 16);
            this.lbl_longitude.TabIndex = 7;
            this.lbl_longitude.Text = "Longitude:";
            // 
            // lbl_latitude
            // 
            this.lbl_latitude.AutoSize = true;
            this.lbl_latitude.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_latitude.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latitude.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_latitude.Location = new System.Drawing.Point(261, 57);
            this.lbl_latitude.Name = "lbl_latitude";
            this.lbl_latitude.Size = new System.Drawing.Size(64, 16);
            this.lbl_latitude.TabIndex = 8;
            this.lbl_latitude.Text = "Latitude:";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_IP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_IP.Location = new System.Drawing.Point(476, 30);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(100, 16);
            this.lbl_IP.TabIndex = 12;
            this.lbl_IP.Text = "IP do Analista:";
            this.lbl_IP.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_ID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_ID.Location = new System.Drawing.Point(476, 58);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(100, 16);
            this.lbl_ID.TabIndex = 13;
            this.lbl_ID.Text = "ID do Analista:";
            // 
            // lbl_chats
            // 
            this.lbl_chats.AutoSize = true;
            this.lbl_chats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_chats.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chats.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_chats.Location = new System.Drawing.Point(3, 9);
            this.lbl_chats.Name = "lbl_chats";
            this.lbl_chats.Size = new System.Drawing.Size(113, 16);
            this.lbl_chats.TabIndex = 16;
            this.lbl_chats.Text = "Chats em Aberto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Atendimentos Realizados";
            // 
            // link_chat
            // 
            this.link_chat.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.link_chat.AutoSize = true;
            this.link_chat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_chat.LinkColor = System.Drawing.Color.DarkCyan;
            this.link_chat.Location = new System.Drawing.Point(7, 4);
            this.link_chat.Name = "link_chat";
            this.link_chat.Size = new System.Drawing.Size(88, 16);
            this.link_chat.TabIndex = 0;
            this.link_chat.TabStop = true;
            this.link_chat.Text = "Denunciante";
            this.link_chat.VisitedLinkColor = System.Drawing.Color.DarkCyan;
            this.link_chat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_chat_LinkClicked);
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_nome.Location = new System.Drawing.Point(130, 3);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(42, 16);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.Text = "Null...";
            // 
            // txt_estado
            // 
            this.txt_estado.AutoSize = true;
            this.txt_estado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_estado.Location = new System.Drawing.Point(130, 30);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(42, 16);
            this.txt_estado.TabIndex = 14;
            this.txt_estado.Text = "Null...";
            // 
            // txt_cidade
            // 
            this.txt_cidade.AutoSize = true;
            this.txt_cidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_cidade.Location = new System.Drawing.Point(130, 58);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(42, 16);
            this.txt_cidade.TabIndex = 15;
            this.txt_cidade.Text = "Null...";
            // 
            // txt_regiao
            // 
            this.txt_regiao.AutoSize = true;
            this.txt_regiao.Enabled = false;
            this.txt_regiao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regiao.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_regiao.Location = new System.Drawing.Point(495, 0);
            this.txt_regiao.Name = "txt_regiao";
            this.txt_regiao.Size = new System.Drawing.Size(123, 16);
            this.txt_regiao.TabIndex = 16;
            this.txt_regiao.Text = "São Paulo e Região";
            // 
            // txt_longitude
            // 
            this.txt_longitude.AutoSize = true;
            this.txt_longitude.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_longitude.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_longitude.Location = new System.Drawing.Point(343, 30);
            this.txt_longitude.Name = "txt_longitude";
            this.txt_longitude.Size = new System.Drawing.Size(42, 16);
            this.txt_longitude.TabIndex = 17;
            this.txt_longitude.Text = "Null...";
            // 
            // txt_latitude
            // 
            this.txt_latitude.AutoSize = true;
            this.txt_latitude.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_latitude.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_latitude.Location = new System.Drawing.Point(343, 58);
            this.txt_latitude.Name = "txt_latitude";
            this.txt_latitude.Size = new System.Drawing.Size(42, 16);
            this.txt_latitude.TabIndex = 18;
            this.txt_latitude.Text = "Null...";
            // 
            // txt_IP
            // 
            this.txt_IP.AutoSize = true;
            this.txt_IP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_IP.Location = new System.Drawing.Point(582, 30);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(42, 16);
            this.txt_IP.TabIndex = 19;
            this.txt_IP.Text = "Null...";
            // 
            // txt_ID
            // 
            this.txt_ID.AutoSize = true;
            this.txt_ID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_ID.Location = new System.Drawing.Point(582, 58);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(42, 16);
            this.txt_ID.TabIndex = 20;
            this.txt_ID.Text = "Null...";
            // 
            // FormAnalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.panel_atendimentos);
            this.Controls.Add(this.panel_lblAtendimento);
            this.Controls.Add(this.panel_chats);
            this.Controls.Add(this.panel_lblChats);
            this.Controls.Add(this.panel_info);
            this.Name = "FormAnalista";
            this.Text = "Denúncias Florestais";
            this.Load += new System.EventHandler(this.FormAnalista_Load);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.panel_lblChats.ResumeLayout(false);
            this.panel_lblChats.PerformLayout();
            this.panel_chats.ResumeLayout(false);
            this.panel_chats.PerformLayout();
            this.panel_lblAtendimento.ResumeLayout(false);
            this.panel_lblAtendimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label lbl_latitude;
        private System.Windows.Forms.Label lbl_longitude;
        private System.Windows.Forms.Label lbl_regiao;
        private System.Windows.Forms.Label lbl_estadoAnalista;
        private System.Windows.Forms.Label lbl_cidadeAnalista;
        private System.Windows.Forms.Label lbl_nomeAnalista;
        private System.Windows.Forms.Panel panel_lblChats;
        private System.Windows.Forms.Panel panel_chats;
        private System.Windows.Forms.Panel panel_lblAtendimento;
        private System.Windows.Forms.Panel panel_atendimentos;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_chats;
        private System.Windows.Forms.LinkLabel link_chat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Label txt_ID;
        private System.Windows.Forms.Label txt_IP;
        private System.Windows.Forms.Label txt_latitude;
        private System.Windows.Forms.Label txt_longitude;
        private System.Windows.Forms.Label txt_regiao;
        private System.Windows.Forms.Label txt_cidade;
        private System.Windows.Forms.Label txt_estado;
    }
}