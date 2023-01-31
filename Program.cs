namespace Class02
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "courseData.txt";
            string choice;
            do
            {
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // logic to read
                    StreamReader sr = new StreamReader(file);

                    sr.ReadLine(); // read in the header and throw it away
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        string[] arr = line.Split('|');

                        Console.WriteLine($"Course: {arr[0]}, Grade {arr[1]}");
                    }

                    List<string> myWatchers = new List<string>();
                    myWatchers.Add("Bob");
                    myWatchers.Add("Pete");

                    var watchersArr = myWatchers.ToArray();

                    sr.Close(); // always close!
                }
                else if (choice == "2")
                {
                    // logic to write
                    StreamWriter sw = new StreamWriter(file, true);

                    Console.WriteLine("Enter a course (Y/N)?");
                    string resp = Console.ReadLine().ToUpper();
                    if (resp != "Y") { break; }

                    Console.WriteLine("Enter the course name.");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the course grade.");
                    string grade = Console.ReadLine().ToUpper();

                    sw.WriteLine($"{name}|{grade}");

                    sw.Close(); // always close!
                }
            } while (choice == "1" || choice == "2");
        }
    }
}