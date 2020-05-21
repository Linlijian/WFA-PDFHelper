namespace WFA.PDFHelper.UserControls
{
    partial class UCClientBody
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnImagetoPDF = new System.Windows.Forms.Button();
            this.btnPDFtoImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::WFA_PDFHelper.Properties.Resources.settings_64px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(600, 100);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(240, 80);
            this.btnSetting.TabIndex = 2;
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
            this.btnImagetoPDF.Location = new System.Drawing.Point(330, 100);
            this.btnImagetoPDF.Name = "btnImagetoPDF";
            this.btnImagetoPDF.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImagetoPDF.Size = new System.Drawing.Size(240, 80);
            this.btnImagetoPDF.TabIndex = 1;
            this.btnImagetoPDF.Text = "Image to PDF";
            this.btnImagetoPDF.UseVisualStyleBackColor = true;
            this.btnImagetoPDF.Click += new System.EventHandler(this.btnImagetoPDF_Click);
            // 
            // btnPDFtoImage
            // 
            this.btnPDFtoImage.FlatAppearance.BorderSize = 0;
            this.btnPDFtoImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDFtoImage.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFtoImage.ForeColor = System.Drawing.Color.White;
            this.btnPDFtoImage.Image = global::WFA_PDFHelper.Properties.Resources.image_file_64px;
            this.btnPDFtoImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDFtoImage.Location = new System.Drawing.Point(58, 100);
            this.btnPDFtoImage.Name = "btnPDFtoImage";
            this.btnPDFtoImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPDFtoImage.Size = new System.Drawing.Size(240, 80);
            this.btnPDFtoImage.TabIndex = 0;
            this.btnPDFtoImage.Text = "PDF to Image";
            this.btnPDFtoImage.UseVisualStyleBackColor = true;
            this.btnPDFtoImage.Click += new System.EventHandler(this.btnPDFtoImage_Click);
            // 
            // UCClientBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnImagetoPDF);
            this.Controls.Add(this.btnPDFtoImage);
            this.Name = "UCClientBody";
            this.Size = new System.Drawing.Size(900, 560);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPDFtoImage;
        private System.Windows.Forms.Button btnImagetoPDF;
        private System.Windows.Forms.Button btnSetting;
    }
}
