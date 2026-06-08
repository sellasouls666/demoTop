namespace DemoForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.productsNameList = new System.Windows.Forms.ListBox();
            this.fioLabel = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upScaleCountButton = new System.Windows.Forms.Button();
            this.downScaleCountButton = new System.Windows.Forms.Button();
            this.filtrBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.productCard = new DemoForm.ProductCard();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productsNameList
            // 
            this.productsNameList.Dock = System.Windows.Forms.DockStyle.Left;
            this.productsNameList.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsNameList.FormattingEnabled = true;
            this.productsNameList.ItemHeight = 14;
            this.productsNameList.Location = new System.Drawing.Point(0, 0);
            this.productsNameList.Name = "productsNameList";
            this.productsNameList.Size = new System.Drawing.Size(120, 405);
            this.productsNameList.TabIndex = 0;
            this.productsNameList.SelectedIndexChanged += new System.EventHandler(this.productsNameList_SelectedIndexChanged);
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.fioLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(1345, 0);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(34, 14);
            this.fioLabel.TabIndex = 2;
            this.fioLabel.Text = "label1";
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(1086, 52);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(281, 340);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 3;
            this.iconBox.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(192, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(165, 20);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск:";
            // 
            // upScaleCountButton
            // 
            this.upScaleCountButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.upScaleCountButton.Location = new System.Drawing.Point(394, 0);
            this.upScaleCountButton.Name = "upScaleCountButton";
            this.upScaleCountButton.Size = new System.Drawing.Size(114, 46);
            this.upScaleCountButton.TabIndex = 6;
            this.upScaleCountButton.Text = "По возрастанию количества на складе";
            this.upScaleCountButton.UseVisualStyleBackColor = false;
            this.upScaleCountButton.Click += new System.EventHandler(this.upScaleCountButton_Click);
            // 
            // downScaleCountButton
            // 
            this.downScaleCountButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.downScaleCountButton.Location = new System.Drawing.Point(544, 0);
            this.downScaleCountButton.Name = "downScaleCountButton";
            this.downScaleCountButton.Size = new System.Drawing.Size(114, 46);
            this.downScaleCountButton.TabIndex = 7;
            this.downScaleCountButton.Text = "По убыванию количества на складе";
            this.downScaleCountButton.UseVisualStyleBackColor = false;
            this.downScaleCountButton.Click += new System.EventHandler(this.downScaleCountButton_Click);
            // 
            // filtrBox
            // 
            this.filtrBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrBox.FormattingEnabled = true;
            this.filtrBox.Location = new System.Drawing.Point(683, 12);
            this.filtrBox.Name = "filtrBox";
            this.filtrBox.Size = new System.Drawing.Size(121, 22);
            this.filtrBox.TabIndex = 8;
            this.filtrBox.SelectedIndexChanged += new System.EventHandler(this.filtrBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.addButton.Location = new System.Drawing.Point(828, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 35);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить товар";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productCard
            // 
            this.productCard.BackColor = System.Drawing.Color.Chartreuse;
            this.productCard.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCard.Location = new System.Drawing.Point(125, 52);
            this.productCard.Name = "productCard";
            this.productCard.Size = new System.Drawing.Size(944, 340);
            this.productCard.TabIndex = 1;
            this.productCard.DoubleClick += new System.EventHandler(this.productCard_DoubleClick);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.deleteButton.Location = new System.Drawing.Point(939, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 35);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Удалить товар";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ordersButton.Location = new System.Drawing.Point(1050, 5);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(96, 35);
            this.ordersButton.TabIndex = 11;
            this.ordersButton.Text = "Заказы";
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 405);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.filtrBox);
            this.Controls.Add(this.downScaleCountButton);
            this.Controls.Add(this.upScaleCountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.productCard);
            this.Controls.Add(this.productsNameList);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productsNameList;
        private ProductCard productCard;
        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upScaleCountButton;
        private System.Windows.Forms.Button downScaleCountButton;
        private System.Windows.Forms.ComboBox filtrBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button ordersButton;
    }
}

