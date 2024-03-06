namespace AES_Sifvravimas
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
            txtBoxText = new TextBox();
            label3 = new Label();
            txtBoxResult = new TextBox();
            comboBoxMode = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            comboBox = new ComboBox();
            label5 = new Label();
            txtBoxKey = new TextBox();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(32, 81, 159);
            label1.Location = new Point(59, 101);
            label1.Name = "label1";
            label1.Size = new Size(159, 30);
            label1.TabIndex = 0;
            label1.Text = "Įveskite tekstą:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label2.ForeColor = Color.FromArgb(32, 81, 159);
            label2.Location = new Point(162, 46);
            label2.Name = "label2";
            label2.Size = new Size(233, 40);
            label2.TabIndex = 1;
            label2.Text = "AES šifvravimas";
            // 
            // txtBoxText
            // 
            txtBoxText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtBoxText.Location = new Point(59, 134);
            txtBoxText.Multiline = true;
            txtBoxText.Name = "txtBoxText";
            txtBoxText.Size = new Size(209, 162);
            txtBoxText.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(32, 81, 159);
            label3.Location = new Point(59, 444);
            label3.Name = "label3";
            label3.Size = new Size(183, 30);
            label3.TabIndex = 3;
            label3.Text = "Pasirinkite modą:";
            // 
            // txtBoxResult
            // 
            txtBoxResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtBoxResult.Location = new Point(332, 134);
            txtBoxResult.Multiline = true;
            txtBoxResult.Name = "txtBoxResult";
            txtBoxResult.ReadOnly = true;
            txtBoxResult.Size = new Size(456, 233);
            txtBoxResult.TabIndex = 4;
            // 
            // comboBoxMode
            // 
            comboBoxMode.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            comboBoxMode.FormattingEnabled = true;
            comboBoxMode.Items.AddRange(new object[] { "ECB", "CBC", "CFB" });
            comboBoxMode.Location = new Point(59, 477);
            comboBoxMode.Name = "comboBoxMode";
            comboBoxMode.Size = new Size(209, 38);
            comboBoxMode.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(32, 81, 159);
            label4.Location = new Point(332, 101);
            label4.Name = "label4";
            label4.Size = new Size(187, 30);
            label4.TabIndex = 6;
            label4.Text = "Gautas rezultatas:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(32, 81, 159);
            button1.Location = new Point(59, 533);
            button1.Name = "button1";
            button1.Size = new Size(209, 88);
            button1.TabIndex = 7;
            button1.Text = "Pradėti";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox
            // 
            comboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Užsifruoti", "Dešifruoti" });
            comboBox.Location = new Point(59, 403);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(209, 38);
            comboBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(32, 81, 159);
            label5.Location = new Point(59, 370);
            label5.Name = "label5";
            label5.Size = new Size(225, 30);
            label5.TabIndex = 8;
            label5.Text = "Užsifruoti / dešifruoti";
            // 
            // txtBoxKey
            // 
            txtBoxKey.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtBoxKey.Location = new Point(59, 332);
            txtBoxKey.MaxLength = 16;
            txtBoxKey.Name = "txtBoxKey";
            txtBoxKey.Size = new Size(209, 35);
            txtBoxKey.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(32, 81, 159);
            label6.Location = new Point(59, 299);
            label6.Name = "label6";
            label6.Size = new Size(150, 30);
            label6.TabIndex = 10;
            label6.Text = "Įveskite raktą:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(32, 81, 159);
            button2.Location = new Point(620, 370);
            button2.Name = "button2";
            button2.Size = new Size(168, 50);
            button2.TabIndex = 12;
            button2.Text = "Išsaugoti failę";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 223, 244);
            ClientSize = new Size(800, 653);
            Controls.Add(button2);
            Controls.Add(txtBoxKey);
            Controls.Add(label6);
            Controls.Add(comboBox);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(comboBoxMode);
            Controls.Add(txtBoxResult);
            Controls.Add(label3);
            Controls.Add(txtBoxText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxText;
        private Label label3;
        private TextBox txtBoxResult;
        private Label label4;
        private Button button1;
        private Label label5;
        private TextBox txtBoxKey;
        private Label label6;
        private Button button2;
        private ComboBox comboBoxMode;
        private ComboBox comboBox;
    }
}
