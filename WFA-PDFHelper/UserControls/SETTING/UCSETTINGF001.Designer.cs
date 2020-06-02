namespace WFA.PDFHelper.UserControls
{
    partial class UCSETTINGF001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSETTINGF001));
            this.OFDAddImage = new System.Windows.Forms.OpenFileDialog();
            this.outerPanel = new System.Windows.Forms.Panel();
            this.lblShowInput = new System.Windows.Forms.Label();
            this.innerPanel = new System.Windows.Forms.Panel();
            this.customScrollbar1 = new CustomControls.CustomScrollbar();
            this.SuspendLayout();
            // 
            // OFDAddImage
            // 
            this.OFDAddImage.FileName = "OFDAddImage";
            // 
            // outerPanel
            // 
            this.outerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outerPanel.Location = new System.Drawing.Point(22, 19);
            this.outerPanel.Name = "outerPanel";
            this.outerPanel.Size = new System.Drawing.Size(588, 510);
            this.outerPanel.TabIndex = 0;
            // 
            // lblShowInput
            // 
            this.lblShowInput.AutoSize = true;
            this.lblShowInput.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowInput.ForeColor = System.Drawing.Color.White;
            this.lblShowInput.Location = new System.Drawing.Point(69, 95);
            this.lblShowInput.Name = "lblShowInput";
            this.lblShowInput.Size = new System.Drawing.Size(0, 19);
            this.lblShowInput.TabIndex = 3;
            // 
            // innerPanel
            // 
            this.innerPanel.AutoScroll = true;
            this.innerPanel.Location = new System.Drawing.Point(22, 19);
            this.innerPanel.Name = "innerPanel";
            this.innerPanel.Size = new System.Drawing.Size(588, 510);
            this.innerPanel.TabIndex = 0;
            this.innerPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.item_scroll);
            // 
            // customScrollbar1
            // 
            this.customScrollbar1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
            this.customScrollbar1.DownArrowImage = null;
            this.customScrollbar1.LargeChange = 10;
            this.customScrollbar1.Location = new System.Drawing.Point(616, 19);
            this.customScrollbar1.Maximum = 100;
            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.MinimumSize = new System.Drawing.Size(0, 56);
            this.customScrollbar1.Name = "customScrollbar1";
            this.customScrollbar1.Size = new System.Drawing.Size(25, 510);
            this.customScrollbar1.SmallChange = 1;
            this.customScrollbar1.TabIndex = 0;
            this.customScrollbar1.ThumbBottomImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbBottomImage")));
            this.customScrollbar1.ThumbBottomSpanImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbBottomSpanImage")));
            this.customScrollbar1.ThumbHoverImage = null;
            this.customScrollbar1.ThumbMiddleImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbMiddleImage")));
            this.customScrollbar1.ThumbNomalImage = null;
            this.customScrollbar1.ThumbTopImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbTopImage")));
            this.customScrollbar1.ThumbTopSpanImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbTopSpanImage")));
            this.customScrollbar1.UpArrowImage = null;
            this.customScrollbar1.Value = 0;
            // 
            // UCSETTINGF001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.customScrollbar1);
            this.Controls.Add(this.innerPanel);
            this.Controls.Add(this.outerPanel);
            this.Controls.Add(this.lblShowInput);
            this.Name = "UCSETTINGF001";
            this.Size = new System.Drawing.Size(644, 560);
            this.Load += new System.EventHandler(this.UCSETTINGF001_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OFDAddImage;
        private System.Windows.Forms.Panel outerPanel;
        private System.Windows.Forms.Panel innerPanel;
        private System.Windows.Forms.Label lblShowInput;
        private CustomControls.CustomScrollbar customScrollbar1;
    }
}
