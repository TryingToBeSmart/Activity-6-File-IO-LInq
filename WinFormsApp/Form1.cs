using ClassLibrary1;
namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        List<Person> personList = new List<Person>();
        BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            SetBindings();
        }


        private void SetBindings()
        {
            bindingSource.DataSource = personList;
            listBox1.DataSource = bindingSource;
            listBox1.DisplayMember = "AllInfo";
        }

        //update what is in the listbox
        private void UpdateBindings()
        {
            bindingSource.ResetBindings(false);
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            //check textboxes are filled out
            if (FirstNameTextBox.Text.Length <= 0 || LastNameTextBox.Text.Length <= 0 || URLTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Fill out text boxes");
            }

            //create person, add them to the list, and display them in the listbox
            else
            {
                personList.Add(new Person(FirstNameTextBox.Text, LastNameTextBox.Text, URLTextBox.Text));
                UpdateBindings();
            }
        }

        //SaveFileDialog info from: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text | *.txt";
            saveFileDialog1.Title = "Save list to file";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                //create list for saving to file
                List<string> outputList = new List<string>();

                //add all persons to the output list
                foreach (var person in personList) { outputList.Add(person.AllInfo); }

                //save to file
                File.WriteAllLines(saveFileDialog1.FileName, outputList);

            }
        }

        //open file dialog and read from file into the listbox
        //from: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-7.0
        private void LoadFromFileButton_Click(object sender, EventArgs e)
        {
            List<String> lines = new List<string>();
            var filePath = string.Empty;
            //string fileContent = string.Empty; //this is for the StreamReader way that I'm not using

            //new file dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                //when the ok button is selected on the openFiledDialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file and add each line of text to the lines list
                    filePath = openFileDialog.FileName;
                    lines = File.ReadAllLines(filePath).ToList();

                    //this below is a different way for me to refer to later
                    ////Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = File.ReadToEnd(reader);
                    //}
                }
            }

            //now use the file text to construct Persons
            int lineNumber = 0;
            foreach (string line in lines)
            {
                //split each item by spaces
                string[] entries = line.Split(' ');

                //challenge 1: check input to ensure each line has 3 items
                if (entries.Length == 3)
                {
                    //construct new Person object using the entries array
                    Person person = new Person();
                    person.firstName = entries[0];
                    person.lastName = entries[1];
                    person.Url = entries[2];

                    //add Person to list
                    personList.Add(person);
                }

                //else not correct Person format
                else
                    MessageBox.Show($"Entry #{lineNumber} is not in the correct format: FirstName LastName Website");

                lineNumber++;
            }
            //update the listbox
            UpdateBindings();
        }
    }
}