namespace DemoForm
{
    partial class AddOrEditForm
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.picLoadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.articulBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.supplierBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBox = new System.Windows.Forms.ComboBox();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.NumericUpDown();
            this.discountBox = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(311, 364);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // picLoadButton
            // 
            this.picLoadButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.picLoadButton.Location = new System.Drawing.Point(59, 393);
            this.picLoadButton.Name = "picLoadButton";
            this.picLoadButton.Size = new System.Drawing.Size(137, 23);
            this.picLoadButton.TabIndex = 1;
            this.picLoadButton.Text = "Загрузить изображение";
            this.picLoadButton.UseVisualStyleBackColor = false;
            this.picLoadButton.Click += new System.EventHandler(this.picLoadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Артикул:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Единица измерения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Поставщик:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Категория:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Описание:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Производитель:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Количество на складе:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Действующая скидка:";
            // 
            // articulBox
            // 
            this.articulBox.Location = new System.Drawing.Point(487, 9);
            this.articulBox.Name = "articulBox";
            this.articulBox.Size = new System.Drawing.Size(128, 20);
            this.articulBox.TabIndex = 12;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(487, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(128, 20);
            this.nameBox.TabIndex = 13;
            // 
            // supplierBox
            // 
            this.supplierBox.Location = new System.Drawing.Point(487, 242);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(128, 20);
            this.supplierBox.TabIndex = 14;
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Мужская обувь",
            "Женская обувь"});
            this.categoryBox.Location = new System.Drawing.Point(487, 69);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(128, 22);
            this.categoryBox.TabIndex = 15;
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerBox.FormattingEnabled = true;
            this.manufacturerBox.Location = new System.Drawing.Point(487, 216);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(128, 22);
            this.manufacturerBox.TabIndex = 16;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(487, 107);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(128, 96);
            this.descriptionBox.TabIndex = 17;
            this.descriptionBox.Text = "";
            // 
            // priceBox
            // 
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Location = new System.Drawing.Point(487, 271);
            this.priceBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(128, 20);
            this.priceBox.TabIndex = 18;
            // 
            // unitBox
            // 
            this.unitBox.Location = new System.Drawing.Point(487, 300);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(128, 20);
            this.unitBox.TabIndex = 19;
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(487, 329);
            this.countBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(128, 20);
            this.countBox.TabIndex = 20;
            // 
            // discountBox
            // 
            this.discountBox.Location = new System.Drawing.Point(487, 360);
            this.discountBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(128, 20);
            this.discountBox.TabIndex = 21;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.saveButton.Location = new System.Drawing.Point(509, 393);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cancelButton.Location = new System.Drawing.Point(319, 393);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 424);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.discountBox);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.supplierBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.articulBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLoadButton);
            this.Controls.Add(this.picBox);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddOrEditForm";
            this.Text = "AddOrEditForm";
            this.Load += new System.EventHandler(this.AddOrEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button picLoadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox articulBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox supplierBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.ComboBox manufacturerBox;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.NumericUpDown countBox;
        private System.Windows.Forms.NumericUpDown discountBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}