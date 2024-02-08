namespace Task3;

internal class Program
{
    static void Main()
    {
        Car<IStartable> electroCar = new Car<IStartable>(new ElectroEngine());
        Car<IStartable> dieselCar = new Car<IStartable>(new DieselEngine());
        Car<IStartable> gasCar = new Car<IStartable>(new GasEngine());

        electroCar.StartCar();
        dieselCar.StartCar();
        gasCar.StartCar();

        electroCar.MoveCar();
        dieselCar.StopCar();
        gasCar.TurnRight();
        dieselCar.TurnLeft();
    }
}