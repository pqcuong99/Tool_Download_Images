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
            this.btnChoose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameSheet = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPathZip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link shop:";
            // 
            // txtLinkShop
            // 
            this.txtLinkShop.Location = new System.Drawing.Point(21, 47);
            this.txtLinkShop.Name = "txtLinkShop";
            this.txtLinkShop.Size = new System.Drawing.Size(376, 20);
            this.txtLinkShop.TabIndex = 1;
            this.txtLinkShop.Text = "https://www.etsy.com/shop/PawtraitDesignArt?ref=l2-about-shopname&sort_order=date" +
    "_desc";
            // 
            // txtPathSave
            // 
            this.txtPathSave.Location = new System.Drawing.Point(21, 99);
            this.txtPathSave.Name = "txtPathSave";
            this.txtPathSave.Size = new System.Drawing.Size(295, 20);
            this.txtPathSave.TabIndex = 2;
            this.txtPathSave.Text = "D:\\TEST_SAVE_IMAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path save";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(219, 302);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(178, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Start download all";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(437, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(333, 288);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtSlDownloadDone
            // 
            this.txtSlDownloadDone.AutoSize = true;
            this.txtSlDownloadDone.Location = new System.Drawing.Point(616, 21);
            this.txtSlDownloadDone.Name = "txtSlDownloadDone";
            this.txtSlDownloadDone.Size = new System.Drawing.Size(100, 13);
            this.txtSlDownloadDone.TabIndex = 6;
            this.txtSlDownloadDone.Text = "Download done: 60";
            // 
            // btnDownload1Page
            // 
            this.btnDownload1Page.Location = new System.Drawing.Point(21, 302);
            this.btnDownload1Page.Name = "btnDownload1Page";
            this.btnDownload1Page.Size = new System.Drawing.Size(166, 23);
            this.btnDownload1Page.TabIndex = 7;
            this.btnDownload1Page.Text = "Download 1 page";
            this.btnDownload1Page.UseVisualStyleBackColor = true;
            this.btnDownload1Page.Click += new System.EventHandler(this.btnDownload1Page_Click);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(21, 257);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(376, 21);
            this.cbbType.TabIndex = 8;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(322, 99);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 9;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name sheet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Product category";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // txtNameSheet
            // 
            this.txtNameSheet.Location = new System.Drawing.Point(21, 149);
            this.txtNameSheet.Name = "txtNameSheet";
            this.txtNameSheet.Size = new System.Drawing.Size(117, 20);
            this.txtNameSheet.TabIndex = 13;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(171, 149);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(121, 20);
            this.txtProduct.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(322, 149);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 20);
            this.txtPrice.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Path Zip";
            // 
            // txtPathZip
            // 
            this.txtPathZip.Location = new System.Drawing.Point(21, 198);
            this.txtPathZip.Name = "txtPathZip";
            this.txtPathZip.Size = new System.Drawing.Size(376, 20);
            this.txtPathZip.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 345);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPathZip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtNameSheet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChoose);
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
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameSheet;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPathZip;
        private System.Windows.Forms.Label label7;
    }
}

