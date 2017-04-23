namespace Retail.Main
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
            this.buttonsControl1 = new Retail.UI.Controls.ButtonsControl();
            this.statusControl1 = new Retail.UI.Controls.StatusControl();
            this.totalControl1 = new Retail.UI.Controls.TotalControl();
            this.inputControl1 = new Retail.UI.Controls.InputControl();
            this.detailControl1 = new Retail.UI.Controls.DetailControl();
            this.tableControl1 = new Retail.UI.Controls.TableControl();
            this.captionControl1 = new Retail.UI.Controls.CaptionControl();
            this.SuspendLayout();
            // 
            // buttonsControl1
            // 
            this.buttonsControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonsControl1.Location = new System.Drawing.Point(2, 506);
            this.buttonsControl1.Name = "buttonsControl1";
            this.buttonsControl1.Size = new System.Drawing.Size(1022, 63);
            this.buttonsControl1.TabIndex = 2;
            // 
            // statusControl1
            // 
            this.statusControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusControl1.Location = new System.Drawing.Point(2, 572);
            this.statusControl1.Name = "statusControl1";
            this.statusControl1.Size = new System.Drawing.Size(1022, 33);
            this.statusControl1.TabIndex = 0;
            this.statusControl1.TabStop = false;
            // 
            // totalControl1
            // 
            this.totalControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalControl1.Location = new System.Drawing.Point(2, 382);
            this.totalControl1.Name = "totalControl1";
            this.totalControl1.Size = new System.Drawing.Size(1022, 120);
            this.totalControl1.TabIndex = 0;
            this.totalControl1.TabStop = false;
            // 
            // inputControl1
            // 
            this.inputControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControl1.AutoSize = true;
            this.inputControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputControl1.Location = new System.Drawing.Point(2, 331);
            this.inputControl1.Name = "inputControl1";
            this.inputControl1.Size = new System.Drawing.Size(1022, 50);
            this.inputControl1.TabIndex = 2;
            // 
            // detailControl1
            // 
            this.detailControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailControl1.Location = new System.Drawing.Point(2, 253);
            this.detailControl1.Name = "detailControl1";
            this.detailControl1.Size = new System.Drawing.Size(1022, 74);
            this.detailControl1.TabIndex = 0;
            this.detailControl1.TabStop = false;
            // 
            // tableControl1
            // 
            this.tableControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableControl1.Location = new System.Drawing.Point(2, 39);
            this.tableControl1.Name = "tableControl1";
            this.tableControl1.Size = new System.Drawing.Size(1022, 211);
            this.tableControl1.TabIndex = 1;
            // 
            // captionControl1
            // 
            this.captionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captionControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionControl1.Location = new System.Drawing.Point(2, 1);
            this.captionControl1.Name = "captionControl1";
            this.captionControl1.Size = new System.Drawing.Size(1022, 35);
            this.captionControl1.TabIndex = 0;
            this.captionControl1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 607);
            this.Controls.Add(this.buttonsControl1);
            this.Controls.Add(this.statusControl1);
            this.Controls.Add(this.totalControl1);
            this.Controls.Add(this.inputControl1);
            this.Controls.Add(this.detailControl1);
            this.Controls.Add(this.tableControl1);
            this.Controls.Add(this.captionControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1024, 605);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private UI.Controls.CaptionControl captionControl1;
        private UI.Controls.TableControl tableControl1;
        private UI.Controls.DetailControl detailControl1;
        private UI.Controls.InputControl inputControl1;
        private UI.Controls.TotalControl totalControl1;
        private UI.Controls.StatusControl statusControl1;
        private UI.Controls.ButtonsControl buttonsControl1;







    }
}