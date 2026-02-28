using System.Globalization;

class Person
{
    public string firstName; //field or variable
    public string lastName;

    public Person() // Empty constructor
    {
        firstName = string.Empty;
        lastName = string.Empty;

    }
    public Person(string fName, string lName) // Perameterized constructor
    {
        firstName = fName;
        lastName = lName;
    }
 
    public string GetName(string seperator) // method   
    {
        string fullName = firstName + seperator + lastName;
        return fullName;
    }
}

