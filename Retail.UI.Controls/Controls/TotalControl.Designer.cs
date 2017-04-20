namespace Retail.UI.Controls
{
    partial class TotalControl
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
            this.labelDoc = new System.Windows.Forms.Label();
            this.labelNumDoc = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelDocValue = new System.Windows.Forms.Label();
            this.labelDocNumValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelSumValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoc.Location = new System.Drawing.Point(23, 6);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(130, 20);
            this.labelDoc.TabIndex = 0;
            this.labelDoc.Text = "Вид документа:";
            // 
            // labelNumDoc
            // 
            this.labelNumDoc.AutoSize = true;
            this.labelNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumDoc.Location = new System.Drawing.Point(4, 39);
            this.labelNumDoc.Name = "labelNumDoc";
            this.labelNumDoc.Size = new System.Drawing.Size(149, 20);
            this.labelNumDoc.TabIndex = 1;
            this.labelNumDoc.Text = "Номер документа:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(75, 70);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(78, 20);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "Позиций:";
            // 
            // labelDocValue
            // 
            this.labelDocValue.AutoSize = true;
            this.labelDocValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocValue.Location = new System.Drawing.Point(156, 2);
            this.labelDocValue.Name = "labelDocValue";
            this.labelDocValue.Size = new System.Drawing.Size(212, 25);
            this.labelDocValue.TabIndex = 3;
            this.labelDocValue.Text = "Продажа (Открыт)";
            // 
            // labelDocNumValue
            // 
            this.labelDocNumValue.AutoSize = true;
            this.labelDocNumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocNumValue.Location = new System.Drawing.Point(156, 37);
            this.labelDocNumValue.Name = "labelDocNumValue";
            this.labelDocNumValue.Size = new System.Drawing.Size(142, 25);
            this.labelDocNumValue.TabIndex = 4;
            this.labelDocNumValue.Text = "0000000005";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "3";           
            // 
            // labelSum
            // 
            this.labelSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(471, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(267, 31);
            this.labelSum.TabIndex = 6;
            this.labelSum.Text = "Сумма документа:";
            // 
            // labelSumValue
            // 
            this.labelSumValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumValue.Location = new System.Drawing.Point(395, 29);
            this.labelSumValue.Name = "labelSumValue";
            this.labelSumValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSumValue.Size = new System.Drawing.Size(343, 65);
            this.labelSumValue.TabIndex = 7;
            this.labelSumValue.Text = "190.00";
            // 
            // TotalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDocNumValue);
            this.Controls.Add(this.labelDocValue);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelNumDoc);
            this.Controls.Add(this.labelDoc);
            this.Controls.Add(this.labelSumValue);
            this.Name = "TotalControl";
            this.Size = new System.Drawing.Size(741, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Label labelNumDoc;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelDocValue;
        private System.Windows.Forms.Label labelDocNumValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelSumValue;
    }
}
