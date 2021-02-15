namespace WordPadAM
{
    partial class WordPadAM
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordPadAM));
            this.tls1 = new System.Windows.Forms.ToolStrip();
            this.cmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.cmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnFontUp = new System.Windows.Forms.ToolStripButton();
            this.btnFontDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnJustify = new System.Windows.Forms.ToolStripButton();
            this.btnBulletList = new System.Windows.Forms.ToolStripButton();
            this.btnLineSpacing = new System.Windows.Forms.ToolStripButton();
            this.tls2 = new System.Windows.Forms.ToolStrip();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.btnFontColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLeft = new System.Windows.Forms.ToolStripButton();
            this.btnCenter = new System.Windows.Forms.ToolStripButton();
            this.btnRight = new System.Windows.Forms.ToolStripButton();
            this.rtxDocumento = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.View = new System.Windows.Forms.TabPage();
            this.MailTls = new System.Windows.Forms.ToolStrip();
            this.btnNewDoc = new System.Windows.Forms.ToolStripButton();
            this.btnOpenDoc = new System.Windows.Forms.ToolStripButton();
            this.btnSaveDoc = new System.Windows.Forms.ToolStripButton();
            this.tls1.SuspendLayout();
            this.tls2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.MailTls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tls1
            // 
            this.tls1.Dock = System.Windows.Forms.DockStyle.None;
            this.tls1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbFont,
            this.cmbSize,
            this.btnFontUp,
            this.btnFontDown,
            this.toolStripSeparator2,
            this.btnJustify,
            this.btnBulletList,
            this.btnLineSpacing});
            this.tls1.Location = new System.Drawing.Point(3, 3);
            this.tls1.Name = "tls1";
            this.tls1.Size = new System.Drawing.Size(364, 25);
            this.tls1.TabIndex = 0;
            this.tls1.Text = "toolStrip1";
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 25);
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(75, 25);
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // btnFontUp
            // 
            this.btnFontUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFontUp.Image = ((System.Drawing.Image)(resources.GetObject("btnFontUp.Image")));
            this.btnFontUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFontUp.Name = "btnFontUp";
            this.btnFontUp.Size = new System.Drawing.Size(23, 22);
            this.btnFontUp.Text = "Font Up";
            this.btnFontUp.Click += new System.EventHandler(this.btnFontUp_Click);
            // 
            // btnFontDown
            // 
            this.btnFontDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFontDown.Image = ((System.Drawing.Image)(resources.GetObject("btnFontDown.Image")));
            this.btnFontDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFontDown.Name = "btnFontDown";
            this.btnFontDown.Size = new System.Drawing.Size(23, 22);
            this.btnFontDown.Text = "Font Down";
            this.btnFontDown.Click += new System.EventHandler(this.btnFontDown_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnJustify
            // 
            this.btnJustify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnJustify.Image = ((System.Drawing.Image)(resources.GetObject("btnJustify.Image")));
            this.btnJustify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJustify.Name = "btnJustify";
            this.btnJustify.Size = new System.Drawing.Size(23, 22);
            this.btnJustify.Text = "Justify";
            this.btnJustify.Click += new System.EventHandler(this.BtnJustify_Click);
            // 
            // btnBulletList
            // 
            this.btnBulletList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBulletList.Image = ((System.Drawing.Image)(resources.GetObject("btnBulletList.Image")));
            this.btnBulletList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBulletList.Name = "btnBulletList";
            this.btnBulletList.Size = new System.Drawing.Size(23, 22);
            this.btnBulletList.Text = "Bullet List";
            this.btnBulletList.Click += new System.EventHandler(this.btnBulletList_Click);
            // 
            // btnLineSpacing
            // 
            this.btnLineSpacing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLineSpacing.Image = ((System.Drawing.Image)(resources.GetObject("btnLineSpacing.Image")));
            this.btnLineSpacing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLineSpacing.Name = "btnLineSpacing";
            this.btnLineSpacing.Size = new System.Drawing.Size(23, 22);
            this.btnLineSpacing.Text = "toolStripButton1";
            // 
            // tls2
            // 
            this.tls2.Dock = System.Windows.Forms.DockStyle.None;
            this.tls2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBold,
            this.btnItalic,
            this.btnUnderline,
            this.btnFontColor,
            this.toolStripSeparator1,
            this.btnLeft,
            this.btnCenter,
            this.btnRight});
            this.tls2.Location = new System.Drawing.Point(3, 28);
            this.tls2.Name = "tls2";
            this.tls2.Size = new System.Drawing.Size(338, 25);
            this.tls2.TabIndex = 1;
            this.tls2.Text = "toolStrip2";
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "Italic";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnFontColor
            // 
            this.btnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFontColor.Image = ((System.Drawing.Image)(resources.GetObject("btnFontColor.Image")));
            this.btnFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(23, 22);
            this.btnFontColor.Text = "Font Color";
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(159, 0, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLeft
            // 
            this.btnLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(23, 22);
            this.btnLeft.Text = "Left";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnCenter.Image")));
            this.btnCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(23, 22);
            this.btnCenter.Text = "Center";
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnRight
            // 
            this.btnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(23, 22);
            this.btnRight.Text = "Right";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // rtxDocumento
            // 
            this.rtxDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxDocumento.Location = new System.Drawing.Point(12, 120);
            this.rtxDocumento.Name = "rtxDocumento";
            this.rtxDocumento.Size = new System.Drawing.Size(776, 318);
            this.rtxDocumento.TabIndex = 2;
            this.rtxDocumento.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.View);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 86);
            this.tabControl1.TabIndex = 3;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.tls2);
            this.Home.Controls.Add(this.tls1);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(768, 60);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(4, 22);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(3);
            this.View.Size = new System.Drawing.Size(768, 60);
            this.View.TabIndex = 1;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            // 
            // MailTls
            // 
            this.MailTls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewDoc,
            this.btnOpenDoc,
            this.btnSaveDoc});
            this.MailTls.Location = new System.Drawing.Point(0, 0);
            this.MailTls.Name = "MailTls";
            this.MailTls.Size = new System.Drawing.Size(800, 25);
            this.MailTls.TabIndex = 4;
            this.MailTls.Text = "toolStrip1";
            // 
            // btnNewDoc
            // 
            this.btnNewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDoc.Image")));
            this.btnNewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewDoc.Name = "btnNewDoc";
            this.btnNewDoc.Size = new System.Drawing.Size(23, 22);
            this.btnNewDoc.Text = "&New";
            // 
            // btnOpenDoc
            // 
            this.btnOpenDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenDoc.Image")));
            this.btnOpenDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenDoc.Name = "btnOpenDoc";
            this.btnOpenDoc.Size = new System.Drawing.Size(23, 22);
            this.btnOpenDoc.Text = "&Open";
            // 
            // btnSaveDoc
            // 
            this.btnSaveDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDoc.Image")));
            this.btnSaveDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveDoc.Name = "btnSaveDoc";
            this.btnSaveDoc.Size = new System.Drawing.Size(23, 22);
            this.btnSaveDoc.Text = "&Save";
            // 
            // WordPadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MailTls);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rtxDocumento);
            this.Name = "WordPadAM";
            this.Text = "W O R D P A D";
            this.Load += new System.EventHandler(this.WordPadAM_Load);
            this.tls1.ResumeLayout(false);
            this.tls1.PerformLayout();
            this.tls2.ResumeLayout(false);
            this.tls2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.MailTls.ResumeLayout(false);
            this.MailTls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tls1;
        private System.Windows.Forms.ToolStrip tls2;
        private System.Windows.Forms.ToolStripComboBox cmbFont;
        private System.Windows.Forms.ToolStripComboBox cmbSize;
        private System.Windows.Forms.ToolStripButton btnFontUp;
        private System.Windows.Forms.ToolStripButton btnFontDown;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBulletList;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripButton btnFontColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLeft;
        private System.Windows.Forms.ToolStripButton btnCenter;
        private System.Windows.Forms.ToolStripButton btnRight;
        private System.Windows.Forms.RichTextBox rtxDocumento;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage View;
        private System.Windows.Forms.ToolStrip MailTls;
        private System.Windows.Forms.ToolStripButton btnNewDoc;
        private System.Windows.Forms.ToolStripButton btnOpenDoc;
        private System.Windows.Forms.ToolStripButton btnSaveDoc;
        private System.Windows.Forms.ToolStripButton btnJustify;
        private System.Windows.Forms.ToolStripButton btnLineSpacing;
    }
}

