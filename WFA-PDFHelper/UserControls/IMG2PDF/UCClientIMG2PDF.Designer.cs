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
            this.btnConvertInMulFolder = new System.Windows.Forms.Button();
            this.PActiveConvertInFolder = new System.Windows.Forms.Panel();
            this.btnConvertInFolder = new System.Windows.Forms.Button();
            this.PActiveConvert2PDF = new System.Windows.Forms.Panel();
            this.btnConvert2PDF = new System.Windows.Forms.Button();
            this.lblActiveTask = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelClientTask = new System.Windows.Forms.Panel();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelClient.Controls.Add(this.PActiveConvertInMulFolder);
            this.panelClient.Controls.Add(this.btnConvertInMulFolder);
            this.panelClient.Controls.Add(this.PActiveConvertInFolder);
            this.panelClient.Controls.Add(this.btnConvertInFolder);
            this.panelClient.Controls.Add(this.PActiveConvert2PDF);
            this.panelClient.Controls.Add(this.btnConvert2PDF);
            this.panelClient.Controls.Add(this.lblActiveTask);
            this.panelClient.Controls.Add(this.btnHome);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(256, 560);
            this.panelClient.TabIndex = 0;
            // 
            // PActiveConvertInMulFolder
            // 
            this.PActiveConvertInMulFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveConvertInMulFolder.Location = new System.Drawing.Point(0, 241);
            this.PActiveConvertInMulFolder.Name = "PActiveConvertInMulFolder";
            this.PActiveConvertInMulFolder.Size = new System.Drawing.Size(10, 35);
            this.PActiveConvertInMulFolder.TabIndex = 14;
            // 
            // btnConvertInMulFolder
            // 
            this.btnConvertInMulFolder.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.home_32px;
            this.btnConvertInMulFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvertInMulFolder.FlatAppearance.BorderSize = 0;
            this.btnConvertInMulFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertInMulFolder.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertInMulFolder.ForeColor = System.Drawing.Color.White;
            this.btnConvertInMulFolder.Location = new System.Drawing.Point(12, 243);
            this.btnConvertInMulFolder.Name = "btnConvertInMulFolder";
            this.btnConvertInMulFolder.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnConvertInMulFolder.Size = new System.Drawing.Size(244, 35);
            this.btnConvertInMulFolder.TabIndex = 13;
            this.btnConvertInMulFolder.Text = "Convert in Multi Folder";
            this.btnConvertInMulFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertInMulFolder.UseVisualStyleBackColor = true;
            this.btnConvertInMulFolder.Click += new System.EventHandler(this.btnConvertInMulFolder_Click);
            // 
            // PActiveConvertInFolder
            // 
            this.PActiveConvertInFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveConvertInFolder.Location = new System.Drawing.Point(0, 200);
            this.PActiveConvertInFolder.Name = "PActiveConvertInFolder";
            this.PActiveConvertInFolder.Size = new System.Drawing.Size(10, 35);
            this.PActiveConvertInFolder.TabIndex = 12;
            // 
            // btnConvertInFolder
            // 
            this.btnConvertInFolder.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.home_32px;
            this.btnConvertInFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvertInFolder.FlatAppearance.BorderSize = 0;
            this.btnConvertInFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertInFolder.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertInFolder.ForeColor = System.Drawing.Color.White;
            this.btnConvertInFolder.Location = new System.Drawing.Point(12, 202);
            this.btnConvertInFolder.Name = "btnConvertInFolder";
            this.btnConvertInFolder.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnConvertInFolder.Size = new System.Drawing.Size(244, 35);
            this.btnConvertInFolder.TabIndex = 11;
            this.btnConvertInFolder.Text = "Convert in Folder";
            this.btnConvertInFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertInFolder.UseVisualStyleBackColor = true;
            this.btnConvertInFolder.Click += new System.EventHandler(this.btnConvertInFolder_Click);
            // 
            // PActiveConvert2PDF
            // 
            this.PActiveConvert2PDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveConvert2PDF.Location = new System.Drawing.Point(0, 159);
            this.PActiveConvert2PDF.Name = "PActiveConvert2PDF";
            this.PActiveConvert2PDF.Size = new System.Drawing.Size(10, 35);
            this.PActiveConvert2PDF.TabIndex = 10;
            // 
            // btnConvert2PDF
            // 
            this.btnConvert2PDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnConvert2PDF.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.home_32px;
            this.btnConvert2PDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvert2PDF.FlatAppearance.BorderSize = 0;
            this.btnConvert2PDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert2PDF.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert2PDF.ForeColor = System.Drawing.Color.White;
            this.btnConvert2PDF.Location = new System.Drawing.Point(12, 161);
            this.btnConvert2PDF.Name = "btnConvert2PDF";
            this.btnConvert2PDF.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnConvert2PDF.Size = new System.Drawing.Size(244, 35);
            this.btnConvert2PDF.TabIndex = 9;
            this.btnConvert2PDF.Text = "Convert to PDF";
            this.btnConvert2PDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert2PDF.UseVisualStyleBackColor = false;
            this.btnConvert2PDF.Click += new System.EventHandler(this.btnConvert2PDF_Click);
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
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.home_32px;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(244, 35);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelClientTask
            // 
            this.panelClientTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientTask.Location = new System.Drawing.Point(256, 0);
            this.panelClientTask.Name = "panelClientTask";
            this.panelClientTask.Size = new System.Drawing.Size(644, 560);
            this.panelClientTask.TabIndex = 1;
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
        private System.Windows.Forms.Label lblActiveTask;
        private System.Windows.Forms.Panel panelClientTask;
        private System.Windows.Forms.Panel PActiveConvertInMulFolder;
        private System.Windows.Forms.Button btnConvertInMulFolder;
        private System.Windows.Forms.Panel PActiveConvertInFolder;
        private System.Windows.Forms.Button btnConvertInFolder;
        private System.Windows.Forms.Panel PActiveConvert2PDF;
        private System.Windows.Forms.Button btnConvert2PDF;
    }
}
