namespace Task3;

public class Car<T> where T : IStartable
{
    public T engine;

    public Car(T engine)
    {
        this.engine = engine;
    }

    public void StartCar()
    {
        this.engine.Start();
    }
    public void MoveCar() { this.engine.Move(); }
    public void StopCar() {  this.engine.Stop(); }
    public void TurnRight() { this.engine.Right(); }
    public void TurnLeft() {  this.engine.Left(); }
}
