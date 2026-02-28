using System;

Person person = new Person();
person.FirstName = "Ariful";
person.LastName = "Islam";
Console.WriteLine(person.GetName(","));

Person person2 = new Person();
person2.FirstName = "Abdur";
person2.LastName = "Rahman";
string name = person2.GetName("&&");
Console.WriteLine(name);

Person person3 = new Person("1st Constructor", "used Here");
person3.FirstName = "Ami 1st Constructor";
Person person4 = new Person("2nd Constructor", "used Here");
Console.WriteLine(person3.GetName("??"));
Console.WriteLine(person4.GetName("**"));

Person person5 = new Person("Arbin", "");
person5.LastName = "Islam";
Console.WriteLine(person5.GetName(new string[] {"arr1","arr2","arr3"})); // used method overloading with array as parameter

Person person6 = new Person("Zakir", "Khan");
person6.FirstName = "";
person6.LastName = "Mia";
Console.WriteLine(person6.GetName("&&")); // used property setter validation for empty first name