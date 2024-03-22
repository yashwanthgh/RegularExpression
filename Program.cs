using RegularExpression;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter your email: ");
        string? email = Console.ReadLine();
        Console.WriteLine("Enter your phone number: ");
        string? phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        string? password = Console.ReadLine();

        if (name != null && email != null && phoneNumber != null && password != null)
        {
            RegularExp.EnterName(name);
            RegularExp.EnterEmail(email);
            RegularExp.EnterPhoneNumber(phoneNumber);
            RegularExp.EnterPassword(password);
        }
    }
}