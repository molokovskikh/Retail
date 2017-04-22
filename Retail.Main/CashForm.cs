using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retail.Device;
using Retail.Repository;
using Retail.UI;
using Retail.UI.Controls;
using Autofac;
using System.Diagnostics;
using Retail.Models;

namespace Retail.Main
{
    public partial class CashForm : Form
    {
        #region Autowiring

        public ICash cash { get; set; }
        public IBarScanner barScanner { get; set; }
        public IDisplayCustomer displayCustomer { get; set; }
        public IProductRepository productRepository { get; set; }
        public IDocumentRepository documentRepository { get; set; }
        public IShortcutKeyManager shortcutKeyManager { get; set; }

       
        public IApplication application { get; set; }
        public ICaptionControl captionControl { get; set; }
        public ITableControl tableControl { get; set; }
        public IDetailControl detailControl { get; set; }
        public IButtonsControl buttonsControl { get; set; }
        public IInputControl inputControl { get; set; }
        public ITotalControl totalControl { get; set; }
        public IStatusControl statusControl { get; set; }

         #endregion



        public CashForm()
        {               
            //Поставим обработчик на создание окна в Runtime
            if (!DesignMode)
            {
                this.HandleCreated += (s, o) =>
                    {
                        RuntimeInitializeComponent();
                        fillTestDataProducts();
                    };
                return;
            }

            //Просмотр в дизайнере
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация формы в Runtime
        /// </summary>
        private void RuntimeInitializeComponent()
        {
           
            this.statusControl1 = this.statusControl as StatusControl;
            this.totalControl1 = this.totalControl as TotalControl;
            this.inputControl1 = this.inputControl as InputControl;
            this.detailControl1 = this.detailControl as DetailControl;
            this.tableControl1 = this.tableControl as TableControl;
            this.buttonsControl1= this.buttonsControl as ButtonsControl;
            this.captionControl1 = this.captionControl as CaptionControl;
           
            (application as ApplicationContext).SetMainForm(this);
          
            this.KeyPreview = true;
            this.KeyDown+=(s,e)=>
                {
                    if (e.KeyData == Keys.Escape)
                        this.tableControl1.Focus();
                       
                    shortcutKeyManager.Handle(e.KeyCode,e.Modifiers);
                };

            ///При редактировании в дизайнере скопируйте весь код автоматически сгенерированный в дизайнере в место начиная со следующей строки 

            this.SuspendLayout();
            // 
            // buttonsControl1
            // 
            this.buttonsControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonsControl1.Location = new System.Drawing.Point(2, 506);
            this.buttonsControl1.Name = "buttonsControl1";
            this.buttonsControl1.Size = new System.Drawing.Size(875, 63);
            this.buttonsControl1.TabIndex = 3;
            this.buttonsControl1.TabStop = true;
            // 
            // statusControl1
            // 
            this.statusControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusControl1.Location = new System.Drawing.Point(2, 572);
            this.statusControl1.Name = "statusControl1";
            this.statusControl1.Size = new System.Drawing.Size(875, 33);
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
            this.totalControl1.Size = new System.Drawing.Size(875, 120);
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
            this.inputControl1.Size = new System.Drawing.Size(875, 50);
            this.inputControl1.TabIndex = 2;
            // 
            // detailControl1
            // 
            this.detailControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailControl1.Location = new System.Drawing.Point(2, 253);
            this.detailControl1.Name = "detailControl1";
            this.detailControl1.Size = new System.Drawing.Size(875, 74);
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
            this.tableControl1.Size = new System.Drawing.Size(875, 211);
            this.tableControl1.TabIndex = 1;
            // 
            // captionControl1
            // 
            this.captionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captionControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionControl1.Location = new System.Drawing.Point(2, 1);
            this.captionControl1.Name = "captionControl1";
            this.captionControl1.Size = new System.Drawing.Size(875, 35);
            this.captionControl1.TabIndex = 0;
            // 
            // CashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 607);
            this.Controls.Add(this.buttonsControl1);
            this.Controls.Add(this.statusControl1);
            this.Controls.Add(this.totalControl1);
            this.Controls.Add(this.inputControl1);
            this.Controls.Add(this.detailControl1);
            this.Controls.Add(this.tableControl1);
            this.Controls.Add(this.captionControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Касса";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        
       
        private void CashForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Заполнить таблицу тестовых данных
        /// </summary>
        private void fillTestDataProducts()
        {
            int id = 0;
            this.tableControl.AddProduct(
                new Product()
                {
                    Id = ++id,
                    Classifier = new Classifier() { Id = id, Name = "Вкусная булочка" },
                    Price = 254.23m
                },
                2.34m);

             this.tableControl.AddProduct(
               new Product()
                {
                    Id = ++id,
                    Classifier = new Classifier() { Id = id, Name = "Замечательный пирожок" },
                    Price = 534.323m
                },
                12.34m
            );

             this.tableControl.AddProduct(
                new Product()
                {
                    Id = ++id,
                    Classifier = new Classifier() { Id = id, Name = @"Мороженное ""Пальчики оближешь""" },
                    Price = 54.25m
                },
                234m
            );
        } 
    }
}
