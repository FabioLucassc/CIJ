namespace DadosPC
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.labelIP = new MetroFramework.Controls.MetroLabel();
            this.textIP = new MetroFramework.Controls.MetroLabel();
            this.textHostName = new MetroFramework.Controls.MetroLabel();
            this.buttonAtulizar = new MetroFramework.Controls.MetroButton();
            this.labelHostName = new MetroFramework.Controls.MetroLabel();
            this.labelIcone = new MetroFramework.Controls.MetroLabel();
            this.capa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.capa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIP
            // 
            this.labelIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelIP.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelIP.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelIP.ForeColor = System.Drawing.Color.White;
            this.labelIP.Location = new System.Drawing.Point(301, 182);
            this.labelIP.MinimumSize = new System.Drawing.Size(240, 57);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(240, 57);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "...";
            this.labelIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelIP.UseCustomBackColor = true;
            this.labelIP.UseCustomForeColor = true;
            this.labelIP.UseStyleColors = true;
            // 
            // textIP
            // 
            this.textIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIP.Cursor = System.Windows.Forms.Cursors.Default;
            this.textIP.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.textIP.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.textIP.ForeColor = System.Drawing.Color.White;
            this.textIP.Location = new System.Drawing.Point(10, 182);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(285, 57);
            this.textIP.TabIndex = 1;
            this.textIP.Text = "Endereço IP :";
            this.textIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textIP.UseCustomForeColor = true;
            // 
            // textHostName
            // 
            this.textHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textHostName.Cursor = System.Windows.Forms.Cursors.Default;
            this.textHostName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.textHostName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.textHostName.ForeColor = System.Drawing.Color.White;
            this.textHostName.Location = new System.Drawing.Point(10, 263);
            this.textHostName.Name = "textHostName";
            this.textHostName.Size = new System.Drawing.Size(285, 59);
            this.textHostName.TabIndex = 3;
            this.textHostName.Text = "HOSTNAME :";
            this.textHostName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textHostName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textHostName.UseCustomForeColor = true;
            // 
            // buttonAtulizar
            // 
            this.buttonAtulizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAtulizar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonAtulizar.ForeColor = System.Drawing.Color.White;
            this.buttonAtulizar.Highlight = true;
            this.buttonAtulizar.Location = new System.Drawing.Point(175, 350);
            this.buttonAtulizar.Name = "buttonAtulizar";
            this.buttonAtulizar.Size = new System.Drawing.Size(235, 41);
            this.buttonAtulizar.Style = MetroFramework.MetroColorStyle.Blue;
            this.buttonAtulizar.TabIndex = 4;
            this.buttonAtulizar.Text = "ATUALIZAR";
            this.buttonAtulizar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonAtulizar.UseSelectable = true;
            this.buttonAtulizar.Click += new System.EventHandler(this.buttonAtulizar_Click);
            // 
            // labelHostName
            // 
            this.labelHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHostName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelHostName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelHostName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelHostName.ForeColor = System.Drawing.Color.White;
            this.labelHostName.Location = new System.Drawing.Point(301, 263);
            this.labelHostName.MinimumSize = new System.Drawing.Size(240, 57);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(240, 57);
            this.labelHostName.TabIndex = 5;
            this.labelHostName.Text = "...";
            this.labelHostName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHostName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelHostName.UseCustomBackColor = true;
            this.labelHostName.UseCustomForeColor = true;
            this.labelHostName.UseStyleColors = true;
            // 
            // labelIcone
            // 
            this.labelIcone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIcone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelIcone.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelIcone.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelIcone.ForeColor = System.Drawing.Color.White;
            this.labelIcone.Location = new System.Drawing.Point(23, 38);
            this.labelIcone.Name = "labelIcone";
            this.labelIcone.Size = new System.Drawing.Size(65, 36);
            this.labelIcone.TabIndex = 6;
            this.labelIcone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIcone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelIcone.UseCustomForeColor = true;
            // 
            // capa
            // 
            this.capa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.capa.Image = ((System.Drawing.Image)(resources.GetObject("capa.Image")));
            this.capa.InitialImage = ((System.Drawing.Image)(resources.GetObject("capa.InitialImage")));
            this.capa.Location = new System.Drawing.Point(141, 38);
            this.capa.Name = "capa";
            this.capa.Size = new System.Drawing.Size(319, 118);
            this.capa.TabIndex = 7;
            this.capa.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 414);
            this.Controls.Add(this.capa);
            this.Controls.Add(this.labelIcone);
            this.Controls.Add(this.labelHostName);
            this.Controls.Add(this.buttonAtulizar);
            this.Controls.Add(this.textHostName);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.labelIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 414);
            this.MinimumSize = new System.Drawing.Size(577, 414);
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelIP;
        private MetroFramework.Controls.MetroLabel textIP;
        private MetroFramework.Controls.MetroLabel textHostName;
        private MetroFramework.Controls.MetroButton buttonAtulizar;
        private MetroFramework.Controls.MetroLabel labelHostName;
        private MetroFramework.Controls.MetroLabel labelIcone;
        private System.Windows.Forms.PictureBox capa;
    }
}

