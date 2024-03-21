namespace Prog_1_W24_Final_SalvadorAre

{
    using System;

    internal class Program
    {
        static string[] studentNames = { "Alice", "Bob", "Charlie", "David", "Eva" }; 

        static int[] studentGrades = { 85, 92, 78, 88, 90 };
        static void Main(string[] args)
        {
            bool exit = false; 

            
            while (!exit)
            {
                
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Display all names, grades, and letter grades");
                Console.WriteLine("2. Display average grade and letter grade");
                Console.WriteLine("3. Change a grade");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine(); 
                switch (choice)
                {
                    case "1":
                        DisplayAll();
                        break;
                    case "2":
                        DisplayAverageAndLetterGrade();
                        break;
                    case "3":
                        ChangeGrade();
                        break;
                    case "4":
                        exit = true; 
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                        break;
                }
            }
        }
                                             // A way to display all students names grades 
        static void DisplayAll()
        {
            Console.WriteLine("Student Names, Grades, and Letter Grades:");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{studentNames[i]} - {studentGrades[i]} ({GetLetterGrade(studentGrades[i])})");
            }
            Console.WriteLine();
        }
        static void DisplayAverageAndLetterGrade()
        {
            double average = CalculateAverageGrade();
            Console.WriteLine($"Average Grade: {average:F2} ({GetLetterGrade((int)average)})");
            Console.WriteLine();
        }
        static void ChangeGrade()
        {
            Console.WriteLine("Change a Grade:");
            Console.WriteLine("Enter the index of the student whose grade you want to change:");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{i}: {studentNames[i]}");
            }
            Console.Write("Enter the index of the student: ");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= studentGrades.Length)
            {
                Console.WriteLine("Invalid index. Please enter a number between 0 and 4.");
                Console.Write("Enter the index of the student: ");
            }
            Console.Write($"Enter the new grade for {studentNames[index]}: ");
            int newGrade;
            while (!int.TryParse(Console.ReadLine(), out newGrade))
            {
                Console.WriteLine("Invalid grade. Please enter a valid integer grade.");
                Console.Write($"Enter the new grade for {studentNames[index]}: ");
            }
            studentGrades[index] = newGrade;
            Console.WriteLine($"Grade for {studentNames[index]} updated successfully.");
            Console.WriteLine();
        }
        static double CalculateAverageGrade()
        {
            int sum = 0;
            foreach (int grade in studentGrades)
            {
                sum += grade;
            }
            return (double)sum / studentGrades.Length;
        }
        static char GetLetterGrade(int grade)
        {
            if (grade >= 90)
                return 'A';
            else if (grade >= 80)
                return 'B';
            else if (grade >= 70)
                return 'C';
            else if (grade >= 60)
                return 'D';
            else
                return 'F';
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string? ToString()
        {
            return base.ToString();
        }
    }



}
