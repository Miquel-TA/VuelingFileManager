# VuelingFileManager

VuelingFileManager is a .NET-based system made by Miquel T, designed for managing student data in a format-agnostic manner. It allows the user to add students, export student data, import student data, and perform validation of user inputs. The main components of the system include:

- The presentation layer (`Form` class)
- The business logic layer (`StudentManager` class)
- The repository layer (`DataManager` class)
- The transversal / cross-cutting layer:
  - The model (`Student` class)
  - The utility functions for conversions (`Converters` class)
  - The utility functions for logging (`Logger` class)
  - The utility functions for system interactions (`SystemInteraction` class)
  - The utility functions for validation (`Validators` class)

Let's explore these classes and their functionality in detail.

## Presentation Layer

### Form

The `Form` class is the main UI of the application. It initializes the UI elements and provides handlers for various actions such as importing students, adding a new student, exporting students, and clearing student data. The form also has input validation and error highlighting features, ensuring that the user input is valid before performing actions.

- `formatInput`: A combo box for the user to select the file format (TXT, JSON, XML).
- `birthdayPrompt`, `namePrompt`, `surnamePrompt`, `formatPrompt`: Labels prompting the user to provide specific information.
- `nameInput`, `surnameInput`: Text boxes for the user to input the student's name and surname.
- `birthdayInput`: A date picker for the user to select the student's birthday.
- `addButton`, `exportButton`, `clearButton`, `importButton`: Buttons for various actions such as adding a student, exporting students, clearing the form, and importing students.
- `feedback`: A label used to provide feedback to the user, such as error messages or success notifications.

## Business Logic Layer

### StudentManager

`StudentManager` is responsible for handling the business logic related to students, such as adding a new student, exporting students, importing students, getting the count of students, and clearing students data.

## Repository Layer (Data Management)

### DataManager

`DataManager` is the class responsible for the import and export of students' data. It supports three formats: JSON, XML, and TXT. The `ExportStudents` method exports students' data based on the provided format. Conversely, the `ImportStudents` method imports data from a file, the format of which is deduced from the file's extension.

## Transversal / Cross-Cutting (Utility Classes)

### Student

`Student` is the model class inside the folder Models that represents a student. It includes properties such as `Id`, `Guid`, `Birthday`, `Age`, `Name`, and `Surname`. It also provides a constructor for initializing these properties, the  `Guid` and `Birthday` parameters are generated inside the constructor.

### Converters

`Converters` is a utility class that provides helper methods for common conversion tasks, such as calculating age from birthday.

### Logger

`Logger` is a simple utility for logging messages with different levels of severity: Info, Warning, Error, and Critical. The logs are stored in a file that is named with the current date and placed in a directory called "logs".

### SystemInteraction

`SystemInteraction` provides helper methods to open a file with the default system application and select a file using the system file dialog.

### Validators

The `Validators` class is a utility class which provides a set of functions to verify the validity of different types of data, such as verifying the format of the data, verifying a name string, and verifying a DateTime object.
