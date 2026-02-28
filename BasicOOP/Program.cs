using System;

Person person = new Person();
person.firstName = "Ariful";
person.lastName = "Islam";
Console.WriteLine(person.GetName(","));

Person person2 = new Person();
person2.firstName = "Abdur";
person2.lastName = "Rahman";
string name = person2.GetName("&&");
Console.WriteLine(name);

Person person3 = new Person("1st Constructor", "used Here");
person3.firstName = "Ami 1st Constructor";
Person person4 = new Person("2nd Constructor", "used Here");
Console.WriteLine(person3.GetName("??"));
Console.WriteLine(person4.GetName("**"));