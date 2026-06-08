namespace DemoForm
{
    partial class OrderCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.articulLabel = new System.Windows.Forms.Label();
            this.pickupAddressLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.delieveryDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // articulLabel
            // 
            this.articulLabel.AutoSize = true;
            this.articulLabel.Location = new System.Drawing.Point(16, 14);
            this.articulLabel.Name = "articulLabel";
            this.articulLabel.Size = new System.Drawing.Size(34, 14);
            this.articulLabel.TabIndex = 0;
            this.articulLabel.Text = "label1";
            // 
            // pickupAddressLabel
            // 
            this.pickupAddressLabel.AutoSize = true;
            this.pickupAddressLabel.Location = new System.Drawing.Point(16, 67);
            this.pickupAddressLabel.Name = "pickupAddressLabel";
            this.pickupAddressLabel.Size = new System.Drawing.Size(34, 14);
            this.pickupAddressLabel.TabIndex = 1;
            this.pickupAddressLabel.Text = "label1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(16, 40);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(34, 14);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "label1";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(16, 95);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(34, 14);
            this.orderDateLabel.TabIndex = 3;
            this.orderDateLabel.Text = "label1";
            // 
            // delieveryDateLabel
            // 
            this.delieveryDateLabel.AutoSize = true;
            this.delieveryDateLabel.Location = new System.Drawing.Point(393, 55);
            this.delieveryDateLabel.Name = "delieveryDateLabel";
            this.delieveryDateLabel.Size = new System.Drawing.Size(34, 14);
            this.delieveryDateLabel.TabIndex = 4;
            this.delieveryDateLabel.Text = "label1";
            // 
            // OrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.Controls.Add(this.delieveryDateLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pickupAddressLabel);
            this.Controls.Add(this.articulLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "OrderCard";
            this.Size = new System.Drawing.Size(467, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label articulLabel;
        private System.Windows.Forms.Label pickupAddressLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label delieveryDateLabel;
    }
}
