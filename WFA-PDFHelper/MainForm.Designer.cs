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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblPDFHelper = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelClientBody = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.btnHome);
            this.panelTop.Controls.Add(this.lblPDFHelper);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 40);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.home_32px;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 33);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblPDFHelper
            // 
            this.lblPDFHelper.AutoSize = true;
            this.lblPDFHelper.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFHelper.ForeColor = System.Drawing.Color.White;
            this.lblPDFHelper.Location = new System.Drawing.Point(42, 10);
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
            this.panelClientBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientBody.Location = new System.Drawing.Point(0, 40);
            this.panelClientBody.Name = "panelClientBody";
            this.panelClientBody.Size = new System.Drawing.Size(900, 560);
            this.panelClientBody.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPDFHelper;
        private System.Windows.Forms.Panel panelClientBody;
        private System.Windows.Forms.Button btnHome;
    }
}