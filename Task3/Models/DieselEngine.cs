namespace Task3
{
    public class DieselEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Дизельный врум");
        }
        public override void Move()
        {
            Console.WriteLine("Дизельное движение вперед");
        }
        public override void Stop()
        {
            Console.WriteLine("Дизельный стоп");
        }
        public override void Right()
        {
            Console.WriteLine("Дизельный поворот направо");
        }
        public override void Left()
        {
            Console.WriteLine("Дизельный поворот налево");
        }
    }
}
