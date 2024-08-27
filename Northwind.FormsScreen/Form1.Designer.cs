namespace Northwind.FormsScreen
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.nhProductDalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ControlBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhProductDalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoGenerateColumns = false;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.DataSource = this.nhProductDalBindingSource;
            this.dgwProducts.Location = new System.Drawing.Point(38, 42);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(911, 396);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nhProductDalBindingSource
            // 
            this.nhProductDalBindingSource.DataSource = typeof(Northwind.DataAccess.Concrete.NHibernate.NhProductDal);
            // 
            // ControlBtn
            // 
            this.ControlBtn.Location = new System.Drawing.Point(299, 485);
            this.ControlBtn.Name = "ControlBtn";
            this.ControlBtn.Size = new System.Drawing.Size(132, 47);
            this.ControlBtn.TabIndex = 1;
            this.ControlBtn.Text = "Control";
            this.ControlBtn.UseVisualStyleBackColor = true;
            this.ControlBtn.Click += new System.EventHandler(this.ControlBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 501);
            this.Controls.Add(this.ControlBtn);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhProductDalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.BindingSource nhProductDalBindingSource;
        private System.Windows.Forms.Button ControlBtn;
    }
}

