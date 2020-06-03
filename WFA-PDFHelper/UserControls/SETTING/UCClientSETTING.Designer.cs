﻿namespace WFA.PDFHelper.UserControls
{
    partial class UCClientSETTING
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
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.PActiveUpdate = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.PActiveAbout = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.PSubGeneral = new System.Windows.Forms.Panel();
            this.btnCaseSelect = new System.Windows.Forms.Button();
            this.PActiveCaseSelect = new System.Windows.Forms.Panel();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.PActiveGeneral = new System.Windows.Forms.Panel();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblActiveTask = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelClientTask = new System.Windows.Forms.Panel();
            this.panelClient.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.PSubGeneral.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelClient.Controls.Add(this.panelUpdate);
            this.panelClient.Controls.Add(this.panelAbout);
            this.panelClient.Controls.Add(this.PSubGeneral);
            this.panelClient.Controls.Add(this.panelGeneral);
            this.panelClient.Controls.Add(this.panelTitle);
            this.panelClient.Controls.Add(this.panelHome);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(256, 560);
            this.panelClient.TabIndex = 1;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.PActiveUpdate);
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdate.Location = new System.Drawing.Point(0, 272);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(256, 38);
            this.panelUpdate.TabIndex = 25;
            // 
            // PActiveUpdate
            // 
            this.PActiveUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveUpdate.Location = new System.Drawing.Point(0, 0);
            this.PActiveUpdate.Name = "PActiveUpdate";
            this.PActiveUpdate.Size = new System.Drawing.Size(6, 35);
            this.PActiveUpdate.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Image = global::WFA_PDFHelper.Properties.Resources.update_32px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(9, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(244, 35);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "          Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.PActiveAbout);
            this.panelAbout.Controls.Add(this.btnAbout);
            this.panelAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAbout.Location = new System.Drawing.Point(0, 234);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(256, 38);
            this.panelAbout.TabIndex = 24;
            // 
            // PActiveAbout
            // 
            this.PActiveAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveAbout.Location = new System.Drawing.Point(0, 0);
            this.PActiveAbout.Name = "PActiveAbout";
            this.PActiveAbout.Size = new System.Drawing.Size(6, 35);
            this.PActiveAbout.TabIndex = 15;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbout.Image = global::WFA_PDFHelper.Properties.Resources.info_32px;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(9, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAbout.Size = new System.Drawing.Size(244, 35);
            this.btnAbout.TabIndex = 16;
            this.btnAbout.Text = "          About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // PSubGeneral
            // 
            this.PSubGeneral.Controls.Add(this.btnCaseSelect);
            this.PSubGeneral.Controls.Add(this.PActiveCaseSelect);
            this.PSubGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSubGeneral.Location = new System.Drawing.Point(0, 196);
            this.PSubGeneral.Name = "PSubGeneral";
            this.PSubGeneral.Size = new System.Drawing.Size(256, 38);
            this.PSubGeneral.TabIndex = 25;
            // 
            // btnCaseSelect
            // 
            this.btnCaseSelect.FlatAppearance.BorderSize = 0;
            this.btnCaseSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnCaseSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCaseSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaseSelect.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaseSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaseSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaseSelect.Location = new System.Drawing.Point(75, 0);
            this.btnCaseSelect.Name = "btnCaseSelect";
            this.btnCaseSelect.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnCaseSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCaseSelect.Size = new System.Drawing.Size(178, 35);
            this.btnCaseSelect.TabIndex = 21;
            this.btnCaseSelect.Text = "Case Select";
            this.btnCaseSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaseSelect.UseVisualStyleBackColor = true;
            // 
            // PActiveCaseSelect
            // 
            this.PActiveCaseSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveCaseSelect.Location = new System.Drawing.Point(63, 0);
            this.PActiveCaseSelect.Name = "PActiveCaseSelect";
            this.PActiveCaseSelect.Size = new System.Drawing.Size(6, 35);
            this.PActiveCaseSelect.TabIndex = 22;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.PActiveGeneral);
            this.panelGeneral.Controls.Add(this.btnGeneral);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 158);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(256, 38);
            this.panelGeneral.TabIndex = 22;
            // 
            // PActiveGeneral
            // 
            this.PActiveGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveGeneral.Location = new System.Drawing.Point(0, 0);
            this.PActiveGeneral.Name = "PActiveGeneral";
            this.PActiveGeneral.Size = new System.Drawing.Size(6, 35);
            this.PActiveGeneral.TabIndex = 15;
            // 
            // btnGeneral
            // 
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGeneral.Image = global::WFA_PDFHelper.Properties.Resources.folder_settings_32px;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.Location = new System.Drawing.Point(9, 0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnGeneral.Size = new System.Drawing.Size(244, 35);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "          General";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblActiveTask);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 38);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(256, 120);
            this.panelTitle.TabIndex = 21;
            // 
            // lblActiveTask
            // 
            this.lblActiveTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActiveTask.AutoSize = true;
            this.lblActiveTask.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveTask.ForeColor = System.Drawing.Color.White;
            this.lblActiveTask.Location = new System.Drawing.Point(23, 38);
            this.lblActiveTask.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblActiveTask.Name = "lblActiveTask";
            this.lblActiveTask.Size = new System.Drawing.Size(58, 19);
            this.lblActiveTask.TabIndex = 3;
            this.lblActiveTask.Text = "Setting";
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(256, 38);
            this.panelHome.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(151)))), ((int)(((byte)(174)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Image = global::WFA_PDFHelper.Properties.Resources.home_32px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(256, 35);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "          Home";
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
            this.panelClientTask.TabIndex = 2;            
            // 
            // UCClientSETTING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelClientTask);
            this.Controls.Add(this.panelClient);
            this.Name = "UCClientSETTING";
            this.Size = new System.Drawing.Size(900, 560);
            this.panelClient.ResumeLayout(false);
            this.panelUpdate.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.PSubGeneral.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel PActiveGeneral;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Label lblActiveTask;
        private System.Windows.Forms.Panel panelClientTask;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Panel PActiveUpdate;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Panel PActiveAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel PSubGeneral;
        private System.Windows.Forms.Button btnCaseSelect;
        private System.Windows.Forms.Panel PActiveCaseSelect;
    }
}
