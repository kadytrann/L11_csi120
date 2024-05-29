namespace L11_csi120
{
    internal class Program
    {

        string student1 = "Hoang";
        string student2 = "Vicky";

        static string[] firstNames = new string[4];
        static string[] lastNames = new string[4];
        // firstNames - Memory Address: 2000
        // type size: 16 | ----- |
        // stdeunts[0] : 2000 + (index * Type Size)
        // students[1] : 2000 + (1 * 16)

        // If you define an array with no values, it has default values
        // string: | "" | "" | "" | "" |
        // int: | 0 | 0 | 0 | 0 |
        // double: | 0.0 | 0.0 | 0.0 | 0.0 |
        // bool: | false | false | false | false |
        // object: | null | null | null | null |
        static void Main(string[] args)
        {

            Console.WriteLine("Kady Tran - 5/28/2024");

            // Call my preload method to populate my arrays
            Preload();

            Console.Write("Please enter a last name to search for: ");
            string studentToSearchFor = Console.ReadLine();
            int studentIndex = FindStudentIdByLastName(studentToSearchFor);

            if(studentIndex >= 0)
            {
                DisplayStudentInformation(studentIndex);
            }
            else
            {
                Console.WriteLine("That student is not enrolled in the class");
            }
            
            
            DisplayStudentInformation(studentIndex);

            if (EnrolledInClassByLastName(studentToSearchFor))
            {
                Console.WriteLine("Yes this student is in my class.");
            }
            else
            {
                Console.WriteLine("The student is not in my class.");
            }

            // .Length gives the size of the array 
            // DisplayAllStudents();
           
            
        } // End of main

        // Linear Search

        // Create a method that returns if a student is in the class
        // Return a bool
        public static bool EnrolledInClassByLastName(string studentsLastName) // <--- Search Key
        {
            for (int i = 0; i < lastNames.Length; i++)
            {
                // If the current value == the searchKey
                if (lastNames[i].ToLower() == studentsLastName.ToLower())
                {
                    // 1.
                    return true;
                    // 2.
                }
                // Do I need an else?
                // 3. Return False
                // return false;
                // ^ putting it here is a common error 

            } // end of for loop
            return false;
            // 4.
        } // EnrolledInClassByLastName

        public static int FindStudentIdByLastName(string studentLastName)
        {
            for (int i = 0; i < lastNames.Length; i++)
            {
                // If the current value == the searchKey
                if (lastNames[i].ToLower() == studentLastName.ToLower())
                {
                    // 1.
                    return i;
                    // 2.
                }
                // Do I need an else?
                // 3. Return False
                // return false;
                // ^ putting it here is a common error 

            } // end of for loop
            return -1; // -1 is to indicate that they're not a student
        }

        public static void DisplayStudentInformation(int studentIndex)
        {
            // Student ID
            Console.WriteLine($"Student ID: {studentIndex}");
            // Full Name
            Console.WriteLine($"Full Name: {FullName(studentIndex)}");
            // First Name
            Console.WriteLine($"First Name: {firstNames[studentIndex]}");
            // Last Name
            Console.WriteLine($"Last Name: {lastNames[studentIndex]}");
            // Grades

            Console.WriteLine();
        }

        // Display all students
        public static void DisplayAllStudents()
        {
            for (int i = 0; i < firstNames.Length; i++)
            {
                // string fullName = FullName(i);
                DisplayStudentInformation(i);
            }
        }

        // New Method : Return a full name
        // Triple Forward Slash /// defines a method in intellisense

        /// <summary>
        /// It will return a string of a student's full name
        /// </summary>
        /// <param name="studentIndex">Index of Student</param>
        public static string FullName(int studentIndex)
        {
            
            string firstName = firstNames[studentIndex];
            string lastName = lastNames[studentIndex];
            string fullName = $"{firstName} {lastName}";

            // I am returning the full name of the student outside of our method so we can work with it in other methods
            return fullName;
        }

        // Preload()
        public static void Preload()
        {
            firstNames[0] = "Hoang";
            firstNames[1] = "Vicky";
            firstNames[2] = "Brian";
            firstNames[3] = "Carla";

            lastNames[0] = "Nguyen";
            lastNames[1] = "Le";
            lastNames[2] = "Lee";
            lastNames[3] = "Baysinger";
        }

        // Display Full Name Method

        public static void Menu()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    SwitchExample();
                    break;
                case "2":

                    break;
            }
        }

        // Switches
        public static void SwitchExample()
        {
            // Switch is a decision structure that works on comparisons

            // Keywords
            // switch : defines our code block
            // case : defines an individual set of instructions
            // break : defines the end of those instructions
            // default : runs if no case runs ( like an else )
            Console.Write("Please enter an animal: ");
            string userAnimal = Console.ReadLine();

            // switch ( case ) <--- Not a condition : "cat == dog" - Don't put this
            switch (userAnimal)
            {
                // create our cases
                // you write case to define a new case followed by value comparing to
                // No curly braces
                // Usre a colon, :, instead
                // Followed by a break
                // Cases do not have their own scope
                case "dog":
                case "owl":
                    Console.WriteLine("bark");
                    break;
                case "cat":
                    Console.WriteLine("meow");
                    break;

                default:
                    Console.WriteLine("Please enter a valid animal");
                    break;
            }

        }// Switch example

        // Break Example
        public static void BreakExample()
        {
            // new keyword
            // break
            // break indicates that we want to jump OUT of the current code block 
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    // Once break is triggered
                    // It will jump out of our for loop 
                    break;
                }
            }
        } // Break Example

    } // End of class
} // End of namespace
