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
            clearButton.Text = "Clear";
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                feedback.Text = "";
                int studentCount = studentManager.GetStudentCount();
                string format = formatInput.SelectedItem.ToString();

                bool validFormat = VerifyExportFormat(format);
                if (validFormat && studentCount > 0)
                {
                    string exportPath = studentManager.ExportStudents(format);
                    if (exportPath != null)
                    {
                        feedback.Text = $"Exported to {format}.";
                    }
                    else
                    {
                        feedback.Text = $"Export failed.";
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                feedback.Text = "";
                DateTime birthday = birthdayInput.Value;
                string name = nameInput.Text;
                string surname = surnameInput.Text;

                bool validInputs = VerifyNewStudentValues(birthday, name, surname);
                if (validInputs)
                {
                    int studentId = studentManager.AddNewStudent(birthday, name, surname);
                    feedback.Text = $"Student {studentId} added.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                int studentsRemoved = studentManager.EmptyStudents();
                feedback.Text = $"{studentsRemoved} students cleared.";
            }
            catch (Exception ex)
            {

            }
        }

        private bool VerifyExportFormat(string format)
        {
            if (!Validators.VerifyFormat(format))
            {
                formatPrompt.ForeColor = Color.Red;
                feedback.Text = $"Please check the red fields.";
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerifyNewStudentValues(DateTime birthday, string name, string surname)
        {
            bool validInputs = true;
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
