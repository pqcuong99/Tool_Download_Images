namespace Tool_Download_Image_Inspireuplift
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLinkShop = new System.Windows.Forms.TextBox();
            this.txtPathSave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtSlDownloadDone = new System.Windows.Forms.Label();
            this.btnDownload1Page = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link shop:";
            // 
            // txtLinkShop
            // 
            this.txtLinkShop.Location = new System.Drawing.Point(30, 52);
            this.txtLinkShop.Name = "txtLinkShop";
            this.txtLinkShop.Size = new System.Drawing.Size(359, 20);
            this.txtLinkShop.TabIndex = 1;
            this.txtLinkShop.Text = "https://www.etsy.com/shop/PawtraitDesignArt?ref=l2-about-shopname&sort_order=date" +
    "_desc";
            // 
            // txtPathSave
            // 
            this.txtPathSave.Location = new System.Drawing.Point(30, 117);
            this.txtPathSave.Name = "txtPathSave";
            this.txtPathSave.Size = new System.Drawing.Size(359, 20);
            this.txtPathSave.TabIndex = 2;
            this.txtPathSave.Text = "D:\\TEST_SAVE_IMAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path save";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(137, 225);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(107, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Start download all";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 270);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(359, 230);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // txtSlDownloadDone
            // 
            this.txtSlDownloadDone.AutoSize = true;
            this.txtSlDownloadDone.Location = new System.Drawing.Point(250, 230);
            this.txtSlDownloadDone.Name = "txtSlDownloadDone";
            this.txtSlDownloadDone.Size = new System.Drawing.Size(100, 13);
            this.txtSlDownloadDone.TabIndex = 6;
            this.txtSlDownloadDone.Text = "Download done: 60";
            // 
            // btnDownload1Page
            // 
            this.btnDownload1Page.Location = new System.Drawing.Point(30, 225);
            this.btnDownload1Page.Name = "btnDownload1Page";
            this.btnDownload1Page.Size = new System.Drawing.Size(101, 23);
            this.btnDownload1Page.TabIndex = 7;
            this.btnDownload1Page.Text = "Download 1 page";
            this.btnDownload1Page.UseVisualStyleBackColor = true;
            this.btnDownload1Page.Click += new System.EventHandler(this.btnDownload1Page_Click);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(30, 167);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(359, 21);
            this.cbbType.TabIndex = 8;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 521);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.btnDownload1Page);
            this.Controls.Add(this.txtSlDownloadDone);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathSave);
            this.Controls.Add(this.txtLinkShop);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLinkShop;
        private System.Windows.Forms.TextBox txtPathSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label txtSlDownloadDone;
        private System.Windows.Forms.Button btnDownload1Page;
        private System.Windows.Forms.ComboBox cbbType;
    }
}

