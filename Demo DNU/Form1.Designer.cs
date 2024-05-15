namespace Demo_DNU
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
            btn_payment = new Button();
            txt_amount = new TextBox();
            txt_months = new TextBox();
            btn_connection = new Button();
            btn_connect = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_payment
            // 
            btn_payment.Location = new Point(431, 100);
            btn_payment.Name = "btn_payment";
            btn_payment.Size = new Size(110, 42);
            btn_payment.TabIndex = 0;
            btn_payment.Text = "Procesar Pago";
            btn_payment.UseVisualStyleBackColor = true;
            btn_payment.Click += button1_Click;
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(197, 86);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(206, 23);
            txt_amount.TabIndex = 1;
            // 
            // txt_months
            // 
            txt_months.Location = new Point(197, 130);
            txt_months.Name = "txt_months";
            txt_months.Size = new Size(206, 23);
            txt_months.TabIndex = 2;
            // 
            // btn_connection
            // 
            btn_connection.Location = new Point(431, 55);
            btn_connection.Name = "btn_connection";
            btn_connection.Size = new Size(110, 39);
            btn_connection.TabIndex = 5;
            btn_connection.Text = "Conectar Terminal";
            btn_connection.UseVisualStyleBackColor = true;
            btn_connection.Click += button2_Click;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(434, 149);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(107, 43);
            btn_connect.TabIndex = 6;
            btn_connect.Text = "Generar/Renovar licencia";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 61);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 112);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 8;
            label2.Text = "Months";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 511);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_connect);
            Controls.Add(btn_connection);
            Controls.Add(txt_months);
            Controls.Add(txt_amount);
            Controls.Add(btn_payment);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn_payment;
        private TextBox txt_amount;
        private TextBox txt_months;
        private Button btn_connection;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button btn_connect;
        private Label label1;
        private Label label2;
    }
}
