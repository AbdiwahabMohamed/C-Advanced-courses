using LearningCSharp;

Person person1 = new Person();
person1.firstName = "Abdiwahab";
person1.lastName = "Mohamed";
Console.WriteLine($"Welcome {person1.firstName} {person1.lastName}");
person1.GreetPerson();

Person person2 = new Person();
person2.firstName = "Ali";
person2.lastName = "Faarax";
Console.WriteLine($"Welcome {person2.firstName} {person2.lastName}");
person2.GreetPerson();