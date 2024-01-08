// See https://aka.ms/new-console-template for more information



namespace LearningCSharp
{
public class Person 
{
 private string _firstName;
 private string _lastName;

public Person(string firstName, string lastName ) 
{
    // (this) is optional
    this._firstName = firstName;
    this._lastName = lastName;
}

 public void GreetPerson()
 {
    Console.WriteLine($"Welcome to {this._firstName} {this._lastName}");
 }

// Method overloading
 public void GreetPerson(string userName)
 {
    Console.WriteLine($"Welcome to {userName}");
 }

public static void Message()
{
    // Person person = new Person("Khaalid", "Alharagsaawi");
    // person.GreetPerson();
    Console.WriteLine("Static Method belong to the Class");
    Console.WriteLine("Non-Static Method belong to the instance of Class");

}

 }

 public class Calculate 
    {
        // Method Signature
        // Method Without Return Type
        public void Add(int number1, int number2)
        {
            // Method Implementation
            int result = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {result}");
        }

        public void Subtract(int number1, int number2)
        {
            // Multiply(2, 3);
            int result = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {result}");
        }

        public void Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {result}");
        }

        public void Devide(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine($"{number1} / {number2} = {result}");
        }
    }

    public class Sum 
    {
        public int AddTwo(int number1, int number2)
        {
            // int result = number1 + number2;
            // return result;
            return number1 + number2; 
        }
    }

    public class Student
    {
        public int StudentId;
        public string studentName;
        public int studentAge;
        public string studentAddress;

    }
}
