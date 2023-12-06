namespace StajProje.Formlar
{
    partial class Invoice
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
            System.Windows.Forms.Label invoiceNumberLabel;
            System.Windows.Forms.Label create_dateLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.invoice_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.labelCampaignId = new System.Windows.Forms.Label();
            this.invoiceIdTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxAccountId = new System.Windows.Forms.ComboBox();
            this.comboBoxCampaignId = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new System.Drawing.Point(30, 113);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(123, 20);
            invoiceNumberLabel.TabIndex = 9;
            invoiceNumberLabel.Text = "Invoice Number:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(30, 153);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(100, 20);
            create_dateLabel.TabIndex = 13;
            create_dateLabel.Text = "Create Date:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 327);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(953, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Invoice Detail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productProjectDataSet
            // 
            
            // invoice_BindingSource
            // 
            this.invoice_BindingSource.DataMember = "Invoice$";

            // 
            // invoice_TableAdapter
            // 

            // 
            // tableAdapterManager
            // 
           
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_BindingSource, "invoiceNumber", true));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(165, 113);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(172, 26);
            this.invoiceNumberTextBox.TabIndex = 10;
            // 
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoice_BindingSource, "create_date", true));
            this.create_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(165, 153);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(172, 26);
            this.create_dateDateTimePicker.TabIndex = 14;
            // 
            // labelAccountId
            // 
            this.labelAccountId.AutoSize = true;
            this.labelAccountId.Location = new System.Drawing.Point(32, 25);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(72, 20);
            this.labelAccountId.TabIndex = 19;
            this.labelAccountId.Text = "Account:";
            // 
            // labelCampaignId
            // 
            this.labelCampaignId.AutoSize = true;
            this.labelCampaignId.Location = new System.Drawing.Point(32, 68);
            this.labelCampaignId.Name = "labelCampaignId";
            this.labelCampaignId.Size = new System.Drawing.Size(85, 20);
            this.labelCampaignId.TabIndex = 20;
            this.labelCampaignId.Text = "Campaign:";
            // 
            // invoiceIdTextBox
            // 
            this.invoiceIdTextBox.Location = new System.Drawing.Point(165, 185);
            this.invoiceIdTextBox.Name = "invoiceIdTextBox";
            this.invoiceIdTextBox.Size = new System.Drawing.Size(172, 26);
            this.invoiceIdTextBox.TabIndex = 21;
            // 
            // comboBoxAccountId
            // 
            this.comboBoxAccountId.FormattingEnabled = true;
            this.comboBoxAccountId.Location = new System.Drawing.Point(165, 22);
            this.comboBoxAccountId.Name = "comboBoxAccountId";
            this.comboBoxAccountId.Size = new System.Drawing.Size(172, 28);
            this.comboBoxAccountId.TabIndex = 25;
            this.comboBoxAccountId.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccountId_SelectedIndexChanged);
            // 
            // comboBoxCampaignId
            // 
            this.comboBoxCampaignId.FormattingEnabled = true;
            this.comboBoxCampaignId.Location = new System.Drawing.Point(165, 68);
            this.comboBoxCampaignId.Name = "comboBoxCampaignId";
            this.comboBoxCampaignId.Size = new System.Drawing.Size(172, 28);
            this.comboBoxCampaignId.TabIndex = 26;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(165, 217);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(172, 35);
            this.buttonSearch.TabIndex = 27;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(953, 68);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 31);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Add Invoice";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 626);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxCampaignId);
            this.Controls.Add(this.comboBoxAccountId);
            this.Controls.Add(this.invoiceIdTextBox);
            this.Controls.Add(this.labelCampaignId);
            this.Controls.Add(this.labelAccountId);
            this.Controls.Add(invoiceNumberLabel);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Controls.Add(create_dateLabel);
            this.Controls.Add(this.create_dateDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource invoice_BindingSource;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.DateTimePicker create_dateDateTimePicker;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.Label labelCampaignId;
        private System.Windows.Forms.TextBox invoiceIdTextBox;
        private System.Windows.Forms.ComboBox comboBoxAccountId;
        private System.Windows.Forms.ComboBox comboBoxCampaignId;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAdd;
    }
}