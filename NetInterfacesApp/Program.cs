Car bmv = new Car();
bmv.Move();

IMovable movable = new Car();
movable.Move();

Car taxi = new Taxi();
taxi.Move();


interface IMovable
{
    // methods, properties, indexces, events, static fields, const fields
    const int speedMax = 200;
    static int speedMin = 0;

    void Move()
    {
        Console.WriteLine("Object move");
    }

    string Speed { set; get; }

    delegate void SpeedHandler(object sender, EventArgs e);
    event SpeedHandler MoveEvent;
}

interface INovable3d : IMovable
{

}

class Car : IMovable
{
    public string Speed { get; set; }

    public event IMovable.SpeedHandler MoveEvent;

    public virtual void Move()
    {
        Console.WriteLine("Car move");
    }
}

class Taxi : Car
{
    public override void Move()
    {
        Console.WriteLine("Taxi move");
    }
}

class Messanger<T> where T: IMessage
{
    T message;

    public Messanger(T message)
    { 
        this.message = message; 
    }

    public void Send()
    {
        Console.WriteLine($"Send: {message.Text}");
    }
}

class Passport : IDocumnet<int>
{
    public int Series { get; set; }
    public int Number { get; set; }
}

class OtherDocumnet<T> : IDocumnet<T>
{
    public T Series { get; set; }
    public int Number { get; set; }
}

interface IMessage
{
    public string Text { set; get; }
}

interface IDocumnet<T>
{
    T Series { set; get; }
    int Number {  set; get; }
}