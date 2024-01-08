namespace ClassesHW;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the exercise number.");

        int num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                Task1 task1 = new Task1();
                task1.Execute();
                break;
            case 2:
                Task2 task2 = new Task2();
                task2.Execute();
                break;
            case 3:
                Task3 task3 = new Task3();
                task3.Execute();
                break;
            case 4:
                Task4 task4 = new Task4();
                task4.Execute();
                break;
            default:
                Console.WriteLine("There is no such task");
                break;
        }
    }
}