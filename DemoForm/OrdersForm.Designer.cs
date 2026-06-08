namespace DemoForm
{
    partial class OrdersForm
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
            this.ordersIdsBox = new System.Windows.Forms.ListBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.orderCard = new DemoForm.OrderCard();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ordersIdsBox
            // 
            this.ordersIdsBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ordersIdsBox.FormattingEnabled = true;
            this.ordersIdsBox.ItemHeight = 14;
            this.ordersIdsBox.Location = new System.Drawing.Point(0, 0);
            this.ordersIdsBox.Name = "ordersIdsBox";
            this.ordersIdsBox.Size = new System.Drawing.Size(120, 175);
            this.ordersIdsBox.TabIndex = 0;
            this.ordersIdsBox.SelectedIndexChanged += new System.EventHandler(this.ordersIdsBox_SelectedIndexChanged);
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.addOrderButton.Location = new System.Drawing.Point(135, 4);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(103, 23);
            this.addOrderButton.TabIndex = 2;
            this.addOrderButton.Text = "Добавить заказ";
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // orderCard
            // 
            this.orderCard.BackColor = System.Drawing.Color.Chartreuse;
            this.orderCard.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderCard.Location = new System.Drawing.Point(135, 33);
            this.orderCard.Name = "orderCard";
            this.orderCard.Size = new System.Drawing.Size(467, 130);
            this.orderCard.TabIndex = 1;
            this.orderCard.DoubleClick += new System.EventHandler(this.orderCard_DoubleClick);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.deleteOrderButton.Location = new System.Drawing.Point(256, 4);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(103, 23);
            this.deleteOrderButton.TabIndex = 3;
            this.deleteOrderButton.Text = "Удалить заказ";
            this.deleteOrderButton.UseVisualStyleBackColor = false;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 175);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.orderCard);
            this.Controls.Add(this.ordersIdsBox);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ordersIdsBox;
        private OrderCard orderCard;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
    }
}