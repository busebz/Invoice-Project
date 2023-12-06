namespace StajProje.Formlar
{
    partial class Campaigns
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label discount_rateLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label end_dateLabel;
            System.Windows.Forms.Label label2;
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.discount_rateTextBox = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.campaignIdTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBoxAccountId = new System.Windows.Forms.ComboBox();
            nameLabel = new System.Windows.Forms.Label();
            discount_rateLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            end_dateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(25, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // discount_rateLabel
            // 
            discount_rateLabel.AutoSize = true;
            discount_rateLabel.Location = new System.Drawing.Point(25, 121);
            discount_rateLabel.Name = "discount_rateLabel";
            discount_rateLabel.Size = new System.Drawing.Size(115, 20);
            discount_rateLabel.TabIndex = 9;
            discount_rateLabel.Text = "Discount Rate:";
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Location = new System.Drawing.Point(400, 33);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(87, 20);
            start_dateLabel.TabIndex = 11;
            start_dateLabel.Text = "Start Date:";
            // 
            // end_dateLabel
            // 
            end_dateLabel.AutoSize = true;
            end_dateLabel.Location = new System.Drawing.Point(400, 74);
            end_dateLabel.Name = "end_dateLabel";
            end_dateLabel.Size = new System.Drawing.Size(81, 20);
            end_dateLabel.TabIndex = 13;
            end_dateLabel.Text = "End Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 20);
            label2.TabIndex = 22;
            label2.Text = "Account Id:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(756, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Campaign Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(959, 317);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(162, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameTextBox.TabIndex = 8;
            // 
            // discount_rateTextBox
            // 
            this.discount_rateTextBox.Location = new System.Drawing.Point(162, 118);
            this.discount_rateTextBox.Name = "discount_rateTextBox";
            this.discount_rateTextBox.Size = new System.Drawing.Size(200, 26);
            this.discount_rateTextBox.TabIndex = 10;
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(511, 27);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.start_dateDateTimePicker.TabIndex = 12;
            // 
            // end_dateDateTimePicker
            // 
            this.end_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_dateDateTimePicker.Location = new System.Drawing.Point(511, 70);
            this.end_dateDateTimePicker.Name = "end_dateDateTimePicker";
            this.end_dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.end_dateDateTimePicker.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(815, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 35);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(815, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 35);
            this.button4.TabIndex = 19;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // campaignIdTextBox
            // 
            this.campaignIdTextBox.Location = new System.Drawing.Point(162, 162);
            this.campaignIdTextBox.Name = "campaignIdTextBox";
            this.campaignIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.campaignIdTextBox.TabIndex = 21;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(732, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 36);
            this.button5.TabIndex = 24;
            this.button5.Text = "New";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBoxAccountId
            // 
            this.comboBoxAccountId.FormattingEnabled = true;
            this.comboBoxAccountId.Location = new System.Drawing.Point(162, 25);
            this.comboBoxAccountId.Name = "comboBoxAccountId";
            this.comboBoxAccountId.Size = new System.Drawing.Size(200, 28);
            this.comboBoxAccountId.TabIndex = 25;
            // 
            // Campaigns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 555);
            this.Controls.Add(this.comboBoxAccountId);
            this.Controls.Add(this.button5);
            this.Controls.Add(label2);
            this.Controls.Add(this.campaignIdTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(discount_rateLabel);
            this.Controls.Add(this.discount_rateTextBox);
            this.Controls.Add(start_dateLabel);
            this.Controls.Add(this.start_dateDateTimePicker);
            this.Controls.Add(end_dateLabel);
            this.Controls.Add(this.end_dateDateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "Campaigns";
            this.Text = "Campaigns";
            this.Load += new System.EventHandler(this.Campaigns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox discount_rateTextBox;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker end_dateDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox campaignIdTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBoxAccountId;
    }
}