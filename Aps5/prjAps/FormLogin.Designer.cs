namespace prjAps
{
    partial class FormLogin
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
            this.label_nome = new System.Windows.Forms.Label();
            this.label_sobrenome = new System.Windows.Forms.Label();
            this.label_estado = new System.Windows.Forms.Label();
            this.label_cidade = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txf_nome = new System.Windows.Forms.TextBox();
            this.txf_sobrenome = new System.Windows.Forms.TextBox();
            this.ratioBtn_analista = new System.Windows.Forms.RadioButton();
            this.ratioBtn_denuncia = new System.Windows.Forms.RadioButton();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.cbox_cidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(210, 148);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(61, 22);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome";
            // 
            // label_sobrenome
            // 
            this.label_sobrenome.AutoSize = true;
            this.label_sobrenome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sobrenome.Location = new System.Drawing.Point(434, 148);
            this.label_sobrenome.Name = "label_sobrenome";
            this.label_sobrenome.Size = new System.Drawing.Size(110, 22);
            this.label_sobrenome.TabIndex = 1;
            this.label_sobrenome.Text = "Sobrenome";
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado.Location = new System.Drawing.Point(210, 226);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(70, 22);
            this.label_estado.TabIndex = 2;
            this.label_estado.Text = "Estado";
            // 
            // label_cidade
            // 
            this.label_cidade.AutoSize = true;
            this.label_cidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cidade.Location = new System.Drawing.Point(434, 226);
            this.label_cidade.Name = "label_cidade";
            this.label_cidade.Size = new System.Drawing.Size(71, 22);
            this.label_cidade.TabIndex = 3;
            this.label_cidade.Text = "Cidade";
            this.label_cidade.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(344, 344);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(123, 34);
            this.btn_entrar.TabIndex = 7;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txf_nome
            // 
            this.txf_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txf_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txf_nome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txf_nome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txf_nome.Location = new System.Drawing.Point(214, 173);
            this.txf_nome.Name = "txf_nome";
            this.txf_nome.Size = new System.Drawing.Size(154, 22);
            this.txf_nome.TabIndex = 1;
            // 
            // txf_sobrenome
            // 
            this.txf_sobrenome.AcceptsTab = true;
            this.txf_sobrenome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txf_sobrenome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txf_sobrenome.Location = new System.Drawing.Point(438, 173);
            this.txf_sobrenome.Name = "txf_sobrenome";
            this.txf_sobrenome.Size = new System.Drawing.Size(160, 22);
            this.txf_sobrenome.TabIndex = 2;
            this.txf_sobrenome.TextChanged += new System.EventHandler(this.txf_sobrenome_TextChanged);
            // 
            // ratioBtn_analista
            // 
            this.ratioBtn_analista.AutoSize = true;
            this.ratioBtn_analista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratioBtn_analista.Location = new System.Drawing.Point(232, 308);
            this.ratioBtn_analista.Name = "ratioBtn_analista";
            this.ratioBtn_analista.Size = new System.Drawing.Size(121, 20);
            this.ratioBtn_analista.TabIndex = 5;
            this.ratioBtn_analista.TabStop = true;
            this.ratioBtn_analista.Text = "Sou um Analísta";
            this.ratioBtn_analista.UseVisualStyleBackColor = true;
            this.ratioBtn_analista.CheckedChanged += new System.EventHandler(this.rbtnAnalista_CheckedChanged);
            // 
            // ratioBtn_denuncia
            // 
            this.ratioBtn_denuncia.AutoSize = true;
            this.ratioBtn_denuncia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratioBtn_denuncia.Location = new System.Drawing.Point(461, 308);
            this.ratioBtn_denuncia.Name = "ratioBtn_denuncia";
            this.ratioBtn_denuncia.Size = new System.Drawing.Size(117, 20);
            this.ratioBtn_denuncia.TabIndex = 6;
            this.ratioBtn_denuncia.TabStop = true;
            this.ratioBtn_denuncia.Text = "Fazer Denúncia";
            this.ratioBtn_denuncia.UseVisualStyleBackColor = true;
            this.ratioBtn_denuncia.CheckedChanged += new System.EventHandler(this.rbtnDenuncia_CheckedChanged);
            // 
            // cbox_estado
            // 
            this.cbox_estado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Location = new System.Drawing.Point(214, 251);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(154, 24);
            this.cbox_estado.TabIndex = 3;
            this.cbox_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            // 
            // cbox_cidade
            // 
            this.cbox_cidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_cidade.FormattingEnabled = true;
            this.cbox_cidade.Location = new System.Drawing.Point(438, 251);
            this.cbox_cidade.Name = "cbox_cidade";
            this.cbox_cidade.Size = new System.Drawing.Size(160, 24);
            this.cbox_cidade.TabIndex = 4;
            this.cbox_cidade.SelectedIndexChanged += new System.EventHandler(this.cb_cidade_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Denúncias Florestais";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_cidade);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.ratioBtn_denuncia);
            this.Controls.Add(this.ratioBtn_analista);
            this.Controls.Add(this.txf_sobrenome);
            this.Controls.Add(this.txf_nome);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.label_cidade);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.label_sobrenome);
            this.Controls.Add(this.label_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Phtxbx_GotFocus(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_sobrenome;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.Label label_cidade;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txf_nome;
        private System.Windows.Forms.TextBox txf_sobrenome;
        private System.Windows.Forms.RadioButton ratioBtn_analista;
        private System.Windows.Forms.RadioButton ratioBtn_denuncia;
        private System.Windows.Forms.ComboBox cbox_estado;
        private System.Windows.Forms.ComboBox cbox_cidade;
        private System.Windows.Forms.Label label1;
    }
}

