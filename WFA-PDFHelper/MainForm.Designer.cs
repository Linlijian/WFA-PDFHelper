namespace WFA.PDFHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblPDFHelper = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelClientBody = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnImagetoPDF = new System.Windows.Forms.Button();
            this.btnPDFtoImage = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelClientBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.lblPDFHelper);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 40);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // lblPDFHelper
            // 
            this.lblPDFHelper.AutoSize = true;
            this.lblPDFHelper.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFHelper.ForeColor = System.Drawing.Color.White;
            this.lblPDFHelper.Location = new System.Drawing.Point(12, 9);
            this.lblPDFHelper.Name = "lblPDFHelper";
            this.lblPDFHelper.Size = new System.Drawing.Size(91, 19);
            this.lblPDFHelper.TabIndex = 1;
            this.lblPDFHelper.Text = "PDFHelper";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.multiply_32px;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(865, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // panelClientBody
            // 
            this.panelClientBody.BackColor = System.Drawing.Color.Black;
            this.panelClientBody.Controls.Add(this.btnSetting);
            this.panelClientBody.Controls.Add(this.btnImagetoPDF);
            this.panelClientBody.Controls.Add(this.btnPDFtoImage);
            this.panelClientBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientBody.Location = new System.Drawing.Point(0, 40);
            this.panelClientBody.Name = "panelClientBody";
            this.panelClientBody.Size = new System.Drawing.Size(900, 560);
            this.panelClientBody.TabIndex = 2;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::WFA_PDFHelper.Properties.Resources.settings_64px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(602, 110);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(240, 80);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnImagetoPDF
            // 
            this.btnImagetoPDF.FlatAppearance.BorderSize = 0;
            this.btnImagetoPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagetoPDF.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagetoPDF.ForeColor = System.Drawing.Color.White;
            this.btnImagetoPDF.Image = global::WFA_PDFHelper.Properties.Resources.pdf_64px;
            this.btnImagetoPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImagetoPDF.Location = new System.Drawing.Point(332, 110);
            this.btnImagetoPDF.Name = "btnImagetoPDF";
            this.btnImagetoPDF.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImagetoPDF.Size = new System.Drawing.Size(240, 80);
            this.btnImagetoPDF.TabIndex = 4;
            this.btnImagetoPDF.Text = "Image to PDF";
            this.btnImagetoPDF.UseVisualStyleBackColor = true;
            // 
            // btnPDFtoImage
            // 
            this.btnPDFtoImage.FlatAppearance.BorderSize = 0;
            this.btnPDFtoImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDFtoImage.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFtoImage.ForeColor = System.Drawing.Color.White;
            this.btnPDFtoImage.Image = global::WFA_PDFHelper.Properties.Resources.image_file_64px;
            this.btnPDFtoImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDFtoImage.Location = new System.Drawing.Point(60, 110);
            this.btnPDFtoImage.Name = "btnPDFtoImage";
            this.btnPDFtoImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPDFtoImage.Size = new System.Drawing.Size(240, 80);
            this.btnPDFtoImage.TabIndex = 3;
            this.btnPDFtoImage.Text = "PDF to Image";
            this.btnPDFtoImage.UseVisualStyleBackColor = true;
            this.btnPDFtoImage.Click += new System.EventHandler(this.btnPDFtoImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelClientBody);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelClientBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPDFHelper;
        private System.Windows.Forms.Panel panelClientBody;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnImagetoPDF;
        private System.Windows.Forms.Button btnPDFtoImage;
    }
}