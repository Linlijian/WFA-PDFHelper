namespace WFA.PDFHelper.UserControls
{
    partial class UCClientIMG2PDF
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
            this.panelClient = new System.Windows.Forms.Panel();
            this.PActiveConvertInMulFolder = new System.Windows.Forms.Panel();
            this.PActiveConvertInFolder = new System.Windows.Forms.Panel();
            this.PActiveConvert2Image = new System.Windows.Forms.Panel();
            this.lblActiveTask = new System.Windows.Forms.Label();
            this.panelClientTask = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConvertInMulFolder = new System.Windows.Forms.Button();
            this.btnConveretInFolder = new System.Windows.Forms.Button();
            this.btnConvert2PDF = new System.Windows.Forms.Button();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelClient.Controls.Add(this.btnHome);
            this.panelClient.Controls.Add(this.PActiveConvertInMulFolder);
            this.panelClient.Controls.Add(this.btnConvertInMulFolder);
            this.panelClient.Controls.Add(this.PActiveConvertInFolder);
            this.panelClient.Controls.Add(this.btnConveretInFolder);
            this.panelClient.Controls.Add(this.PActiveConvert2Image);
            this.panelClient.Controls.Add(this.btnConvert2PDF);
            this.panelClient.Controls.Add(this.lblActiveTask);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(256, 560);
            this.panelClient.TabIndex = 1;
            // 
            // PActiveConvertInMulFolder
            // 
            this.PActiveConvertInMulFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveConvertInMulFolder.Location = new System.Drawing.Point(0, 239);
            this.PActiveConvertInMulFolder.Name = "PActiveConvertInMulFolder";
            this.PActiveConvertInMulFolder.Size = new System.Drawing.Size(6, 35);
            this.PActiveConvertInMulFolder.TabIndex = 19;
            // 
            // PActiveConvertInFolder
            // 
            this.PActiveConvertInFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveConvertInFolder.Location = new System.Drawing.Point(0, 198);
            this.PActiveConvertInFolder.Name = "PActiveConvertInFolder";
            this.PActiveConvertInFolder.Size = new System.Drawing.Size(6, 35);
            this.PActiveConvertInFolder.TabIndex = 17;
            // 
            // PActiveConvert2Image
            // 
            this.PActiveConvert2Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveConvert2Image.Location = new System.Drawing.Point(0, 157);
            this.PActiveConvert2Image.Name = "PActiveConvert2Image";
            this.PActiveConvert2Image.Size = new System.Drawing.Size(6, 35);
            this.PActiveConvert2Image.TabIndex = 15;
            // 
            // lblActiveTask
            // 
            this.lblActiveTask.AutoSize = true;
            this.lblActiveTask.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveTask.ForeColor = System.Drawing.Color.White;
            this.lblActiveTask.Location = new System.Drawing.Point(8, 76);
            this.lblActiveTask.Name = "lblActiveTask";
            this.lblActiveTask.Size = new System.Drawing.Size(101, 19);
            this.lblActiveTask.TabIndex = 3;
            this.lblActiveTask.Text = "Image to PDF";
            // 
            // panelClientTask
            // 
            this.panelClientTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientTask.Location = new System.Drawing.Point(256, 0);
            this.panelClientTask.Name = "panelClientTask";
            this.panelClientTask.Size = new System.Drawing.Size(644, 560);
            this.panelClientTask.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(151)))), ((int)(((byte)(174)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Image = global::WFA_PDFHelper.Properties.Resources.home_32px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(244, 35);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConvertInMulFolder
            // 
            this.btnConvertInMulFolder.FlatAppearance.BorderSize = 0;
            this.btnConvertInMulFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConvertInMulFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConvertInMulFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertInMulFolder.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertInMulFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvertInMulFolder.Image = global::WFA_PDFHelper.Properties.Resources.folder_tree_32px;
            this.btnConvertInMulFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertInMulFolder.Location = new System.Drawing.Point(12, 239);
            this.btnConvertInMulFolder.Name = "btnConvertInMulFolder";
            this.btnConvertInMulFolder.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnConvertInMulFolder.Size = new System.Drawing.Size(244, 35);
            this.btnConvertInMulFolder.TabIndex = 18;
            this.btnConvertInMulFolder.Text = "          Convert in Multi";
            this.btnConvertInMulFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertInMulFolder.UseVisualStyleBackColor = true;
            this.btnConvertInMulFolder.Click += new System.EventHandler(this.btnConvertInMulFolder_Click);
            // 
            // btnConveretInFolder
            // 
            this.btnConveretInFolder.FlatAppearance.BorderSize = 0;
            this.btnConveretInFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConveretInFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConveretInFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConveretInFolder.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConveretInFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConveretInFolder.Image = global::WFA_PDFHelper.Properties.Resources.pdf_window_32px;
            this.btnConveretInFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConveretInFolder.Location = new System.Drawing.Point(12, 198);
            this.btnConveretInFolder.Name = "btnConveretInFolder";
            this.btnConveretInFolder.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnConveretInFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConveretInFolder.Size = new System.Drawing.Size(244, 35);
            this.btnConveretInFolder.TabIndex = 16;
            this.btnConveretInFolder.Text = "          Convert in Folder";
            this.btnConveretInFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConveretInFolder.UseVisualStyleBackColor = true;
            this.btnConveretInFolder.Click += new System.EventHandler(this.btnConvertInFolder_Click);
            // 
            // btnConvert2PDF
            // 
            this.btnConvert2PDF.FlatAppearance.BorderSize = 0;
            this.btnConvert2PDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConvert2PDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConvert2PDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert2PDF.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert2PDF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvert2PDF.Image = global::WFA_PDFHelper.Properties.Resources.export_pdf_32px;
            this.btnConvert2PDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert2PDF.Location = new System.Drawing.Point(12, 157);
            this.btnConvert2PDF.Name = "btnConvert2PDF";
            this.btnConvert2PDF.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnConvert2PDF.Size = new System.Drawing.Size(244, 35);
            this.btnConvert2PDF.TabIndex = 0;
            this.btnConvert2PDF.Text = "          Convert to PDF";
            this.btnConvert2PDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert2PDF.UseVisualStyleBackColor = true;
            this.btnConvert2PDF.Click += new System.EventHandler(this.btnConvert2PDF_Click);
            // 
            // UCClientIMG2PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelClientTask);
            this.Controls.Add(this.panelClient);
            this.Name = "UCClientIMG2PDF";
            this.Size = new System.Drawing.Size(900, 560);
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel PActiveConvertInMulFolder;
        private System.Windows.Forms.Button btnConvertInMulFolder;
        private System.Windows.Forms.Panel PActiveConvertInFolder;
        private System.Windows.Forms.Button btnConveretInFolder;
        private System.Windows.Forms.Panel PActiveConvert2Image;
        private System.Windows.Forms.Button btnConvert2PDF;
        private System.Windows.Forms.Label lblActiveTask;
        private System.Windows.Forms.Panel panelClientTask;
    }
}
