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
            System.Windows.Forms.Panel pnlAtendimentos;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnalista));
            this.pnlTxtMensagem = new prjAps.RJPanel();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new prjAps.RJButton();
            this.atendimentoLog = new System.Windows.Forms.TextBox();
            this.txtRegiao = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.lblEstadoAnalista = new System.Windows.Forms.Label();
            this.lblCidadeAnalista = new System.Windows.Forms.Label();
            this.lblNomeAnalista = new System.Windows.Forms.Label();
            this.panel_lblAtendimento = new System.Windows.Forms.Panel();
            this.lblAtendimentos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.tblLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNome = new System.Windows.Forms.Panel();
            this.pnlIP = new System.Windows.Forms.Panel();
            this.txtIP = new System.Windows.Forms.Label();
            this.pnlRegiao = new System.Windows.Forms.Panel();
            this.pnlCidade = new System.Windows.Forms.Panel();
            this.pnlEstado = new System.Windows.Forms.Panel();
            pnlAtendimentos = new System.Windows.Forms.Panel();
            pnlAtendimentos.SuspendLayout();
            this.pnlTxtMensagem.SuspendLayout();
            this.panel_lblAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.tblLayoutPnl.SuspendLayout();
            this.pnlNome.SuspendLayout();
            this.pnlIP.SuspendLayout();
            this.pnlRegiao.SuspendLayout();
            this.pnlCidade.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAtendimentos
            // 
            pnlAtendimentos.Controls.Add(this.pnlTxtMensagem);
            pnlAtendimentos.Controls.Add(this.btnEnviar);
            pnlAtendimentos.Controls.Add(this.atendimentoLog);
            pnlAtendimentos.Location = new System.Drawing.Point(266, 106);
            pnlAtendimentos.Name = "pnlAtendimentos";
            pnlAtendimentos.Size = new System.Drawing.Size(727, 446);
            pnlAtendimentos.TabIndex = 999;
            // 
            // pnlTxtMensagem
            // 
            this.pnlTxtMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.pnlTxtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTxtMensagem.Controls.Add(this.txtMensagem);
            this.pnlTxtMensagem.ForeColor = System.Drawing.Color.White;
            this.pnlTxtMensagem.Location = new System.Drawing.Point(0, 389);
            this.pnlTxtMensagem.Name = "pnlTxtMensagem";
            this.pnlTxtMensagem.Size = new System.Drawing.Size(570, 35);
            this.pnlTxtMensagem.TabIndex = 11;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.ForeColor = System.Drawing.Color.Black;
            this.txtMensagem.Location = new System.Drawing.Point(23, 6);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(524, 22);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(583, 388);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(141, 36);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // atendimentoLog
            // 
            this.atendimentoLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.atendimentoLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.atendimentoLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.atendimentoLog.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atendimentoLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.atendimentoLog.Location = new System.Drawing.Point(24, 0);
            this.atendimentoLog.Multiline = true;
            this.atendimentoLog.Name = "atendimentoLog";
            this.atendimentoLog.ReadOnly = true;
            this.atendimentoLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.atendimentoLog.Size = new System.Drawing.Size(721, 371);
            this.atendimentoLog.TabIndex = 99;
            this.atendimentoLog.TabStop = false;
            // 
            // txtRegiao
            // 
            this.txtRegiao.AutoSize = true;
            this.txtRegiao.BackColor = System.Drawing.Color.Transparent;
            this.txtRegiao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegiao.ForeColor = System.Drawing.Color.White;
            this.txtRegiao.Location = new System.Drawing.Point(6, 29);
            this.txtRegiao.Name = "txtRegiao";
            this.txtRegiao.Size = new System.Drawing.Size(149, 18);
            this.txtRegiao.TabIndex = 16;
            this.txtRegiao.Text = "São Paulo e Região";
            // 
            // txtCidade
            // 
            this.txtCidade.AutoSize = true;
            this.txtCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.White;
            this.txtCidade.Location = new System.Drawing.Point(6, 29);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(45, 18);
            this.txtCidade.TabIndex = 15;
            this.txtCidade.Text = "Null...";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.White;
            this.txtEstado.Location = new System.Drawing.Point(6, 29);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(45, 18);
            this.txtEstado.TabIndex = 14;
            this.txtEstado.Text = "Null...";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(6, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(45, 18);
            this.txtNome.TabIndex = 123;
            this.txtNome.Text = "Null...";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblIP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lblIP.Location = new System.Drawing.Point(6, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(118, 19);
            this.lblIP.TabIndex = 12;
            this.lblIP.Text = "IP do Analista:";
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblRegiao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lblRegiao.Location = new System.Drawing.Point(6, 0);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(191, 19);
            this.lblRegiao.TabIndex = 865;
            this.lblRegiao.Text = "Região de atendimento:";
            // 
            // lblEstadoAnalista
            // 
            this.lblEstadoAnalista.AutoSize = true;
            this.lblEstadoAnalista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEstadoAnalista.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAnalista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lblEstadoAnalista.Location = new System.Drawing.Point(6, 0);
            this.lblEstadoAnalista.Name = "lblEstadoAnalista";
            this.lblEstadoAnalista.Size = new System.Drawing.Size(157, 19);
            this.lblEstadoAnalista.TabIndex = 1234;
            this.lblEstadoAnalista.Text = "Estado do Analista:";
            // 
            // lblCidadeAnalista
            // 
            this.lblCidadeAnalista.AutoSize = true;
            this.lblCidadeAnalista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCidadeAnalista.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeAnalista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lblCidadeAnalista.Location = new System.Drawing.Point(6, 0);
            this.lblCidadeAnalista.Name = "lblCidadeAnalista";
            this.lblCidadeAnalista.Size = new System.Drawing.Size(157, 19);
            this.lblCidadeAnalista.TabIndex = 86;
            this.lblCidadeAnalista.Text = "Cidade do Analista:";
            // 
            // lblNomeAnalista
            // 
            this.lblNomeAnalista.AutoSize = true;
            this.lblNomeAnalista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNomeAnalista.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAnalista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lblNomeAnalista.Location = new System.Drawing.Point(6, 0);
            this.lblNomeAnalista.Name = "lblNomeAnalista";
            this.lblNomeAnalista.Size = new System.Drawing.Size(148, 19);
            this.lblNomeAnalista.TabIndex = 123;
            this.lblNomeAnalista.Text = "Nome do Analista:";
            // 
            // panel_lblAtendimento
            // 
            this.panel_lblAtendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel_lblAtendimento.Controls.Add(this.lblAtendimentos);
            this.panel_lblAtendimento.Location = new System.Drawing.Point(266, 12);
            this.panel_lblAtendimento.Name = "panel_lblAtendimento";
            this.panel_lblAtendimento.Size = new System.Drawing.Size(727, 85);
            this.panel_lblAtendimento.TabIndex = 122;
            // 
            // lblAtendimentos
            // 
            this.lblAtendimentos.AutoSize = true;
            this.lblAtendimentos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAtendimentos.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lblAtendimentos.Location = new System.Drawing.Point(184, 26);
            this.lblAtendimentos.Name = "lblAtendimentos";
            this.lblAtendimentos.Size = new System.Drawing.Size(364, 34);
            this.lblAtendimentos.TabIndex = 17;
            this.lblAtendimentos.Text = "Atendimentos Realizados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "567";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.labelTitulo.Location = new System.Drawing.Point(59, 24);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(149, 40);
            this.labelTitulo.TabIndex = 32;
            this.labelTitulo.Text = "ChatFlor";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlLogo.Controls.Add(this.labelTitulo);
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Location = new System.Drawing.Point(2, 9);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(258, 88);
            this.pnlLogo.TabIndex = 21;
            // 
            // tblLayoutPnl
            // 
            this.tblLayoutPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tblLayoutPnl.ColumnCount = 1;
            this.tblLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPnl.Controls.Add(this.pnlNome, 0, 0);
            this.tblLayoutPnl.Controls.Add(this.pnlIP, 0, 4);
            this.tblLayoutPnl.Controls.Add(this.pnlRegiao, 0, 3);
            this.tblLayoutPnl.Controls.Add(this.pnlCidade, 0, 2);
            this.tblLayoutPnl.Controls.Add(this.pnlEstado, 0, 1);
            this.tblLayoutPnl.Location = new System.Drawing.Point(2, 106);
            this.tblLayoutPnl.Name = "tblLayoutPnl";
            this.tblLayoutPnl.RowCount = 6;
            this.tblLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67032F));
            this.tblLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tblLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tblLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tblLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tblLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tblLayoutPnl.Size = new System.Drawing.Size(255, 446);
            this.tblLayoutPnl.TabIndex = 75;
            // 
            // pnlNome
            // 
            this.pnlNome.Controls.Add(this.txtNome);
            this.pnlNome.Controls.Add(this.lblNomeAnalista);
            this.pnlNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNome.Location = new System.Drawing.Point(3, 3);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(249, 68);
            this.pnlNome.TabIndex = 11;
            // 
            // pnlIP
            // 
            this.pnlIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlIP.Controls.Add(this.lblIP);
            this.pnlIP.Controls.Add(this.txtIP);
            this.pnlIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIP.Location = new System.Drawing.Point(3, 299);
            this.pnlIP.Name = "pnlIP";
            this.pnlIP.Size = new System.Drawing.Size(249, 68);
            this.pnlIP.TabIndex = 12;
            // 
            // txtIP
            // 
            this.txtIP.AutoSize = true;
            this.txtIP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.Color.White;
            this.txtIP.Location = new System.Drawing.Point(6, 29);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(45, 18);
            this.txtIP.TabIndex = 19;
            this.txtIP.Text = "Null...";
            // 
            // pnlRegiao
            // 
            this.pnlRegiao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlRegiao.Controls.Add(this.lblRegiao);
            this.pnlRegiao.Controls.Add(this.txtRegiao);
            this.pnlRegiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegiao.Location = new System.Drawing.Point(3, 225);
            this.pnlRegiao.Name = "pnlRegiao";
            this.pnlRegiao.Size = new System.Drawing.Size(249, 68);
            this.pnlRegiao.TabIndex = 12;
            // 
            // pnlCidade
            // 
            this.pnlCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlCidade.Controls.Add(this.lblCidadeAnalista);
            this.pnlCidade.Controls.Add(this.txtCidade);
            this.pnlCidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCidade.Location = new System.Drawing.Point(3, 151);
            this.pnlCidade.Name = "pnlCidade";
            this.pnlCidade.Size = new System.Drawing.Size(249, 68);
            this.pnlCidade.TabIndex = 46;
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlEstado.Controls.Add(this.lblEstadoAnalista);
            this.pnlEstado.Controls.Add(this.txtEstado);
            this.pnlEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.pnlEstado.Location = new System.Drawing.Point(3, 77);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(249, 68);
            this.pnlEstado.TabIndex = 11;
            // 
            // FormAnalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1005, 542);
            this.Controls.Add(this.tblLayoutPnl);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(pnlAtendimentos);
            this.Controls.Add(this.panel_lblAtendimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAnalista";
            this.Text = "Denúncias Florestais";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAnalista_FormClosed);
            pnlAtendimentos.ResumeLayout(false);
            pnlAtendimentos.PerformLayout();
            this.pnlTxtMensagem.ResumeLayout(false);
            this.pnlTxtMensagem.PerformLayout();
            this.panel_lblAtendimento.ResumeLayout(false);
            this.panel_lblAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.tblLayoutPnl.ResumeLayout(false);
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            this.pnlIP.ResumeLayout(false);
            this.pnlIP.PerformLayout();
            this.pnlRegiao.ResumeLayout(false);
            this.pnlRegiao.PerformLayout();
            this.pnlCidade.ResumeLayout(false);
            this.pnlCidade.PerformLayout();
            this.pnlEstado.ResumeLayout(false);
            this.pnlEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.Label lblEstadoAnalista;
        private System.Windows.Forms.Label lblCidadeAnalista;
        private System.Windows.Forms.Label lblNomeAnalista;
        private System.Windows.Forms.Panel panel_lblAtendimento;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblAtendimentos;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtRegiao;
        private System.Windows.Forms.Label txtCidade;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.TextBox atendimentoLog;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPnl;
        private System.Windows.Forms.Panel pnlIP;
        private System.Windows.Forms.Panel pnlRegiao;
        private System.Windows.Forms.Panel pnlCidade;
        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Panel pnlNome;
        private RJButton btnEnviar;
        private RJPanel pnlTxtMensagem;
        private System.Windows.Forms.Label txtIP;
    }
}