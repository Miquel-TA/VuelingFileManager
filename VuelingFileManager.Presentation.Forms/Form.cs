using System;
using System.Drawing;
using VuelingFileManager.Business.Logic;
using VuelingFileManager.Transversal.Utilities;
using VuelingFileManager.Transversal.Utilities.Models;

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
                birthdayDatePicker.MinDate = DateTime.Now.AddYears(-120);
                birthdayDatePicker.MaxDate = DateTime.Now.AddYears(-minimumStudentAge);
                BirthdayLabel.Text = "Birthday";
                NameLabel.Text = "Name";
                SurnameLabel.Text = "Surname";
                FileFormatLabel.Text = "Save format";
                FeedbackLabel.Text = "";
                FileFormatCombobox.DataSource = Enum.GetValues(typeof(FileType));
                AddUserToFileButton.Text = "Add";
                CreateCopyButton.Text = "Save";
                EmptyFileButton.Text = "Clear";
                ImportFileButton.Text = "Import";
                AutoSave.Text = "Auto Save";
                Logger.Log("UI initialized.", Logger.Severity.Info);
            } catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.Severity.Critical);
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                FeedbackLabel.Text = "";

                object unsafeFileFormat = FileFormatCombobox.SelectedItem;

                VerifyFormatAndSaveFile(unsafeFileFormat);

            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.Severity.Critical);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                FeedbackLabel.Text = "";

                DateTime birthday = birthdayDatePicker.Value;
                string name = nameInput.Text;
                string surname = surnameInput.Text;
                int studentId = studentManager.GetStudentCount();

                Student newStudent = new Student(studentId, birthday, name, surname);
                bool success = VerifyAndAddStudent(newStudent);

                if (AutoSave.Checked)
                {
                    SaveFileButton_Click(sender, e);
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
                FeedbackLabel.Text = $"{studentsRemoved} students cleared.";
                Logger.Log($"{studentsRemoved} students cleared.", Logger.Severity.Info);

                if (AutoSave.Checked)
                {
                    SaveFileButton_Click(sender, e);
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
                    FeedbackLabel.Text = $"{studentCount} students loaded.";
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.Severity.Critical);
            }
        }

        private void VerifyFormatAndSaveFile(object unsafeFileFormat)
        {
            if (Validators.VerifyFormat(unsafeFileFormat))
            {
                FileType fileType = (FileType)unsafeFileFormat;
                string exportPath = studentManager.ExportStudents(fileType);
                int studentCount = studentManager.GetStudentCount();

                //FeedbackLabel.Text = $"Exported to {exportPath}.";
                Logger.Log($"Exported {studentCount} students to {exportPath}.", Logger.Severity.Info);
            }
            else
            {
                FileFormatLabel.ForeColor = Color.Red;
                FeedbackLabel.Text = $"Please check the red fields.";
                Logger.Log($"Format is not valid for export.", Logger.Severity.Info);
            }
        }

        private bool VerifyAndAddStudent(Student newStudent)
        {
            bool validInputs = true;
            BirthdayLabel.ForeColor = Color.Black;
            NameLabel.ForeColor = Color.Black;
            SurnameLabel.ForeColor = Color.Black;

            if (!Validators.VerifyDateTime(newStudent.Birthday, minimumStudentAge))
            {
                validInputs = false;
                BirthdayLabel.ForeColor = Color.Red;
                Logger.Log($"Birthday {newStudent.Birthday} not valid.", Logger.Severity.Info);
            }
            if (!Validators.VerifyName(newStudent.Name))
            {
                validInputs = false;
                NameLabel.ForeColor = Color.Red;
                Logger.Log($"Name {newStudent.Name} not valid.", Logger.Severity.Info);
            }
            if (!Validators.VerifyName(newStudent.Surname))
            {
                validInputs = false;
                SurnameLabel.ForeColor = Color.Red;
                Logger.Log($"Surname {newStudent.Surname} not valid.", Logger.Severity.Info);
            }

            if (validInputs)
            {
                studentManager.AddNewStudent(newStudent);
                FeedbackLabel.Text = $"Student {newStudent.Id} added.";
                Logger.Log($"Student {newStudent.Guid} added.", Logger.Severity.Info);
                return true;
            } else
            {
                FeedbackLabel.Text = "Please check the red fields.";
                return false;
            }
        }
    }
}
