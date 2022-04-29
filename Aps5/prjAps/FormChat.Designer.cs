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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_denunciante = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txf_WriteChat = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_denunciante);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 45);
            this.panel1.TabIndex = 0;
            // 
            // lbl_denunciante
            // 
            this.lbl_denunciante.AutoSize = true;
            this.lbl_denunciante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_denunciante.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_denunciante.Location = new System.Drawing.Point(120, 10);
            this.lbl_denunciante.Name = "lbl_denunciante";
            this.lbl_denunciante.Size = new System.Drawing.Size(115, 22);
            this.lbl_denunciante.TabIndex = 0;
            this.lbl_denunciante.Text = "Denunciante";
            this.lbl_denunciante.Click += new System.EventHandler(this.lbl_denunciante_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtLog);
            this.panel2.Location = new System.Drawing.Point(13, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 337);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btn_Send);
            this.panel3.Controls.Add(this.txf_WriteChat);
            this.panel3.Location = new System.Drawing.Point(13, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 32);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 22);
            this.panel4.TabIndex = 2;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Send.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Send.Location = new System.Drawing.Point(282, 3);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(65, 22);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "Enviar";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // txf_WriteChat
            // 
            this.txf_WriteChat.Location = new System.Drawing.Point(38, 3);
            this.txf_WriteChat.Name = "txf_WriteChat";
            this.txf_WriteChat.Size = new System.Drawing.Size(238, 20);
            this.txf_WriteChat.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(-2, -2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(354, 337);
            this.txtLog.TabIndex = 0;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 441);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormChat";
            this.Text = "Chat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_denunciante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txf_WriteChat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtLog;
    }
}