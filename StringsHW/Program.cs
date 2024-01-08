using StringsHW;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the exercise number.");
        int num = Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case 1:
                Exersice1 exersice1 = new Exersice1();
                exersice1.Execute();
                break;
            case 2:
                Exersice2 exersice2 = new Exersice2();
                exersice2.Execute();
                break;
            case 3:
                Exersice3 exersice3 = new Exersice3();
                exersice3.Execute();
                break;
            case 4:
                Exersice4 exersice4 = new Exersice4();
                exersice4.Execute();
                break;
            case 5:
                Exercise5 exercise5 = new Exercise5();
                exercise5.Execute();
                break;
            case 6:
                Exersice6 exersice6 = new Exersice6();
                exersice6.Execute();
                break;
            case 7:
                Exersice7 exersice7 = new Exersice7();
                exersice7.Execute();
                break;
            default:
                Console.WriteLine("There is no such exercise.");
                break;
        }
    }
}