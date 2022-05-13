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
            System.Windows.Forms.Panel panel_atendimentos;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnalista));
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.atendimentoLog = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.Label();
            this.txt_regiao = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_regiao = new System.Windows.Forms.Label();
            this.lbl_estadoAnalista = new System.Windows.Forms.Label();
            this.lbl_cidadeAnalista = new System.Windows.Forms.Label();
            this.lbl_nomeAnalista = new System.Windows.Forms.Label();
            this.panel_lblAtendimento = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEnviar = new prjAps.RJButton();
            this.rjPanel1 = new prjAps.RJPanel();
            panel_atendimentos = new System.Windows.Forms.Panel();
            panel_atendimentos.SuspendLayout();
            this.panel_lblAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_atendimentos
            // 
            panel_atendimentos.Controls.Add(this.rjPanel1);
            panel_atendimentos.Controls.Add(this.btnEnviar);
            panel_atendimentos.Controls.Add(this.atendimentoLog);
            panel_atendimentos.Location = new System.Drawing.Point(183, 57);
            panel_atendimentos.Name = "panel_atendimentos";
            panel_atendimentos.Size = new System.Drawing.Size(753, 473);
            panel_atendimentos.TabIndex = 4;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(23, 6);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(551, 22);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.Text = " ";
            this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
            // 
            // atendimentoLog
            // 
            this.atendimentoLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.atendimentoLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.atendimentoLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.atendimentoLog.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atendimentoLog.Location = new System.Drawing.Point(-1, 3);
            this.atendimentoLog.Multiline = true;
            this.atendimentoLog.Name = "atendimentoLog";
            this.atendimentoLog.ReadOnly = true;
            this.atendimentoLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.atendimentoLog.Size = new System.Drawing.Size(752, 481);
            this.atendimentoLog.TabIndex = 9;
            this.atendimentoLog.TextChanged += new System.EventHandler(this.atendimentoLog_TextChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.AutoSize = true;
            this.txt_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txt_ID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.ForeColor = System.Drawing.Color.White;
            this.txt_ID.Location = new System.Drawing.Point(3, 29);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(42, 16);
            this.txt_ID.TabIndex = 20;
            this.txt_ID.Text = "Null...";
            // 
            // txt_IP
            // 
            this.txt_IP.AutoSize = true;
            this.txt_IP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.ForeColor = System.Drawing.Color.White;
            this.txt_IP.Location = new System.Drawing.Point(3, 29);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(42, 16);
            this.txt_IP.TabIndex = 19;
            this.txt_IP.Text = "Null...";
            // 
            // txt_regiao
            // 
            this.txt_regiao.AutoSize = true;
            this.txt_regiao.Enabled = false;
            this.txt_regiao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regiao.ForeColor = System.Drawing.Color.White;
            this.txt_regiao.Location = new System.Drawing.Point(3, 29);
            this.txt_regiao.Name = "txt_regiao";
            this.txt_regiao.Size = new System.Drawing.Size(123, 16);
            this.txt_regiao.TabIndex = 16;
            this.txt_regiao.Text = "São Paulo e Região";
            // 
            // txt_cidade
            // 
            this.txt_cidade.AutoSize = true;
            this.txt_cidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.ForeColor = System.Drawing.Color.White;
            this.txt_cidade.Location = new System.Drawing.Point(3, 29);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(42, 16);
            this.txt_cidade.TabIndex = 15;
            this.txt_cidade.Text = "Null...";
            // 
            // txt_estado
            // 
            this.txt_estado.AutoSize = true;
            this.txt_estado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.ForeColor = System.Drawing.Color.White;
            this.txt_estado.Location = new System.Drawing.Point(3, 29);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(42, 16);
            this.txt_estado.TabIndex = 14;
            this.txt_estado.Text = "Null...";
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.White;
            this.txt_nome.Location = new System.Drawing.Point(3, 29);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(42, 16);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.Text = "Null...";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_ID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lbl_ID.Location = new System.Drawing.Point(3, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(100, 16);
            this.lbl_ID.TabIndex = 13;
            this.lbl_ID.Text = "ID do Analista:";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_IP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lbl_IP.Location = new System.Drawing.Point(3, 0);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(100, 16);
            this.lbl_IP.TabIndex = 12;
            this.lbl_IP.Text = "IP do Analista:";
            // 
            // lbl_regiao
            // 
            this.lbl_regiao.AutoSize = true;
            this.lbl_regiao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_regiao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regiao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lbl_regiao.Location = new System.Drawing.Point(3, 0);
            this.lbl_regiao.Name = "lbl_regiao";
            this.lbl_regiao.Size = new System.Drawing.Size(161, 16);
            this.lbl_regiao.TabIndex = 6;
            this.lbl_regiao.Text = "Região de atendimento:";
            this.lbl_regiao.Click += new System.EventHandler(this.lbl_regiao_Click);
            // 
            // lbl_estadoAnalista
            // 
            this.lbl_estadoAnalista.AutoSize = true;
            this.lbl_estadoAnalista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_estadoAnalista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoAnalista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lbl_estadoAnalista.Location = new System.Drawing.Point(3, 0);
            this.lbl_estadoAnalista.Name = "lbl_estadoAnalista";
            this.lbl_estadoAnalista.Size = new System.Drawing.Size(129, 16);
            this.lbl_estadoAnalista.TabIndex = 1;
            this.lbl_estadoAnalista.Text = "Estado do Analista:";
            // 
            // lbl_cidadeAnalista
            // 
            this.lbl_cidadeAnalista.AutoSize = true;
            this.lbl_cidadeAnalista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_cidadeAnalista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidadeAnalista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lbl_cidadeAnalista.Location = new System.Drawing.Point(3, 0);
            this.lbl_cidadeAnalista.Name = "lbl_cidadeAnalista";
            this.lbl_cidadeAnalista.Size = new System.Drawing.Size(132, 16);
            this.lbl_cidadeAnalista.TabIndex = 0;
            this.lbl_cidadeAnalista.Text = "Cidade do Analista:";
            // 
            // lbl_nomeAnalista
            // 
            this.lbl_nomeAnalista.AutoSize = true;
            this.lbl_nomeAnalista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_nomeAnalista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeAnalista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lbl_nomeAnalista.Location = new System.Drawing.Point(3, 0);
            this.lbl_nomeAnalista.Name = "lbl_nomeAnalista";
            this.lbl_nomeAnalista.Size = new System.Drawing.Size(124, 16);
            this.lbl_nomeAnalista.TabIndex = 0;
            this.lbl_nomeAnalista.Text = "Nome do Analista:";
            this.lbl_nomeAnalista.Click += new System.EventHandler(this.lbl_nomeAnalista_Click);
            // 
            // panel_lblAtendimento
            // 
            this.panel_lblAtendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel_lblAtendimento.Controls.Add(this.label1);
            this.panel_lblAtendimento.Location = new System.Drawing.Point(183, 12);
            this.panel_lblAtendimento.Name = "panel_lblAtendimento";
            this.panel_lblAtendimento.Size = new System.Drawing.Size(753, 39);
            this.panel_lblAtendimento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Atendimentos Realizados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.labelTitulo.Location = new System.Drawing.Point(51, 39);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(129, 34);
            this.labelTitulo.TabIndex = 32;
            this.labelTitulo.Text = "ChatFlor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 88);
            this.panel1.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(167, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67032F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(175, 424);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_nome);
            this.panel2.Controls.Add(this.lbl_nomeAnalista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 64);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel7.Controls.Add(this.lbl_IP);
            this.panel7.Controls.Add(this.txt_IP);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 283);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 64);
            this.panel7.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel6.Controls.Add(this.lbl_regiao);
            this.panel6.Controls.Add(this.txt_regiao);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 213);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 64);
            this.panel6.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.lbl_cidadeAnalista);
            this.panel5.Controls.Add(this.txt_cidade);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 64);
            this.panel5.TabIndex = 12;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.lbl_estadoAnalista);
            this.panel3.Controls.Add(this.txt_estado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.panel3.Location = new System.Drawing.Point(3, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 64);
            this.panel3.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel8.Controls.Add(this.lbl_ID);
            this.panel8.Controls.Add(this.txt_ID);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 353);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(169, 68);
            this.panel8.TabIndex = 12;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviar.Location = new System.Drawing.Point(613, 426);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 35);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.rjPanel1.Controls.Add(this.txtMensagem);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(3, 426);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(604, 35);
            this.rjPanel1.TabIndex = 11;
            // 
            // FormAnalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(948, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(panel_atendimentos);
            this.Controls.Add(this.panel_lblAtendimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAnalista";
            this.Text = "Denúncias Florestais";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAnalista_FormClosed);
            panel_atendimentos.ResumeLayout(false);
            panel_atendimentos.PerformLayout();
            this.panel_lblAtendimento.ResumeLayout(false);
            this.panel_lblAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_regiao;
        private System.Windows.Forms.Label lbl_estadoAnalista;
        private System.Windows.Forms.Label lbl_cidadeAnalista;
        private System.Windows.Forms.Label lbl_nomeAnalista;
        private System.Windows.Forms.Panel panel_lblAtendimento;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Label txt_ID;
        private System.Windows.Forms.Label txt_IP;
        private System.Windows.Forms.Label txt_regiao;
        private System.Windows.Forms.Label txt_cidade;
        private System.Windows.Forms.Label txt_estado;
        private System.Windows.Forms.TextBox atendimentoLog;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private RJButton btnEnviar;
        private RJPanel rjPanel1;
    }
}