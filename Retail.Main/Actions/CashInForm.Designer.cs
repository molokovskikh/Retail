namespace Retail.Main
{
    partial class CashInForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCashIn = new System.Windows.Forms.TextBox();
            this.labelToPayValue = new System.Windows.Forms.Label();
            this.labelOddMoneyValue = new System.Windows.Forms.Label();
            this.labelToPay = new System.Windows.Forms.Label();
            this.labelOddMoney = new System.Windows.Forms.Label();
            this.labelCashIn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxCashIn);
            this.panel1.Controls.Add(this.labelToPayValue);
            this.panel1.Controls.Add(this.labelOddMoneyValue);
            this.panel1.Controls.Add(this.labelToPay);
            this.panel1.Controls.Add(this.labelOddMoney);
            this.panel1.Controls.Add(this.labelCashIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 157);
            this.panel1.TabIndex = 0;
            // 
            // textBoxCashIn
            // 
            this.textBoxCashIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCashIn.Location = new System.Drawing.Point(157, 6);
            this.textBoxCashIn.Name = "textBoxCashIn";
            this.textBoxCashIn.Size = new System.Drawing.Size(159, 38);
            this.textBoxCashIn.TabIndex = 12;
            this.textBoxCashIn.TextChanged += new System.EventHandler(this.textBoxCashIn_TextChanged);
            this.textBoxCashIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCashIn_KeyPress);
            // 
            // labelToPayValue
            // 
            this.labelToPayValue.AutoSize = true;
            this.labelToPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToPayValue.Location = new System.Drawing.Point(151, 62);
            this.labelToPayValue.Name = "labelToPayValue";
            this.labelToPayValue.Size = new System.Drawing.Size(0, 31);
            this.labelToPayValue.TabIndex = 10;
            // 
            // labelOddMoneyValue
            // 
            this.labelOddMoneyValue.AutoSize = true;
            this.labelOddMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOddMoneyValue.Location = new System.Drawing.Point(151, 113);
            this.labelOddMoneyValue.Name = "labelOddMoneyValue";
            this.labelOddMoneyValue.Size = new System.Drawing.Size(0, 31);
            this.labelOddMoneyValue.TabIndex = 11;
            // 
            // labelToPay
            // 
            this.labelToPay.AutoSize = true;
            this.labelToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToPay.Location = new System.Drawing.Point(18, 61);
            this.labelToPay.Name = "labelToPay";
            this.labelToPay.Size = new System.Drawing.Size(143, 31);
            this.labelToPay.TabIndex = 8;
            this.labelToPay.Text = "К оплате:";
            // 
            // labelOddMoney
            // 
            this.labelOddMoney.AutoSize = true;
            this.labelOddMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOddMoney.Location = new System.Drawing.Point(53, 113);
            this.labelOddMoney.Name = "labelOddMoney";
            this.labelOddMoney.Size = new System.Drawing.Size(108, 31);
            this.labelOddMoney.TabIndex = 9;
            this.labelOddMoney.Text = "Сдача:";
            // 
            // labelCashIn
            // 
            this.labelCashIn.AutoSize = true;
            this.labelCashIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCashIn.Location = new System.Drawing.Point(2, 8);
            this.labelCashIn.Name = "labelCashIn";
            this.labelCashIn.Size = new System.Drawing.Size(159, 31);
            this.labelCashIn.TabIndex = 6;
            this.labelCashIn.Text = "Наличные:";
            // 
            // CashInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(324, 157);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "CashInForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CashInForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CashInForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelToPayValue;
        private System.Windows.Forms.Label labelOddMoneyValue;
        private System.Windows.Forms.Label labelToPay;
        private System.Windows.Forms.Label labelOddMoney;
        private System.Windows.Forms.Label labelCashIn;
        private System.Windows.Forms.TextBox textBoxCashIn;
    }
}