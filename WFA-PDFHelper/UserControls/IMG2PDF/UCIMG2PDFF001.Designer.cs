namespace WFA.PDFHelper.UserControls
{
    partial class UCIMG2PDFF001
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
            this.lblToppic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OFDAddImage = new System.Windows.Forms.OpenFileDialog();
            this.listboxImage = new System.Windows.Forms.ListBox();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.ckbSort = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToppic
            // 
            this.lblToppic.AutoSize = true;
            this.lblToppic.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppic.ForeColor = System.Drawing.Color.White;
            this.lblToppic.Location = new System.Drawing.Point(22, 17);
            this.lblToppic.Name = "lblToppic";
            this.lblToppic.Size = new System.Drawing.Size(135, 25);
            this.lblToppic.TabIndex = 0;
            this.lblToppic.Text = "Image to PDF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Image file";
            // 
            // OFDAddImage
            // 
            this.OFDAddImage.FileName = "OFDAddImage";
            // 
            // listboxImage
            // 
            this.listboxImage.BackColor = System.Drawing.Color.DimGray;
            this.listboxImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxImage.Font = new System.Drawing.Font("Itim", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxImage.ForeColor = System.Drawing.Color.White;
            this.listboxImage.FormattingEnabled = true;
            this.listboxImage.ItemHeight = 15;
            this.listboxImage.Location = new System.Drawing.Point(27, 115);
            this.listboxImage.Name = "listboxImage";
            this.listboxImage.Size = new System.Drawing.Size(417, 165);
            this.listboxImage.TabIndex = 3;
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.BackColor = System.Drawing.Color.Black;
            this.btnDeleteImage.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.subtract_32px;
            this.btnDeleteImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDeleteImage.FlatAppearance.BorderSize = 2;
            this.btnDeleteImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnDeleteImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImage.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteImage.Location = new System.Drawing.Point(69, 73);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(36, 36);
            this.btnDeleteImage.TabIndex = 4;
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Black;
            this.btnAddImage.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.plus_math_32px;
            this.btnAddImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnAddImage.FlatAppearance.BorderSize = 2;
            this.btnAddImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAddImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.ForeColor = System.Drawing.Color.Black;
            this.btnAddImage.Location = new System.Drawing.Point(27, 73);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(36, 36);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // ckbSort
            // 
            this.ckbSort.AutoSize = true;
            this.ckbSort.Font = new System.Drawing.Font("Itim", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSort.ForeColor = System.Drawing.Color.White;
            this.ckbSort.Location = new System.Drawing.Point(27, 318);
            this.ckbSort.Name = "ckbSort";
            this.ckbSort.Size = new System.Drawing.Size(254, 19);
            this.ckbSort.TabIndex = 5;
            this.ckbSort.Text = "Sorting file name  before converet to pdf.";
            this.ckbSort.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Option";
            // 
            // UCIMG2PDFF001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbSort);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.listboxImage);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToppic);
            this.Name = "UCIMG2PDFF001";
            this.Size = new System.Drawing.Size(644, 560);
            this.Load += new System.EventHandler(this.UCIMG2PDFF001_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToppic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.OpenFileDialog OFDAddImage;
        private System.Windows.Forms.ListBox listboxImage;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.CheckBox ckbSort;
        private System.Windows.Forms.Label label2;
    }
}
