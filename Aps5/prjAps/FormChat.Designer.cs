namespace prjAps
{
    partial class FormChat
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
            this.pnlDenunciante = new System.Windows.Forms.Panel();
            this.lblDenunciante = new System.Windows.Forms.Label();
            this.pnlTxtLog = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTxtMensagem = new prjAps.RJPanel();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new prjAps.RJButton();
            this.pnlDenunciante.SuspendLayout();
            this.pnlTxtLog.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlTxtMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDenunciante
            // 
            this.pnlDenunciante.Controls.Add(this.lblDenunciante);
            this.pnlDenunciante.Location = new System.Drawing.Point(13, 13);
            this.pnlDenunciante.Name = "pnlDenunciante";
            this.pnlDenunciante.Size = new System.Drawing.Size(488, 45);
            this.pnlDenunciante.TabIndex = 0;
            // 
            // lblDenunciante
            // 
            this.lblDenunciante.AutoSize = true;
            this.lblDenunciante.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold);
            this.lblDenunciante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.lblDenunciante.Location = new System.Drawing.Point(166, 5);
            this.lblDenunciante.Name = "lblDenunciante";
            this.lblDenunciante.Size = new System.Drawing.Size(187, 34);
            this.lblDenunciante.TabIndex = 88;
            this.lblDenunciante.Text = "Denunciante";
            // 
            // pnlTxtLog
            // 
            this.pnlTxtLog.Controls.Add(this.txtLog);
            this.pnlTxtLog.Location = new System.Drawing.Point(13, 65);
            this.pnlTxtLog.Name = "pnlTxtLog";
            this.pnlTxtLog.Size = new System.Drawing.Size(488, 531);
            this.pnlTxtLog.TabIndex = 887;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLog.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.txtLog.Location = new System.Drawing.Point(-1, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(506, 526);
            this.txtLog.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlTxtMensagem);
            this.panel3.Controls.Add(this.btnEnviar);
            this.panel3.Location = new System.Drawing.Point(13, 602);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 82);
            this.panel3.TabIndex = 2;
            // 
            // pnlTxtMensagem
            // 
            this.pnlTxtMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.pnlTxtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTxtMensagem.Controls.Add(this.txtMensagem);
            this.pnlTxtMensagem.ForeColor = System.Drawing.Color.White;
            this.pnlTxtMensagem.Location = new System.Drawing.Point(0, 0);
            this.pnlTxtMensagem.Name = "pnlTxtMensagem";
            this.pnlTxtMensagem.Size = new System.Drawing.Size(365, 35);
            this.pnlTxtMensagem.TabIndex = 12;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.ForeColor = System.Drawing.Color.Black;
            this.txtMensagem.Location = new System.Drawing.Point(15, 6);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(337, 22);
            this.txtMensagem.TabIndex = 1;
            this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(215)))), ((int)(((byte)(88)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(374, 0);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(114, 35);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(510, 646);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTxtLog);
            this.Controls.Add(this.pnlDenunciante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormChat";
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChat_FormClosed);
            this.pnlDenunciante.ResumeLayout(false);
            this.pnlDenunciante.PerformLayout();
            this.pnlTxtLog.ResumeLayout(false);
            this.pnlTxtLog.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlTxtMensagem.ResumeLayout(false);
            this.pnlTxtMensagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDenunciante;
        private System.Windows.Forms.Label lblDenunciante;
        private System.Windows.Forms.Panel pnlTxtLog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtLog;
        private RJButton btnEnviar;
        private RJPanel pnlTxtMensagem;
    }
}