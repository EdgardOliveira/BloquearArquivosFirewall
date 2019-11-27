namespace ListaArquivos
{
    partial class frmListarArquivos
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
            this.btnListar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.rchtxtArquivos = new System.Windows.Forms.RichTextBox();
            this.fbdSelecionarDiretorio = new System.Windows.Forms.FolderBrowserDialog();
            this.txtbxCaminho = new System.Windows.Forms.TextBox();
            this.btnSaidaFirewall = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(144, 4);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(58, 20);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(141, 365);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(124, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade de Arquivos:";
            // 
            // rchtxtArquivos
            // 
            this.rchtxtArquivos.Location = new System.Drawing.Point(144, 53);
            this.rchtxtArquivos.Margin = new System.Windows.Forms.Padding(2);
            this.rchtxtArquivos.Name = "rchtxtArquivos";
            this.rchtxtArquivos.Size = new System.Drawing.Size(228, 310);
            this.rchtxtArquivos.TabIndex = 3;
            this.rchtxtArquivos.Text = "";
            // 
            // txtbxCaminho
            // 
            this.txtbxCaminho.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbxCaminho.Enabled = false;
            this.txtbxCaminho.Location = new System.Drawing.Point(144, 29);
            this.txtbxCaminho.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxCaminho.Name = "txtbxCaminho";
            this.txtbxCaminho.Size = new System.Drawing.Size(228, 20);
            this.txtbxCaminho.TabIndex = 4;
            // 
            // btnSaidaFirewall
            // 
            this.btnSaidaFirewall.Location = new System.Drawing.Point(212, 4);
            this.btnSaidaFirewall.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaidaFirewall.Name = "btnSaidaFirewall";
            this.btnSaidaFirewall.Size = new System.Drawing.Size(160, 20);
            this.btnSaidaFirewall.TabIndex = 5;
            this.btnSaidaFirewall.Text = "Bloquear Saída no Firewall";
            this.btnSaidaFirewall.UseVisualStyleBackColor = true;
            this.btnSaidaFirewall.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 384);
            this.panel1.TabIndex = 6;
            // 
            // frmListarArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaidaFirewall);
            this.Controls.Add(this.txtbxCaminho);
            this.Controls.Add(this.rchtxtArquivos);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnListar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListarArquivos";
            this.Text = "Arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.RichTextBox rchtxtArquivos;
        private System.Windows.Forms.FolderBrowserDialog fbdSelecionarDiretorio;
        private System.Windows.Forms.TextBox txtbxCaminho;
        private System.Windows.Forms.Button btnSaidaFirewall;
        private System.Windows.Forms.Panel panel1;
    }
}

