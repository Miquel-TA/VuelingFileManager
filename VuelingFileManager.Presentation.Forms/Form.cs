using System;
using System.Collections.Generic;
using System.Drawing;
using VuelingFileManager.Business.Logic;
using VuelingFileManager.Transversal.Utilities;

namespace VuelingFileManager.Presentation.Form
{
    public partial class Form : System.Windows.Forms.Form
    {

        private readonly StudentManager studentManager = new StudentManager();

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            birthdayInput.MinDate = DateTime.Now.AddYears(-120);
            birthdayInput.MaxDate = DateTime.Now.AddYears(-18);
            birthdayPrompt.Text = "Birthday";
            namePrompt.Text = "Name";
            surnamePrompt.Text = "Surname";
            formatPrompt.Text = "Export format";
            feedback.Text = "";
            formatInput.DataSource = new List<string> { "TXT", "JSON", "XML" };
            addButton.Text = "Add";
            exportButton.Text = "Export";
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime birthday = birthdayInput.Value;
            string name = nameInput.Text;
            string surname = surnameInput.Text;

            bool validInputs = ValidateInputs(birthday, name, surname);

            if (validInputs)
            {
                int studentId = studentManager.AddNewStudent(birthday, name, surname);
                feedback.Text = $"Student {studentId} added.";
            }
        }
        private bool ValidateInputs(DateTime birthday, string name, string surname)
        {
            bool validInputs = true;
            feedback.Text = "";
            birthdayPrompt.ForeColor = Color.Black;
            namePrompt.ForeColor = Color.Black;
            surnamePrompt.ForeColor = Color.Black;

            if (!Validators.VerifyDateTime(birthday))
            {
                validInputs = false;
                birthdayPrompt.ForeColor = Color.Red;
            }
            if (!Validators.VerifyName(name))
            {
                validInputs = false;
                namePrompt.ForeColor = Color.Red;
            }
            if (!Validators.VerifyName(surname))
            {
                validInputs = false;
                surnamePrompt.ForeColor = Color.Red;
            }

            if (!validInputs)
            {
                feedback.Text = "Please check the red fields.";
            }

            return validInputs;

        }
    }
}
