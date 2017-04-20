namespace Retail.UI.Controls
{
    partial class DetailControl
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
            this.labelCode = new System.Windows.Forms.Label();
            this.labelCodeValue = new System.Windows.Forms.Label();
            this.labelPriceValue = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAmountValue = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelSumValue = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCode.Location = new System.Drawing.Point(8, 4);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(43, 20);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Код:";
            // 
            // labelCodeValue
            // 
            this.labelCodeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCodeValue.Location = new System.Drawing.Point(51, 4);
            this.labelCodeValue.Name = "labelCodeValue";
            this.labelCodeValue.Size = new System.Drawing.Size(135, 23);
            this.labelCodeValue.TabIndex = 1;
            this.labelCodeValue.Text = "<код товара>";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceValue.Location = new System.Drawing.Point(238, 4);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(116, 20);
            this.labelPriceValue.TabIndex = 3;
            this.labelPriceValue.Text = "<цена товара>";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(187, 4);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 20);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена:";
            // 
            // labelAmountValue
            // 
            this.labelAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmountValue.Location = new System.Drawing.Point(454, 4);
            this.labelAmountValue.Name = "labelAmountValue";
            this.labelAmountValue.Size = new System.Drawing.Size(95, 20);
            this.labelAmountValue.TabIndex = 5;
            this.labelAmountValue.Text = "<количество товара>";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(351, 4);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(104, 20);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Количество:";
            // 
            // labelSumValue
            // 
            this.labelSumValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumValue.Location = new System.Drawing.Point(605, 4);
            this.labelSumValue.Name = "labelSumValue";
            this.labelSumValue.Size = new System.Drawing.Size(133, 20);
            this.labelSumValue.TabIndex = 7;
            this.labelSumValue.Text = "<сумма товара>";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(544, 4);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(62, 20);
            this.labelSum.TabIndex = 6;
            this.labelSum.Text = "Сумма:";
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullName.AutoEllipsis = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(3, 30);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(735, 41);
            this.labelFullName.TabIndex = 8;
            this.labelFullName.Text = "Вкусное мороженко";
            // 
            // DetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelSumValue);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelAmountValue);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelPriceValue);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCodeValue);
            this.Controls.Add(this.labelCode);
            this.Name = "DetailControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelCodeValue;
        private System.Windows.Forms.Label labelPriceValue;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAmountValue;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelSumValue;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelFullName;
    }
}
