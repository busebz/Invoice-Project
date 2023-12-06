namespace StajProje.Formlar
{
    partial class Invoicelines
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
            System.Windows.Forms.Label discount_rateLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label total_priceLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
          
            this.invoiceline_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.discount_rateTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.total_priceTextBox = new System.Windows.Forms.TextBox();
            this.invoiceIdTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            discount_rateLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            total_priceLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.invoiceline_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // discount_rateLabel
            // 
            discount_rateLabel.AutoSize = true;
            discount_rateLabel.Location = new System.Drawing.Point(54, 130);
            discount_rateLabel.Name = "discount_rateLabel";
            discount_rateLabel.Size = new System.Drawing.Size(115, 20);
            discount_rateLabel.TabIndex = 12;
            discount_rateLabel.Text = "Discount Rate:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(54, 170);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(52, 20);
            priceLabel.TabIndex = 14;
            priceLabel.Text = "Price: ";
            // 
            // total_priceLabel
            // 
            total_priceLabel.AutoSize = true;
            total_priceLabel.Location = new System.Drawing.Point(54, 202);
            total_priceLabel.Name = "total_priceLabel";
            total_priceLabel.Size = new System.Drawing.Size(87, 20);
            total_priceLabel.TabIndex = 16;
            total_priceLabel.Text = "Total Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(53, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 20);
            label2.TabIndex = 24;
            label2.Text = "Invoice Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(54, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 20);
            label3.TabIndex = 26;
            label3.Text = "Product Id:";
            // 
            // productProjectDataSet
            // 
           
            // invoiceline_BindingSource
            // 
            this.invoiceline_BindingSource.DataMember = "Invoiceline$";

            // 
            // invoiceline_TableAdapter
            // 
            // 
            // tableAdapterManager
            // 
            
            // 
            // discount_rateTextBox
            // 
            this.discount_rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceline_BindingSource, "discount_rate", true));
            this.discount_rateTextBox.Location = new System.Drawing.Point(175, 130);
            this.discount_rateTextBox.Name = "discount_rateTextBox";
            this.discount_rateTextBox.Size = new System.Drawing.Size(135, 26);
            this.discount_rateTextBox.TabIndex = 13;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceline_BindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(175, 167);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(135, 26);
            this.priceTextBox.TabIndex = 15;
            // 
            // total_priceTextBox
            // 
            this.total_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceline_BindingSource, "total_price", true));
            this.total_priceTextBox.Location = new System.Drawing.Point(175, 199);
            this.total_priceTextBox.Name = "total_priceTextBox";
            this.total_priceTextBox.Size = new System.Drawing.Size(135, 26);
            this.total_priceTextBox.TabIndex = 17;
            // 
            // invoiceIdTextBox
            // 
            this.invoiceIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceline_BindingSource, "count", true));
            this.invoiceIdTextBox.Location = new System.Drawing.Point(174, 57);
            this.invoiceIdTextBox.Name = "invoiceIdTextBox";
            this.invoiceIdTextBox.Size = new System.Drawing.Size(135, 26);
            this.invoiceIdTextBox.TabIndex = 25;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceline_BindingSource, "discount_rate", true));
            this.productIdTextBox.Location = new System.Drawing.Point(175, 92);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(135, 26);
            this.productIdTextBox.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(579, 270);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Invoicelines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(label2);
            this.Controls.Add(this.invoiceIdTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(discount_rateLabel);
            this.Controls.Add(this.discount_rateTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(total_priceLabel);
            this.Controls.Add(this.total_priceTextBox);
            this.Name = "Invoicelines";
            this.Text = "Invoicelines";
            this.Load += new System.EventHandler(this.Invoicelines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceline_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource invoiceline_BindingSource;
        private System.Windows.Forms.TextBox discount_rateTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox total_priceTextBox;
        private System.Windows.Forms.TextBox invoiceIdTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}