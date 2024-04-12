namespace Finals_Project
{
    partial class Form_Account
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
            Title = new Label();
            label_Name = new Label();
            label_DateofBirth = new Label();
            label_Address = new Label();
            label_Phone = new Label();
            label_Email = new Label();
            textBox_Name = new TextBox();
            textBox_Address = new TextBox();
            textBox_Phone = new TextBox();
            textBox_Email = new TextBox();
            dateTimePicker_DateofBirth = new DateTimePicker();
            label_Gender = new Label();
            comboBox_Gender = new ComboBox();
            button_Confirm = new Button();
            button_Clear = new Button();
            button_Cancel = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(234, 26);
            Title.Name = "Title";
            Title.Size = new Size(259, 42);
            Title.TabIndex = 0;
            Title.Text = "Welcome\r\nEnter your Personal Information:";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Name.Location = new Point(26, 113);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(213, 21);
            label_Name.TabIndex = 1;
            label_Name.Text = "Name (First / Middle / Last):";
            // 
            // label_DateofBirth
            // 
            label_DateofBirth.AutoSize = true;
            label_DateofBirth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DateofBirth.Location = new Point(26, 142);
            label_DateofBirth.Name = "label_DateofBirth";
            label_DateofBirth.Size = new Size(107, 21);
            label_DateofBirth.TabIndex = 2;
            label_DateofBirth.Text = "Date of Birth:";
            // 
            // label_Address
            // 
            label_Address.AutoSize = true;
            label_Address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Address.Location = new Point(26, 200);
            label_Address.Name = "label_Address";
            label_Address.Size = new Size(411, 21);
            label_Address.TabIndex = 3;
            label_Address.Text = "Home Address (District / City / Province / Postal Code):";
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Phone.Location = new Point(26, 229);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(125, 21);
            label_Phone.TabIndex = 4;
            label_Phone.Text = "Phone Number:";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Email.Location = new Point(26, 258);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(116, 21);
            label_Email.TabIndex = 5;
            label_Email.Text = "Email Address:";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(469, 113);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(200, 23);
            textBox_Name.TabIndex = 6;
            textBox_Name.TextChanged += textBox_Name_TextChanged;
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(469, 200);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(300, 23);
            textBox_Address.TabIndex = 7;
            textBox_Address.TextChanged += textBox_Address_TextChanged;
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(469, 229);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(200, 23);
            textBox_Phone.TabIndex = 8;
            textBox_Phone.TextChanged += textBox_Phone_TextChanged;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(469, 258);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(200, 23);
            textBox_Email.TabIndex = 9;
            textBox_Email.TextChanged += textBox_Email_TextChanged;
            // 
            // dateTimePicker_DateofBirth
            // 
            dateTimePicker_DateofBirth.Location = new Point(469, 142);
            dateTimePicker_DateofBirth.Name = "dateTimePicker_DateofBirth";
            dateTimePicker_DateofBirth.Size = new Size(200, 23);
            dateTimePicker_DateofBirth.TabIndex = 10;
            dateTimePicker_DateofBirth.ValueChanged += dateTimePicker_DateofBirth_ValueChanged;
            // 
            // label_Gender
            // 
            label_Gender.AutoSize = true;
            label_Gender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Gender.Location = new Point(26, 171);
            label_Gender.Name = "label_Gender";
            label_Gender.Size = new Size(69, 21);
            label_Gender.TabIndex = 11;
            label_Gender.Text = "Gender:";
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Items.AddRange(new object[] { "Male", "Female" });
            comboBox_Gender.Location = new Point(469, 171);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(121, 23);
            comboBox_Gender.TabIndex = 12;
            comboBox_Gender.SelectedIndexChanged += comboBox_Gender_SelectedIndexChanged;
            // 
            // button_Confirm
            // 
            button_Confirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Confirm.Location = new Point(469, 331);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(75, 23);
            button_Confirm.TabIndex = 13;
            button_Confirm.Text = "Confirm";
            button_Confirm.UseVisualStyleBackColor = true;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // button_Clear
            // 
            button_Clear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.Location = new Point(351, 331);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(75, 23);
            button_Clear.TabIndex = 14;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Cancel.Location = new Point(234, 331);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 15;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // Form_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Cancel);
            Controls.Add(button_Clear);
            Controls.Add(button_Confirm);
            Controls.Add(comboBox_Gender);
            Controls.Add(label_Gender);
            Controls.Add(dateTimePicker_DateofBirth);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Phone);
            Controls.Add(textBox_Address);
            Controls.Add(textBox_Name);
            Controls.Add(label_Email);
            Controls.Add(label_Phone);
            Controls.Add(label_Address);
            Controls.Add(label_DateofBirth);
            Controls.Add(label_Name);
            Controls.Add(Title);
            Name = "Form_Account";
            Text = "Account Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label_Name;
        private Label label_DateofBirth;
        private Label label_Address;
        private Label label_Phone;
        private Label label_Email;
        private TextBox textBox_Name;
        private TextBox textBox_Address;
        private TextBox textBox_Phone;
        private TextBox textBox_Email;
        private DateTimePicker dateTimePicker_DateofBirth;
        private Label label_Gender;
        private ComboBox comboBox_Gender;
        private Button button_Confirm;
        private Button button_Clear;
        private Button button_Cancel;
    }
}
