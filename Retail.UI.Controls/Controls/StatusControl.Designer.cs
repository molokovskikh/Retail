namespace Retail.UI.Controls
{
    partial class StatusControl
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
            this.labelLanguage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNowTime = new System.Windows.Forms.Label();
            this.labelSmena = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNowTimeValue = new System.Windows.Forms.Label();
            this.labelSmenaValue = new System.Windows.Forms.Label();
            this.labelUserValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLanguage
            // 
            this.labelLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLanguage.Location = new System.Drawing.Point(513, 1);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(32, 26);
            this.labelLanguage.TabIndex = 8;
            this.labelLanguage.Text = "RU";
            this.labelLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Статус кассы:";
            // 
            // labelNowTime
            // 
            this.labelNowTime.AutoSize = true;
            this.labelNowTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNowTime.Location = new System.Drawing.Point(372, 7);
            this.labelNowTime.Name = "labelNowTime";
            this.labelNowTime.Size = new System.Drawing.Size(47, 15);
            this.labelNowTime.TabIndex = 4;
            this.labelNowTime.Text = "Время:";
            // 
            // labelSmena
            // 
            this.labelSmena.AutoSize = true;
            this.labelSmena.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmena.Location = new System.Drawing.Point(226, 7);
            this.labelSmena.Name = "labelSmena";
            this.labelSmena.Size = new System.Drawing.Size(89, 15);
            this.labelSmena.TabIndex = 2;
            this.labelSmena.Text = "Номер смены:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(4, 7);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(144, 15);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Текущий пользователь:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Кончилась кассовая лента!!!";
            // 
            // labelNowTimeValue
            // 
            this.labelNowTimeValue.AutoSize = true;
            this.labelNowTimeValue.Location = new System.Drawing.Point(418, 8);
            this.labelNowTimeValue.Name = "labelNowTimeValue";
            this.labelNowTimeValue.Size = new System.Drawing.Size(91, 13);
            this.labelNowTimeValue.TabIndex = 5;
            this.labelNowTimeValue.Text = "27.03.2017 14:05";
            // 
            // labelSmenaValue
            // 
            this.labelSmenaValue.AutoSize = true;
            this.labelSmenaValue.Location = new System.Drawing.Point(317, 8);
            this.labelSmenaValue.Name = "labelSmenaValue";
            this.labelSmenaValue.Size = new System.Drawing.Size(54, 13);
            this.labelSmenaValue.TabIndex = 3;
            this.labelSmenaValue.Text = "12 смена";
            // 
            // labelUserValue
            // 
            this.labelUserValue.AutoSize = true;
            this.labelUserValue.Location = new System.Drawing.Point(147, 8);
            this.labelUserValue.Name = "labelUserValue";
            this.labelUserValue.Size = new System.Drawing.Size(73, 13);
            this.labelUserValue.TabIndex = 1;
            this.labelUserValue.Text = "Иванов И. И.";
            // 
            // StatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNowTime);
            this.Controls.Add(this.labelSmena);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNowTimeValue);
            this.Controls.Add(this.labelSmenaValue);
            this.Controls.Add(this.labelUserValue);
            this.Name = "StatusControl";
            this.Size = new System.Drawing.Size(794, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUserValue;
        private System.Windows.Forms.Label labelSmena;
        private System.Windows.Forms.Label labelSmenaValue;
        private System.Windows.Forms.Label labelNowTime;
        private System.Windows.Forms.Label labelNowTimeValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLanguage;
    }
}
