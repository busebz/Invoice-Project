namespace StajProje.Formlar
{
    partial class CampaignDetail
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
            System.Windows.Forms.Label discount_rateLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campDetailIdTextBox = new System.Windows.Forms.TextBox();
            this.textBoxCampaignId = new System.Windows.Forms.TextBox();
            this.textBoxDiscountRate = new System.Windows.Forms.TextBox();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            discount_rateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // discount_rateLabel
            // 
            discount_rateLabel.AutoSize = true;
            discount_rateLabel.Location = new System.Drawing.Point(21, 112);
            discount_rateLabel.Name = "discount_rateLabel";
            discount_rateLabel.Size = new System.Drawing.Size(115, 20);
            discount_rateLabel.TabIndex = 8;
            discount_rateLabel.Text = "Discount Rate:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(467, 340);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Campaign Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Id:";
            // 
            // campDetailIdTextBox
            // 
            this.campDetailIdTextBox.Location = new System.Drawing.Point(317, 68);
            this.campDetailIdTextBox.Name = "campDetailIdTextBox";
            this.campDetailIdTextBox.Size = new System.Drawing.Size(175, 26);
            this.campDetailIdTextBox.TabIndex = 15;
            // 
            // textBoxCampaignId
            // 
            this.textBoxCampaignId.Location = new System.Drawing.Point(142, 38);
            this.textBoxCampaignId.Name = "textBoxCampaignId";
            this.textBoxCampaignId.Size = new System.Drawing.Size(164, 26);
            this.textBoxCampaignId.TabIndex = 16;
            // 
            // textBoxDiscountRate
            // 
            this.textBoxDiscountRate.Location = new System.Drawing.Point(142, 109);
            this.textBoxDiscountRate.Name = "textBoxDiscountRate";
            this.textBoxDiscountRate.Size = new System.Drawing.Size(164, 26);
            this.textBoxDiscountRate.TabIndex = 17;
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(142, 73);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(164, 26);
            this.textBoxProductId.TabIndex = 18;
            // 
            // CampaignDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 555);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.textBoxDiscountRate);
            this.Controls.Add(this.textBoxCampaignId);
            this.Controls.Add(this.campDetailIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(discount_rateLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CampaignDetail";
            this.Text = "CampaignDetail";
            this.Load += new System.EventHandler(this.CampaignDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campDetailIdTextBox;
        private System.Windows.Forms.TextBox textBoxCampaignId;
        private System.Windows.Forms.TextBox textBoxDiscountRate;
        private System.Windows.Forms.TextBox textBoxProductId;
    }
}