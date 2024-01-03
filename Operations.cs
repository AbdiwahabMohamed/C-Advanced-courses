using LearningCSharp;

Person person1 = new Person("Khaalid", "Alharagsaawi"); // Default Constructor Method
Person.Message();
person1.GreetPerson();
person1.GreetPerson("Maimouna");

Calculate calculate = new();
calculate.Subtract(2, 4);
calculate.Multiply(3, 4);
calculate.Devide(6, 12);

Sum sum = new Sum();
int result = sum.AddTwo(9, 5);
sum.AddTwo(2,3);
Console.WriteLine(result);
Console.WriteLine(sum.AddTwo(2,3));

