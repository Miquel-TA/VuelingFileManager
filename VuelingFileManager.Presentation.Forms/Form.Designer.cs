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
            this.formatInput = new System.Windows.Forms.ComboBox();
            this.birthdayPrompt = new System.Windows.Forms.Label();
            this.namePrompt = new System.Windows.Forms.Label();
            this.surnamePrompt = new System.Windows.Forms.Label();
            this.formatPrompt = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.birthdayInput = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formatInput
            // 
            this.formatInput.Font = new System.Drawing.Font("Arial", 10.2F);
            this.formatInput.FormattingEnabled = true;
            this.formatInput.Location = new System.Drawing.Point(278, 202);
            this.formatInput.Name = "formatInput";
            this.formatInput.Size = new System.Drawing.Size(92, 27);
            this.formatInput.TabIndex = 0;
            // 
            // birthdayPrompt
            // 
            this.birthdayPrompt.AutoSize = true;
            this.birthdayPrompt.Font = new System.Drawing.Font("Arial", 10.2F);
            this.birthdayPrompt.Location = new System.Drawing.Point(32, 28);
            this.birthdayPrompt.Name = "birthdayPrompt";
            this.birthdayPrompt.Size = new System.Drawing.Size(51, 19);
            this.birthdayPrompt.TabIndex = 1;
            this.birthdayPrompt.Text = "label1";
            // 
            // namePrompt
            // 
            this.namePrompt.AutoSize = true;
            this.namePrompt.Font = new System.Drawing.Font("Arial", 10.2F);
            this.namePrompt.Location = new System.Drawing.Point(32, 73);
            this.namePrompt.Name = "namePrompt";
            this.namePrompt.Size = new System.Drawing.Size(51, 19);
            this.namePrompt.TabIndex = 2;
            this.namePrompt.Text = "label2";
            // 
            // surnamePrompt
            // 
            this.surnamePrompt.AutoSize = true;
            this.surnamePrompt.Font = new System.Drawing.Font("Arial", 10.2F);
            this.surnamePrompt.Location = new System.Drawing.Point(32, 118);
            this.surnamePrompt.Name = "surnamePrompt";
            this.surnamePrompt.Size = new System.Drawing.Size(51, 19);
            this.surnamePrompt.TabIndex = 3;
            this.surnamePrompt.Text = "label3";
            // 
            // formatPrompt
            // 
            this.formatPrompt.AutoSize = true;
            this.formatPrompt.Font = new System.Drawing.Font("Arial", 10.2F);
            this.formatPrompt.Location = new System.Drawing.Point(278, 180);
            this.formatPrompt.Name = "formatPrompt";
            this.formatPrompt.Size = new System.Drawing.Size(51, 19);
            this.formatPrompt.TabIndex = 4;
            this.formatPrompt.Text = "label4";
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
            // birthdayInput
            // 
            this.birthdayInput.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayInput.Location = new System.Drawing.Point(130, 28);
            this.birthdayInput.Name = "birthdayInput";
            this.birthdayInput.Size = new System.Drawing.Size(183, 27);
            this.birthdayInput.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.addButton.Location = new System.Drawing.Point(12, 235);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 28);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "button1";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.exportButton.Location = new System.Drawing.Point(278, 235);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(94, 28);
            this.exportButton.TabIndex = 9;
            this.exportButton.Text = "button2";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // feedback
            // 
            this.feedback.AutoSize = true;
            this.feedback.Location = new System.Drawing.Point(13, 213);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(51, 19);
            this.feedback.TabIndex = 10;
            this.feedback.Text = "label5";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 275);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.birthdayInput);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.formatPrompt);
            this.Controls.Add(this.surnamePrompt);
            this.Controls.Add(this.namePrompt);
            this.Controls.Add(this.birthdayPrompt);
            this.Controls.Add(this.formatInput);
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

        private System.Windows.Forms.ComboBox formatInput;
        private System.Windows.Forms.Label birthdayPrompt;
        private System.Windows.Forms.Label namePrompt;
        private System.Windows.Forms.Label surnamePrompt;
        private System.Windows.Forms.Label formatPrompt;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.DateTimePicker birthdayInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label feedback;
    }
}

