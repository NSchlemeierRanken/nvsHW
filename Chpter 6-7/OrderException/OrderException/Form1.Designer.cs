namespace OrderException
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtItemNumber = new TextBox();
            txtQuantity = new TextBox();
            txtDeliveryDays = new TextBox();
            btnValidate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 54);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Item Number [ 100, 999]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 136);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity [ 1, 12]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 195);
            label3.Name = "label3";
            label3.Size = new Size(173, 15);
            label3.TabIndex = 2;
            label3.Text = "Estimated Delivery Days [ 1, 30 ]";
            // 
            // txtItemNumber
            // 
            txtItemNumber.Location = new Point(273, 54);
            txtItemNumber.Name = "txtItemNumber";
            txtItemNumber.Size = new Size(100, 23);
            txtItemNumber.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(273, 136);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 4;
            // 
            // txtDeliveryDays
            // 
            txtDeliveryDays.Location = new Point(273, 195);
            txtDeliveryDays.Name = "txtDeliveryDays";
            txtDeliveryDays.Size = new Size(100, 23);
            txtDeliveryDays.TabIndex = 5;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(273, 264);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(100, 23);
            btnValidate.TabIndex = 6;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(273, 310);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(273, 360);
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
            lblMessage.Location = new Point(44, 318);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 395);
            Controls.Add(lblMessage);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnValidate);
            Controls.Add(txtDeliveryDays);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Order Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtItemNumber;
        private TextBox txtQuantity;
        private TextBox txtDeliveryDays;
        private Button btnValidate;
        private Button btnClear;
        private Button btnExit;
        private Label lblMessage;
    }
}
