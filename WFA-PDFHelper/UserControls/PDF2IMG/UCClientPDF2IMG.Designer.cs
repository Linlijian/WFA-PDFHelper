namespace WFA.PDFHelper.UserControls
{
    partial class UCClientPDF2IMG
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
            this.panelClientTask = new System.Windows.Forms.Panel();
            this.lblActiveTask = new System.Windows.Forms.Label();
            this.btnConvert2Image = new System.Windows.Forms.Button();
            this.PActiveConvert2Image = new System.Windows.Forms.Panel();
            this.btnConveretInFolder = new System.Windows.Forms.Button();
            this.PActiveConvertInFolder = new System.Windows.Forms.Panel();
            this.btnConvertInMulFolder = new System.Windows.Forms.Button();
            this.PActiveConvertInMulFolder = new System.Windows.Forms.Panel();
            this.panelClient = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClientTask
            // 
            this.panelClientTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientTask.Location = new System.Drawing.Point(256, 0);
            this.panelClientTask.Name = "panelClientTask";
            this.panelClientTask.Size = new System.Drawing.Size(644, 560);
            this.panelClientTask.TabIndex = 1;
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
            this.lblActiveTask.Text = "PDF to Image";
            // 
            // btnConvert2Image
            // 
            this.btnConvert2Image.FlatAppearance.BorderSize = 0;
            this.btnConvert2Image.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConvert2Image.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConvert2Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert2Image.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert2Image.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvert2Image.Image = global::WFA_PDFHelper.Properties.Resources.home_32px;
            this.btnConvert2Image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert2Image.Location = new System.Drawing.Point(12, 157);
            this.btnConvert2Image.Name = "btnConvert2Image";
            this.btnConvert2Image.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnConvert2Image.Size = new System.Drawing.Size(244, 35);
            this.btnConvert2Image.TabIndex = 0;
            this.btnConvert2Image.Text = "          Convert to Image";
            this.btnConvert2Image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert2Image.UseVisualStyleBackColor = true;
            this.btnConvert2Image.Click += new System.EventHandler(this.btnConvert2Image_Click);
            // 
            // PActiveConvert2Image
            // 
            this.PActiveConvert2Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveConvert2Image.Location = new System.Drawing.Point(0, 157);
            this.PActiveConvert2Image.Name = "PActiveConvert2Image";
            this.PActiveConvert2Image.Size = new System.Drawing.Size(6, 35);
            this.PActiveConvert2Image.TabIndex = 15;
            // 
            // btnConveretInFolder
            // 
            this.btnConveretInFolder.FlatAppearance.BorderSize = 0;
            this.btnConveretInFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConveretInFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConveretInFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConveretInFolder.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConveretInFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConveretInFolder.Image = global::WFA_PDFHelper.Properties.Resources.home_32px;
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
            // PActiveConvertInFolder
            // 
            this.PActiveConvertInFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveConvertInFolder.Location = new System.Drawing.Point(0, 198);
            this.PActiveConvertInFolder.Name = "PActiveConvertInFolder";
            this.PActiveConvertInFolder.Size = new System.Drawing.Size(6, 35);
            this.PActiveConvertInFolder.TabIndex = 17;
            // 
            // btnConvertInMulFolder
            // 
            this.btnConvertInMulFolder.FlatAppearance.BorderSize = 0;
            this.btnConvertInMulFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConvertInMulFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConvertInMulFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertInMulFolder.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertInMulFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvertInMulFolder.Image = global::WFA_PDFHelper.Properties.Resources.home_32px;
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
            // PActiveConvertInMulFolder
            // 
            this.PActiveConvertInMulFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveConvertInMulFolder.Location = new System.Drawing.Point(0, 239);
            this.PActiveConvertInMulFolder.Name = "PActiveConvertInMulFolder";
            this.PActiveConvertInMulFolder.Size = new System.Drawing.Size(6, 35);
            this.PActiveConvertInMulFolder.TabIndex = 19;
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
            this.panelClient.Controls.Add(this.btnConvert2Image);
            this.panelClient.Controls.Add(this.lblActiveTask);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(256, 560);
            this.panelClient.TabIndex = 0;
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
            // UCClientPDF2IMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelClientTask);
            this.Controls.Add(this.panelClient);
            this.Name = "UCClientPDF2IMG";
            this.Size = new System.Drawing.Size(900, 560);
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelClientTask;
        private System.Windows.Forms.Label lblActiveTask;
        private System.Windows.Forms.Button btnConvert2Image;
        private System.Windows.Forms.Panel PActiveConvert2Image;
        private System.Windows.Forms.Button btnConveretInFolder;
        private System.Windows.Forms.Panel PActiveConvertInFolder;
        private System.Windows.Forms.Button btnConvertInMulFolder;
        private System.Windows.Forms.Panel PActiveConvertInMulFolder;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Button btnHome;
    }
}
