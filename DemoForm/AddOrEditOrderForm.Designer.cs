namespace DemoForm
{
    partial class AddOrEditOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.articulBox1 = new System.Windows.Forms.TextBox();
            this.countBox1 = new System.Windows.Forms.NumericUpDown();
            this.countBox2 = new System.Windows.Forms.NumericUpDown();
            this.articulBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pickupAddressBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderDateBox = new System.Windows.Forms.DateTimePicker();
            this.delieveryDateBox = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул заказа (артикул товара + количество): ";
            // 
            // articulBox1
            // 
            this.articulBox1.Location = new System.Drawing.Point(15, 32);
            this.articulBox1.Name = "articulBox1";
            this.articulBox1.Size = new System.Drawing.Size(100, 20);
            this.articulBox1.TabIndex = 1;
            // 
            // countBox1
            // 
            this.countBox1.Location = new System.Drawing.Point(121, 32);
            this.countBox1.Name = "countBox1";
            this.countBox1.Size = new System.Drawing.Size(55, 20);
            this.countBox1.TabIndex = 2;
            // 
            // countBox2
            // 
            this.countBox2.Location = new System.Drawing.Point(289, 31);
            this.countBox2.Name = "countBox2";
            this.countBox2.Size = new System.Drawing.Size(55, 20);
            this.countBox2.TabIndex = 4;
            // 
            // articulBox2
            // 
            this.articulBox2.Location = new System.Drawing.Point(183, 31);
            this.articulBox2.Name = "articulBox2";
            this.articulBox2.Size = new System.Drawing.Size(100, 20);
            this.articulBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Статус заказа:";
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Новый",
            "В доставке",
            "Завершен"});
            this.statusBox.Location = new System.Drawing.Point(130, 73);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(214, 22);
            this.statusBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес пункта выдачи:";
            // 
            // pickupAddressBox
            // 
            this.pickupAddressBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickupAddressBox.FormattingEnabled = true;
            this.pickupAddressBox.Location = new System.Drawing.Point(130, 114);
            this.pickupAddressBox.Name = "pickupAddressBox";
            this.pickupAddressBox.Size = new System.Drawing.Size(214, 22);
            this.pickupAddressBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата заказа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата выдачи:";
            // 
            // orderDateBox
            // 
            this.orderDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDateBox.Location = new System.Drawing.Point(130, 150);
            this.orderDateBox.Name = "orderDateBox";
            this.orderDateBox.Size = new System.Drawing.Size(214, 20);
            this.orderDateBox.TabIndex = 11;
            // 
            // delieveryDateBox
            // 
            this.delieveryDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.delieveryDateBox.Location = new System.Drawing.Point(130, 184);
            this.delieveryDateBox.Name = "delieveryDateBox";
            this.delieveryDateBox.Size = new System.Drawing.Size(214, 20);
            this.delieveryDateBox.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cancelButton.Location = new System.Drawing.Point(40, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.okButton.Location = new System.Drawing.Point(238, 238);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddOrEditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 284);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.delieveryDateBox);
            this.Controls.Add(this.orderDateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pickupAddressBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countBox2);
            this.Controls.Add(this.articulBox2);
            this.Controls.Add(this.countBox1);
            this.Controls.Add(this.articulBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddOrEditOrderForm";
            this.Text = "AddOrEditOrderForm";
            this.Load += new System.EventHandler(this.AddOrEditOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox articulBox1;
        private System.Windows.Forms.NumericUpDown countBox1;
        private System.Windows.Forms.NumericUpDown countBox2;
        private System.Windows.Forms.TextBox articulBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pickupAddressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker orderDateBox;
        private System.Windows.Forms.DateTimePicker delieveryDateBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}