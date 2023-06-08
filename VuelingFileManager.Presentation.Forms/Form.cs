using System;
using System.Collections.Generic;
using System.Drawing;
using VuelingFileManager.Business.Logic;
using VuelingFileManager.Transversal.Utilities;

namespace VuelingFileManager.Presentation.Form
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly int minimumStudentAge = 18;
        private readonly StudentManager studentManager = new StudentManager();

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                birthdayInput.MinDate = DateTime.Now.AddYears(-120);
                birthdayInput.MaxDate = DateTime.Now.AddYears(-minimumStudentAge);
                birthdayPrompt.Text = "Birthday";
                namePrompt.Text = "Name";
                surnamePrompt.Text = "Surname";
                formatPrompt.Text = "Save format";
                feedback.Text = "";
                formatInput.DataSource = new List<string> { "TXT", "JSON", "XML" };
                addButton.Text = "Add";
                exportButton.Text = "Save";
                clearButton.Text = "Clear";
                importButton.Text = "Import";
                AutoSave.Text = "Auto Save";
                Logger.Log("UI initialized.", Logger.Severity.Info);
            } catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.Severity.Critical);
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                feedback.Text = "";
                int studentCount = studentManager.GetStudentCount();
                var format = formatInput.SelectedItem;

                bool validInputs = VerifyExportInputs(format, studentCount);

                if (validInputs)
                {
                    string exportPath = studentManager.ExportStudents(format.ToString());
                    feedback.Text = exportPath;
                    Logger.Log($"Exported {studentCount} students to {exportPath}.", Logger.Severity.Info);
                }
            } catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.Severity.Critical);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                feedback.Text = "";
                DateTime birthday = birthdayInput.Value;
                string name = nameInput.Text;
                string surname = surnameInput.Text;

                bool validInputs = VerifyStudentInputs(birthday, name, surname);
                if (validInputs)
                {
                    int studentId = studentManager.AddNewStudent(birthday, name, surname);
                    feedback.Text = $"Student {studentId} added.";
                    Logger.Log($"Student {studentId} added.", Logger.Severity.Info);
                }

                if (AutoSave.Checked)
                {
                    ExportButton_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.Severity.Critical);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                int studentsRemoved = studentManager.EmptyStudents();
                feedback.Text = $"{studentsRemoved} students cleared.";
                Logger.Log($"{studentsRemoved} students cleared.", Logger.Severity.Info);

                if (AutoSave.Checked)
                {
                    ExportButton_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.Severity.Critical);
            }
        }


        private void ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedImportFile = SystemInteraction.SelectFile();

                if (selectedImportFile != null)
                {
                    studentManager.ImportStudents(selectedImportFile);

                    int studentCount = studentManager.GetStudentCount();
                    Logger.Log($"Imported {studentCount} students from {selectedImportFile}.", Logger.Severity.Info);
                    feedback.Text = $"{studentCount} students loaded.";
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.Severity.Critical);
            }
        }

        private bool VerifyExportInputs(object format, int studentCount)
        {
            if (studentCount > 0)
            {
                if (format != null)
                {
                    if (Validators.VerifyFormat(format.ToString()))
                    {
                        return true;
                    }
                    else
                    {
                        formatPrompt.ForeColor = Color.Red;
                        feedback.Text = $"Please check the red fields.";
                        Logger.Log($"Format {format} is not valid for export.", Logger.Severity.Info);
                        return false;
                    }
                }
                else
                {
                    formatPrompt.ForeColor = Color.Red;
                    feedback.Text = $"Please check the red fields.";
                    Logger.Log($"Format is null, thus not valid for export.", Logger.Severity.Info);
                    return false;
                }
            }
            else
            {
                feedback.Text = $"There are no students to export.";
                Logger.Log($"StudentCount {studentCount} is not valid for export.", Logger.Severity.Info);
                return false;
            }
        }

        private bool VerifyStudentInputs(DateTime birthday, string name, string surname)
        {
            bool validInputs = true;
            birthdayPrompt.ForeColor = Color.Black;
            namePrompt.ForeColor = Color.Black;
            surnamePrompt.ForeColor = Color.Black;

            if (!Validators.VerifyDateTime(birthday, minimumStudentAge))
            {
                validInputs = false;
                birthdayPrompt.ForeColor = Color.Red;
                Logger.Log($"Birthday {birthday} not valid.", Logger.Severity.Info);
            }
            if (!Validators.VerifyName(name))
            {
                validInputs = false;
                namePrompt.ForeColor = Color.Red;
                Logger.Log($"Name {name} not valid.", Logger.Severity.Info);
            }
            if (!Validators.VerifyName(surname))
            {
                validInputs = false;
                surnamePrompt.ForeColor = Color.Red;
                Logger.Log($"Surname {surname} not valid.", Logger.Severity.Info);
            }

            if (!validInputs)
            {
                feedback.Text = "Please check the red fields.";
            }

            return validInputs;
        }
    }
}
