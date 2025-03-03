using System.Security.Cryptography.X509Certificates;

namespace EXAM_C__
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //BankAccount ba = new BankAccount();
            //ba.Deposit(10000, 5000);
            //ba.Withdraw(2000, 1500);
            //Book b = new Book();
            //Book b1 = new Book("Harry Potter", "J.K.Rowling");
            //Book b2 = new Book("Harry Potter", "J.K.Rowling", "abc124");

            //Circle c = new Circle();
            //c.radius = 5;
            //c.CalArea();

            //Vehicle v = new Bike();
            //v.Start();

            //Person p = new Teacher();
            //((Teacher)p).t_id = 1;
            //((Teacher)p).t_name = "Devika";
            //p.Getdetails();

            //Calculator c = new Calculator();
            //c.Add(2, 3);
            //c.Add(12, 13,15);
            //c.Add(1900000000, 2323400000);

            //VideoPlayer vp = new VideoPlayer();                           
            //vp.Play();                                                  
            //Admin a = new Admin("Devika");                                
            //Customer c = new Customer("Priyal");                         
            //a.AccessControl();                                            //17 pending
            //c.AccessControl();                                            //18

            //ComplexNumber n1 = new ComplexNumber(1,2);                    //19
            //ComplexNumber n2 = new ComplexNumber(3, 4);
            //ComplexNumber ans = n1 + n2;
            //Console.WriteLine("Sum: " + ans);

            //Bank account1 = new Bank(1000);

            //Console.WriteLine("Initial Interest Rate:");
            //account1.DisplayAccountInfo();

            //Bank.SetInterestRate(3);

            //Console.WriteLine("\nAfter Updating Interest Rate:");
            //account1.DisplayAccountInfo();

            //SecuritySystem ss = new SecuritySystem();
            //ss.display();

            //VehicleFactory car = TypeOfVehicle.Typev("car");
            //Console.WriteLine(car.Vehicletype());
            //VehicleFactory bike = TypeOfVehicle.Typev("bike");
            //Console.WriteLine(bike.Vehicletype());

            //double totalAmount = 10000;

            //ShoppingCart cart1 = new ShoppingCart(DiscountMethods.NoDiscount);
            //Console.WriteLine("No Discount: " + cart1.CalculateTotal(totalAmount));

            //ShoppingCart cart2 = new ShoppingCart(DiscountMethods.PercentageDiscount);
            //Console.WriteLine("10% Discount: " + cart2.CalculateTotal(totalAmount));

            //ShoppingCart cart3 = new ShoppingCart(DiscountMethods.FixedAmountDiscount);
            //Console.WriteLine("Flat ₹200 Discount: " + cart3.CalculateTotal(totalAmount));

            //Report report = new Report("hello , this is a report");

            //report.Print(); 
            //report.SaveToFile("report.txt");

            Manager m = new Manager("devika");
            Manager shallowCopy = m.ShallowCopy();
            Manager deepCopy = m.DeepCopy();
            m.Name = "abc";
            Console.WriteLine("Original Manager: " + m.Name);
            Console.WriteLine("Shallow Copy Manager: " + shallowCopy.Name);
            Console.WriteLine("Deep Copy Manager: " + deepCopy.Name);

            //Button b = new Button();
            //b.OnCLick += ButtonClicked;
            //b.ClickButton();
            //static void ButtonClicked()
            //{
            //    Console.WriteLine("Button is CLicked");
            //}








        }

    }

}
