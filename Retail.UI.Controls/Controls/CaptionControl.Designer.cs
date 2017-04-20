namespace Retail.UI.Controls
{
    partial class CaptionControl
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
            this.butClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.butClose)).BeginInit();
            this.SuspendLayout();
            // 
            // butClose
            // 
            this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butClose.Image = global::Retail.UI.Controls.Properties.Resources.close_button_png_30243;
            this.butClose.Location = new System.Drawing.Point(788, 3);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(26, 26);
            this.butClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.butClose.TabIndex = 1;
            this.butClose.TabStop = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Просто заголовок рабочего места кассира. сюда можно забабахать логотип и что душа" +
    " пожелает..хоть новости бегущей строкой ))";
            // 
            // CaptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.label1);
            this.Name = "CaptionControl";
            this.Size = new System.Drawing.Size(817, 34);
            ((System.ComponentModel.ISupportInitialize)(this.butClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox butClose;

    }
}
