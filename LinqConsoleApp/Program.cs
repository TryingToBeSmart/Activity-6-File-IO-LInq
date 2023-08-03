using LinqConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        //test scores
        int[] scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };

        //print scores
        foreach (int score in scores)
        {
            Console.WriteLine($"Score: {score}");
        }
        Console.WriteLine();

        //use LINQ statement to filter list
        var honorRoll =
            from score in scores
            where score > 90
            select score;

        //print honorRoll scores
        foreach (var score in honorRoll)
        {
            Console.WriteLine($"Honor Roll score: {score}");
        }
        Console.WriteLine();

        //sort the results
        var sortedScores =
            from score in scores
            orderby score
            select score;

        //print sorted list
        foreach (var score in sortedScores)
        {
            Console.WriteLine($"Sorted Score: {score}");
        }
        Console.WriteLine();

        //Challenge 1: print only B students in ascending order
        var bStudents =
            from score in scores
            where (score >= 80 && score < 90)
            orderby score
            select score;

        foreach (var score in bStudents)
        {
            Console.WriteLine($"B Scores: {score}");
        }
        Console.WriteLine();

        //Challenge 2: creaet a2.	Create an arraylist of students and
        //demonstrate the use of LINQ on the new list. Each student object
        //should have at least three properties: name, age, and grade.
        //Add the iComparable implementation to the Student class and
        //create a compareTo() method in the student class in order to be
        //able to sort the list.

        //create some students
        List<Student> studentList = new List<Student>
        {
            new Student("Alice", 10, 90),
            new Student("Beth", 15, 80),
            new Student("Bob", 10, 95),
            new Student("Chuck", 18, 78),
            new Student("Dan", 15, 98),
            new Student("Ed", 10, 70),
            new Student("Fred", 16, 88),
            new Student("Sally", 10, 95),
            new Student("Tina", 15, 90)
        };

        //display all students
        foreach (var student in studentList)
        {
            Console.WriteLine(student.Display()); 
        }
        Console.WriteLine();

        //sort students by grade; using Lambda
        var sortedStudentsByGrade = studentList.OrderBy(student => student);
        //same as Query
            //from student in studentList
            //orderby student
            //select student;

        //display sorted students
        foreach (var student in sortedStudentsByGrade)
        {
            Console.WriteLine(student.Display());
        }
        Console.WriteLine();

        //sort students by age older than 15; using Lambda
        var olderStudents = sortedStudentsByGrade.Where(student => student.Age > 15).OrderBy(student => student.Age);
        //Same using Query
            //from student in sortedStudentsByGrade
            //where student.Age > 15
            //orderby student.Age
            //select student;

        //display sorted students
        foreach (var student in olderStudents)
        {
            Console.WriteLine(student.Display());
        }
    }
}


