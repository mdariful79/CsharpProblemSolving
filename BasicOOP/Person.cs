using System.Globalization;

class Person
{
    private string firstName; //field or variable
    public string LastName { get; set; } // auto-implemented property

    public string FirstName // property
    {
        get 
        {
            if (string.IsNullOrEmpty(firstName))
            {
                return string.Empty;

            }
            return firstName; 
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                firstName = value;

            }
        } 
    }
 
    public Person() // Empty constructor
    {
        firstName = string.Empty;
        LastName = string.Empty;

    }
    public Person(string fName, string lName) // Perameterized constructor
    {
        firstName = fName;
        LastName = lName;
    }
 
    public string GetName(string seperator) // method   
    {
        string fullName = firstName + seperator + LastName;
        return fullName;
    }
    public string GetName(string[] seperator) // method overloading 
    {
        string fullName = firstName + seperator[0] + LastName;
        return fullName;
    }
}

