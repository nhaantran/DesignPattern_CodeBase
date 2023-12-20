namespace DesignPattern_Example.Command__COR_Homework;

public interface IDriver
{
    public IDriver NextDriver { get; set; }
    public bool Response();
    public void SetNextDriver(IDriver driver);
}

public class Driver : IDriver
{
    public string Name { get; set; }
    public Guid Id { get; set; }
    public IDriver NextDriver { get; set; }

    public Driver(string name, Guid id)
    {
        Name = name;
        Id = id;
    }

    public bool Response()
    {
        var rand = new Random();
        if (rand.Next(5) <= 3) // random response time
        {
            var response = rand.NextDouble() > 0.5;
            if (response)
            {
                Console.WriteLine($"Driver {Name} accept");
                return true;
            }
        }
        Thread.Sleep(3000);
        return NextDriver.Response();
    }

    public void SetNextDriver(IDriver driver)
    {
        NextDriver = driver;
    }
}

public static class DriverSystem
{
    public static Driver NewDriver(string name)
    {
        return new Driver(name, new Guid());
    }

    public static List<Driver> SetChainForDriver(List<Driver> drivers) 
    {
        var listOfDrivers = drivers.ToList();

        for(int i=0; i<listOfDrivers.Count-1;i++)
        {
            listOfDrivers[i].SetNextDriver(listOfDrivers[i+1]);
        }
        return listOfDrivers;
    }
}
