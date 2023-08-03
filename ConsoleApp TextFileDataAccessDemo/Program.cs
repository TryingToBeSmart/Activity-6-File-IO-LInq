using ClassLibrary1;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\jjk14\OneDrive - Grand Canyon University\GCU\CST-250\Week 6\Activity 6 File IO LInq\test.txt";
        //List<String> lines = File.ReadAllLines(filePath).ToList();


        //foreach (String line in lines)
        //{
        //    Console.WriteLine(line);
        //}

        //why this?  Doesn't seem needed.
        //File.WriteAllLines(filePath, lines);

        List<Person> personList = new List<Person>();
        List<String> lines = File.ReadAllLines(filePath).ToList();

        //add incorrect line type for testing
        lines.Add("SteveJobs www.apple.com");

        int lineNumber = 0; 
        foreach (string line in lines)
        {
            //split each item by spaces
            string[] entries = line.Split(' '); 

            //challenge 1: check input to ensure each line has 3 items
            //this is one way: if(entries.Length == 3 ) construct the Person
            //another way:
            try
            {
                //construct new Person object using the entries array
                Person person = new Person();
                person.firstName = entries[0];
                person.lastName = entries[1];
                person.Url = entries[2];

                //add Person to list
                personList.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Line {lineNumber} is not the correct format:  FirstName LastName Website");
            }
            lineNumber++;

        }
        
        //used to save to file
        List<string> outputLines = new List<string>();

        //print list of people
        foreach (var person in personList)
        {
            //print to console
            Console.WriteLine($"{person.firstName} {person.lastName} {person.Url}");

            //add for file output
            outputLines.Add($"{person.firstName} {person.lastName} {person.Url}\n");
        }

        //write to another file
        string outPath = @"C:\Users\jjk14\OneDrive - Grand Canyon University\GCU\CST-250\Week 6\Activity 6 File IO LInq\output_test.txt";
        File.WriteAllLines(outPath, outputLines);

        Console.ReadLine();
    }
}

