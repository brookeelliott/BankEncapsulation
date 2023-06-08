namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to make a deposit?");
            Console.WriteLine("Enter Any key to continue, enter 'no' to cancel");
            var startBool = Console.ReadLine();


            if (startBool != "no")
            {
                Console.WriteLine("Please enter deposit amount.");


                BankAccount banking = new BankAccount();

                banking.depositAmount = Convert.ToDouble(Console.ReadLine());

                banking.Deposit(banking.depositAmount);

                Console.WriteLine("Your New Balance is:");
                banking.GetBalance();
            }

            Console.WriteLine("Have a great day!");



            
        }
    }
}
