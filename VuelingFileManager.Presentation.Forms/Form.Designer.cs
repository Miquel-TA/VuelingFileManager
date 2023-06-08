namespace VuelingFileManager.Presentation.Form
{
    partial class Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileFormatCombobox = new System.Windows.Forms.ComboBox();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.FileFormatLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.birthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddUserToFileButton = new System.Windows.Forms.Button();
            this.CreateCopyButton = new System.Windows.Forms.Button();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.EmptyFileButton = new System.Windows.Forms.Button();
            this.ImportFileButton = new System.Windows.Forms.Button();
            this.AutoSave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FileFormatCombobox
            // 
            this.FileFormatCombobox.Font = new System.Drawing.Font("Arial", 10.2F);
            this.FileFormatCombobox.FormattingEnabled = true;
            this.FileFormatCombobox.Location = new System.Drawing.Point(278, 202);
            this.FileFormatCombobox.Name = "formatInput";
            this.FileFormatCombobox.Size = new System.Drawing.Size(92, 27);
            this.FileFormatCombobox.TabIndex = 0;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.BirthdayLabel.Location = new System.Drawing.Point(32, 28);
            this.BirthdayLabel.Name = "birthdayPrompt";
            this.BirthdayLabel.Size = new System.Drawing.Size(51, 19);
            this.BirthdayLabel.TabIndex = 1;
            this.BirthdayLabel.Text = "label1";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.NameLabel.Location = new System.Drawing.Point(32, 73);
            this.NameLabel.Name = "namePrompt";
            this.NameLabel.Size = new System.Drawing.Size(51, 19);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "label2";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.SurnameLabel.Location = new System.Drawing.Point(32, 118);
            this.SurnameLabel.Name = "surnamePrompt";
            this.SurnameLabel.Size = new System.Drawing.Size(51, 19);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "label3";
            // 
            // FileFormatLabel
            // 
            this.FileFormatLabel.AutoSize = true;
            this.FileFormatLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.FileFormatLabel.Location = new System.Drawing.Point(278, 180);
            this.FileFormatLabel.Name = "formatPrompt";
            this.FileFormatLabel.Size = new System.Drawing.Size(51, 19);
            this.FileFormatLabel.TabIndex = 4;
            this.FileFormatLabel.Text = "label4";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Arial", 10.2F);
            this.nameInput.Location = new System.Drawing.Point(130, 73);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(183, 27);
            this.nameInput.TabIndex = 5;
            // 
            // surnameInput
            // 
            this.surnameInput.Font = new System.Drawing.Font("Arial", 10.2F);
            this.surnameInput.Location = new System.Drawing.Point(130, 118);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(183, 27);
            this.surnameInput.TabIndex = 6;
            // 
            // birthdayDatePicker
            // 
            this.birthdayDatePicker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayDatePicker.Location = new System.Drawing.Point(130, 28);
            this.birthdayDatePicker.Name = "birthdayInput";
            this.birthdayDatePicker.Size = new System.Drawing.Size(183, 27);
            this.birthdayDatePicker.TabIndex = 7;
            // 
            // AddUserToFileButton
            // 
            this.AddUserToFileButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.AddUserToFileButton.Location = new System.Drawing.Point(12, 235);
            this.AddUserToFileButton.Name = "addButton";
            this.AddUserToFileButton.Size = new System.Drawing.Size(94, 28);
            this.AddUserToFileButton.TabIndex = 8;
            this.AddUserToFileButton.Text = "button1";
            this.AddUserToFileButton.UseVisualStyleBackColor = true;
            this.AddUserToFileButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CreateCopyButton
            // 
            this.CreateCopyButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.CreateCopyButton.Location = new System.Drawing.Point(278, 235);
            this.CreateCopyButton.Name = "exportButton";
            this.CreateCopyButton.Size = new System.Drawing.Size(94, 28);
            this.CreateCopyButton.TabIndex = 9;
            this.CreateCopyButton.Text = "button2";
            this.CreateCopyButton.UseVisualStyleBackColor = true;
            this.CreateCopyButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(32, 159);
            this.FeedbackLabel.Name = "feedback";
            this.FeedbackLabel.Size = new System.Drawing.Size(51, 19);
            this.FeedbackLabel.TabIndex = 10;
            this.FeedbackLabel.Text = "label5";
            // 
            // EmptyFileButton
            // 
            this.EmptyFileButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.EmptyFileButton.Location = new System.Drawing.Point(148, 235);
            this.EmptyFileButton.Name = "clearButton";
            this.EmptyFileButton.Size = new System.Drawing.Size(94, 28);
            this.EmptyFileButton.TabIndex = 11;
            this.EmptyFileButton.Text = "button3";
            this.EmptyFileButton.UseVisualStyleBackColor = true;
            this.EmptyFileButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ImportFileButton
            // 
            this.ImportFileButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ImportFileButton.Location = new System.Drawing.Point(12, 200);
            this.ImportFileButton.Name = "importButton";
            this.ImportFileButton.Size = new System.Drawing.Size(94, 28);
            this.ImportFileButton.TabIndex = 12;
            this.ImportFileButton.Text = "button4";
            this.ImportFileButton.UseVisualStyleBackColor = true;
            this.ImportFileButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // AutoSave
            // 
            this.AutoSave.AutoSize = true;
            this.AutoSave.Checked = true;
            this.AutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSave.Location = new System.Drawing.Point(155, 202);
            this.AutoSave.Name = "AutoSave";
            this.AutoSave.Size = new System.Drawing.Size(114, 23);
            this.AutoSave.TabIndex = 13;
            this.AutoSave.Text = "CheckBox1";
            this.AutoSave.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 275);
            this.Controls.Add(this.AutoSave);
            this.Controls.Add(this.ImportFileButton);
            this.Controls.Add(this.EmptyFileButton);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.CreateCopyButton);
            this.Controls.Add(this.AddUserToFileButton);
            this.Controls.Add(this.birthdayDatePicker);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.FileFormatLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.FileFormatCombobox);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "VuelingFileManager";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FileFormatCombobox;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label FileFormatLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.DateTimePicker birthdayDatePicker;
        private System.Windows.Forms.Button AddUserToFileButton;
        private System.Windows.Forms.Button CreateCopyButton;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Button EmptyFileButton;
        private System.Windows.Forms.Button ImportFileButton;
        private System.Windows.Forms.CheckBox AutoSave;
    }
}

