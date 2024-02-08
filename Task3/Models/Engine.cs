namespace Task3;

public abstract class Engine : IStartable
{
    public abstract void Start();
    public abstract void Move();
    public abstract void Stop();
    public abstract void Right();
    public abstract void Left();
}
