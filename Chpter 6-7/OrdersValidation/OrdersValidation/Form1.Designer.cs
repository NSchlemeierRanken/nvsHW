namespace OrdersValidation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtItemNumber = new TextBox();
            txtQuantity = new TextBox();
            txtDeliveryDays = new TextBox();
            lblItemNumber = new Label();
            lblQuantity = new Label();
            lblDeliveryDays = new Label();
            btnValidate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // txtItemNumber
            // 
            txtItemNumber.Location = new Point(351, 34);
            txtItemNumber.Name = "txtItemNumber";
            txtItemNumber.Size = new Size(100, 23);
            txtItemNumber.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(351, 104);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 1;
            // 
            // txtDeliveryDays
            // 
            txtDeliveryDays.Location = new Point(351, 176);
            txtDeliveryDays.Name = "txtDeliveryDays";
            txtDeliveryDays.Size = new Size(100, 23);
            txtDeliveryDays.TabIndex = 2;
            // 
            // lblItemNumber
            // 
            lblItemNumber.AutoSize = true;
            lblItemNumber.Location = new Point(12, 42);
            lblItemNumber.Name = "lblItemNumber";
            lblItemNumber.Size = new Size(137, 15);
            lblItemNumber.TabIndex = 3;
            lblItemNumber.Text = "Item Number [ 100, 999 ]";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 112);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(94, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity [ 1, 12 ]";
            // 
            // lblDeliveryDays
            // 
            lblDeliveryDays.AutoSize = true;
            lblDeliveryDays.Location = new Point(12, 184);
            lblDeliveryDays.Name = "lblDeliveryDays";
            lblDeliveryDays.Size = new Size(170, 15);
            lblDeliveryDays.TabIndex = 5;
            lblDeliveryDays.Text = "Estimated Delivery Days [ 1, 30]";
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(351, 235);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(100, 23);
            btnValidate.TabIndex = 6;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(351, 279);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(351, 322);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(73, 322);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 373);
            Controls.Add(lblMessage);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnValidate);
            Controls.Add(lblDeliveryDays);
            Controls.Add(lblQuantity);
            Controls.Add(lblItemNumber);
            Controls.Add(txtDeliveryDays);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemNumber);
            Name = "Form1";
            Text = "Order Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItemNumber;
        private TextBox txtQuantity;
        private TextBox txtDeliveryDays;
        private Label lblItemNumber;
        private Label lblQuantity;
        private Label lblDeliveryDays;
        private Button btnValidate;
        private Button btnClear;
        private Button btnExit;
        private Label lblMessage;
    }
}
