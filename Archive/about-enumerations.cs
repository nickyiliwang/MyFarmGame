// # In C#, Enums (short for enumerations) are a distinct data type that allows you to define a set of named constants. Enums are used to represent a finite set of values, such as days of the week, months of the year, or different states of an object.

// # Enums provide a way to assign meaningful names to numeric values and make your code more readable and self-explanatory. With enums, you can refer to these named constants instead of using magic numbers or string literals in your code, which improves maintainability.

// # Here's an example of how you can define and use an enum in C#:

// # Diff
// # Copy
// # Insert
// # New
enum DaysOfWeek // Define an enum called DaysOfWeek
{
    Monday, // Each constant value is automatically assigned an integer starting from 0
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class Program
{
    public static void Main()
    {
        DaysOfWeek today = DaysOfWeek.Monday; // Declare a variable of the DaysOfWeek enum type

        if (today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday)
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }
    }
}

// # In this example, we defined an enum called DaysOfWeek with seven constants representing each day of the week. We declared a variable today of the DaysOfWeek enum type and assigned it the value DaysOfWeek.Monday. Based on the value of today, we printed a corresponding message.

// # Enums are often used in switch statements, as they provide a clear and concise way to handle different cases based on specific values.
