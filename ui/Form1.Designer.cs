namespace ui
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
            this.orderSearchBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reloadOrderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.customerDetailsBox = new System.Windows.Forms.DataGridView();
            this.order_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.DateFiltercheckBox = new System.Windows.Forms.CheckBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orderSearchBox
            // 
            this.orderSearchBox.DropDownWidth = 216;
            this.orderSearchBox.FormattingEnabled = true;
            this.orderSearchBox.Location = new System.Drawing.Point(75, 111);
            this.orderSearchBox.Name = "orderSearchBox";
            this.orderSearchBox.Size = new System.Drawing.Size(224, 24);
            this.orderSearchBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Number";
            // 
            // reloadOrderButton
            // 
            this.reloadOrderButton.Location = new System.Drawing.Point(75, 291);
            this.reloadOrderButton.Name = "reloadOrderButton";
            this.reloadOrderButton.Size = new System.Drawing.Size(224, 23);
            this.reloadOrderButton.TabIndex = 2;
            this.reloadOrderButton.Text = "Reload Orders";
            this.reloadOrderButton.UseVisualStyleBackColor = true;
            this.reloadOrderButton.Click += new System.EventHandler(this.ReloadOrderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Repository";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(78, 387);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(223, 22);
            this.DatePicker.TabIndex = 4;
            // 
            // customerDetailsBox
            // 
            this.customerDetailsBox.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerDetailsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDetailsBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_number,
            this.order_date,
            this.sale_price,
            this.deposit,
            this.cust_number,
            this.forename,
            this.surname,
            this.tel_number,
            this.branch_name,
            this.postcode});
            this.customerDetailsBox.Location = new System.Drawing.Point(367, 111);
            this.customerDetailsBox.Name = "customerDetailsBox";
            this.customerDetailsBox.RowHeadersWidth = 51;
            this.customerDetailsBox.RowTemplate.Height = 24;
            this.customerDetailsBox.Size = new System.Drawing.Size(1379, 211);
            this.customerDetailsBox.TabIndex = 2;
            // 
            // order_number
            // 
            this.order_number.HeaderText = "Order No.";
            this.order_number.MinimumWidth = 6;
            this.order_number.Name = "order_number";
            this.order_number.Width = 110;
            // 
            // order_date
            // 
            this.order_date.HeaderText = "Order Date";
            this.order_date.MinimumWidth = 6;
            this.order_date.Name = "order_date";
            this.order_date.Width = 125;
            // 
            // sale_price
            // 
            this.sale_price.HeaderText = "Sale Price";
            this.sale_price.MinimumWidth = 6;
            this.sale_price.Name = "sale_price";
            this.sale_price.Width = 80;
            // 
            // deposit
            // 
            this.deposit.HeaderText = "Deposit";
            this.deposit.MinimumWidth = 6;
            this.deposit.Name = "deposit";
            this.deposit.Width = 80;
            // 
            // cust_number
            // 
            this.cust_number.HeaderText = "Customer No.";
            this.cust_number.MinimumWidth = 6;
            this.cust_number.Name = "cust_number";
            this.cust_number.Width = 110;
            // 
            // forename
            // 
            this.forename.HeaderText = "Forename";
            this.forename.MinimumWidth = 6;
            this.forename.Name = "forename";
            this.forename.Width = 125;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.Width = 125;
            // 
            // tel_number
            // 
            this.tel_number.HeaderText = "Telephone No.";
            this.tel_number.MinimumWidth = 6;
            this.tel_number.Name = "tel_number";
            this.tel_number.Width = 125;
            // 
            // branch_name
            // 
            this.branch_name.HeaderText = "Branch Name";
            this.branch_name.MinimumWidth = 6;
            this.branch_name.Name = "branch_name";
            this.branch_name.Width = 125;
            // 
            // postcode
            // 
            this.postcode.HeaderText = "Postcode";
            this.postcode.MinimumWidth = 6;
            this.postcode.Name = "postcode";
            this.postcode.Width = 125;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(71, 347);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(114, 23);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Refine Search";
            // 
            // DateFiltercheckBox
            // 
            this.DateFiltercheckBox.AutoSize = true;
            this.DateFiltercheckBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFiltercheckBox.Location = new System.Drawing.Point(580, 391);
            this.DateFiltercheckBox.Name = "DateFiltercheckBox";
            this.DateFiltercheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateFiltercheckBox.Size = new System.Drawing.Size(18, 17);
            this.DateFiltercheckBox.TabIndex = 6;
            this.DateFiltercheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DateFiltercheckBox.UseVisualStyleBackColor = true;
            this.DateFiltercheckBox.CheckedChanged += new System.EventHandler(this.DateFilterCheckBox_CheckedChanged_1);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchLabel.Location = new System.Drawing.Point(75, 138);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(223, 150);
            this.searchLabel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filter by Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 484);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.DateFiltercheckBox);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.customerDetailsBox);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reloadOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderSearchBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orderSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadOrderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DataGridView customerDetailsBox;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.CheckBox DateFiltercheckBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcode;
        private System.Windows.Forms.Label label4;
    }
}

