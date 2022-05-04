namespace ChatServer
{
    partial class Form1
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.numPorta = new System.Windows.Forms.NumericUpDown();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.listaLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(17, 16);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(300, 34);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            // 
            // numPorta
            // 
            this.numPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPorta.Location = new System.Drawing.Point(328, 16);
            this.numPorta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPorta.Name = "numPorta";
            this.numPorta.Size = new System.Drawing.Size(160, 34);
            this.numPorta.TabIndex = 1;
            this.numPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnStartServer
            // 
            this.btnStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStartServer.Location = new System.Drawing.Point(497, 15);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(265, 37);
            this.btnStartServer.TabIndex = 2;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // listaLog
            // 
            this.listaLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLog.FormattingEnabled = true;
            this.listaLog.HorizontalScrollbar = true;
            this.listaLog.ItemHeight = 29;
            this.listaLog.Location = new System.Drawing.Point(17, 60);
            this.listaLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaLog.Name = "listaLog";
            this.listaLog.Size = new System.Drawing.Size(744, 352);
            this.listaLog.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 437);
            this.Controls.Add(this.listaLog);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.numPorta);
            this.Controls.Add(this.txtIP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor de Chat";
            ((System.ComponentModel.ISupportInitialize)(this.numPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.NumericUpDown numPorta;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.ListBox listaLog;
    }
}

