namespace WFA.PDFHelper.UserControls
{
    partial class UCSETTINGF1S01
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
            this.lblTitle_input = new System.Windows.Forms.Label();
            this.OFDAddImage = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.listboxCustomSelect = new System.Windows.Forms.ListBox();
            this.txtCustomSelect = new System.Windows.Forms.TextBox();
            this.btnAddCustomSelect = new System.Windows.Forms.Button();
            this.btnDeleteCustomSelect = new System.Windows.Forms.Button();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.lblSwitchDupfile = new System.Windows.Forms.Label();
            this.btnDupfile = new System.Windows.Forms.Button();
            this.lblDupfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToppic
            // 
            this.lblToppic.AutoSize = true;
            this.lblToppic.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppic.ForeColor = System.Drawing.Color.White;
            this.lblToppic.Location = new System.Drawing.Point(22, 17);
            this.lblToppic.Name = "lblToppic";
            this.lblToppic.Size = new System.Drawing.Size(117, 25);
            this.lblToppic.TabIndex = 0;
            this.lblToppic.Text = "Case Select";
            // 
            // lblTitle_input
            // 
            this.lblTitle_input.AutoSize = true;
            this.lblTitle_input.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_input.ForeColor = System.Drawing.Color.White;
            this.lblTitle_input.Location = new System.Drawing.Point(23, 56);
            this.lblTitle_input.Name = "lblTitle_input";
            this.lblTitle_input.Size = new System.Drawing.Size(366, 19);
            this.lblTitle_input.TabIndex = 1;
            this.lblTitle_input.Text = "Case select image name for create and group folder";
            // 
            // OFDAddImage
            // 
            this.OFDAddImage.FileName = "OFDAddImage";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(27, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listboxCustomSelect
            // 
            this.listboxCustomSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.listboxCustomSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxCustomSelect.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCustomSelect.ForeColor = System.Drawing.Color.White;
            this.listboxCustomSelect.FormattingEnabled = true;
            this.listboxCustomSelect.ItemHeight = 19;
            this.listboxCustomSelect.Location = new System.Drawing.Point(27, 116);
            this.listboxCustomSelect.Name = "listboxCustomSelect";
            this.listboxCustomSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxCustomSelect.Size = new System.Drawing.Size(284, 152);
            this.listboxCustomSelect.TabIndex = 12;
            // 
            // txtCustomSelect
            // 
            this.txtCustomSelect.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCustomSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomSelect.Font = new System.Drawing.Font("Itim", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomSelect.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCustomSelect.Location = new System.Drawing.Point(27, 78);
            this.txtCustomSelect.Name = "txtCustomSelect";
            this.txtCustomSelect.Size = new System.Drawing.Size(284, 33);
            this.txtCustomSelect.TabIndex = 14;
            this.txtCustomSelect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomSelect_KeyUp);
            // 
            // btnAddCustomSelect
            // 
            this.btnAddCustomSelect.BackColor = System.Drawing.Color.Black;
            this.btnAddCustomSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnAddCustomSelect.FlatAppearance.BorderSize = 2;
            this.btnAddCustomSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAddCustomSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAddCustomSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomSelect.ForeColor = System.Drawing.Color.Black;
            this.btnAddCustomSelect.Image = global::WFA_PDFHelper.Properties.Resources.plus_math_32px;
            this.btnAddCustomSelect.Location = new System.Drawing.Point(317, 79);
            this.btnAddCustomSelect.Name = "btnAddCustomSelect";
            this.btnAddCustomSelect.Size = new System.Drawing.Size(33, 32);
            this.btnAddCustomSelect.TabIndex = 14;
            this.btnAddCustomSelect.UseVisualStyleBackColor = false;
            this.btnAddCustomSelect.Click += new System.EventHandler(this.btnAddCustomSelect_Click);
            // 
            // btnDeleteCustomSelect
            // 
            this.btnDeleteCustomSelect.BackColor = System.Drawing.Color.Black;
            this.btnDeleteCustomSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDeleteCustomSelect.FlatAppearance.BorderSize = 2;
            this.btnDeleteCustomSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnDeleteCustomSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDeleteCustomSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomSelect.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCustomSelect.Image = global::WFA_PDFHelper.Properties.Resources.subtract_32px;
            this.btnDeleteCustomSelect.Location = new System.Drawing.Point(356, 78);
            this.btnDeleteCustomSelect.Name = "btnDeleteCustomSelect";
            this.btnDeleteCustomSelect.Size = new System.Drawing.Size(33, 32);
            this.btnDeleteCustomSelect.TabIndex = 15;
            this.btnDeleteCustomSelect.UseVisualStyleBackColor = false;
            this.btnDeleteCustomSelect.Click += new System.EventHandler(this.btnDeleteCustomSelect_Click);
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.lblSaveStatus.Location = new System.Drawing.Point(143, 518);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(0, 19);
            this.lblSaveStatus.TabIndex = 16;
            // 
            // lblSwitchDupfile
            // 
            this.lblSwitchDupfile.AutoSize = true;
            this.lblSwitchDupfile.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitchDupfile.ForeColor = System.Drawing.Color.White;
            this.lblSwitchDupfile.Location = new System.Drawing.Point(68, 306);
            this.lblSwitchDupfile.Name = "lblSwitchDupfile";
            this.lblSwitchDupfile.Size = new System.Drawing.Size(33, 19);
            this.lblSwitchDupfile.TabIndex = 19;
            this.lblSwitchDupfile.Text = "Off";
            // 
            // btnDupfile
            // 
            this.btnDupfile.BackColor = System.Drawing.Color.Black;
            this.btnDupfile.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.toggle_off_32px;
            this.btnDupfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDupfile.FlatAppearance.BorderSize = 0;
            this.btnDupfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDupfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDupfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDupfile.ForeColor = System.Drawing.Color.Black;
            this.btnDupfile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDupfile.Location = new System.Drawing.Point(27, 302);
            this.btnDupfile.Name = "btnDupfile";
            this.btnDupfile.Size = new System.Drawing.Size(35, 29);
            this.btnDupfile.TabIndex = 18;
            this.btnDupfile.UseVisualStyleBackColor = false;
            this.btnDupfile.Click += new System.EventHandler(this.btnDupfile_Click);
            // 
            // lblDupfile
            // 
            this.lblDupfile.AutoSize = true;
            this.lblDupfile.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDupfile.ForeColor = System.Drawing.Color.White;
            this.lblDupfile.Location = new System.Drawing.Point(23, 280);
            this.lblDupfile.Name = "lblDupfile";
            this.lblDupfile.Size = new System.Drawing.Size(243, 19);
            this.lblDupfile.TabIndex = 17;
            this.lblDupfile.Text = "Replace the file in the destination";
            // 
            // UCSETTINGF1S01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblSwitchDupfile);
            this.Controls.Add(this.btnDupfile);
            this.Controls.Add(this.lblDupfile);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.btnDeleteCustomSelect);
            this.Controls.Add(this.btnAddCustomSelect);
            this.Controls.Add(this.txtCustomSelect);
            this.Controls.Add(this.listboxCustomSelect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle_input);
            this.Controls.Add(this.lblToppic);
            this.Name = "UCSETTINGF1S01";
            this.Size = new System.Drawing.Size(644, 560);
            this.Load += new System.EventHandler(this.UCSETTINGF1S01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToppic;
        private System.Windows.Forms.Label lblTitle_input;
        private System.Windows.Forms.OpenFileDialog OFDAddImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listboxCustomSelect;
        private System.Windows.Forms.TextBox txtCustomSelect;
        private System.Windows.Forms.Button btnAddCustomSelect;
        private System.Windows.Forms.Button btnDeleteCustomSelect;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Label lblSwitchDupfile;
        private System.Windows.Forms.Button btnDupfile;
        private System.Windows.Forms.Label lblDupfile;
    }
}
