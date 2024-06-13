//int count = 0;
//object locker = new();
//Mutex mutex = new();
//AutoResetEvent waitHandler = new AutoResetEvent(true);

for (int i = 0; i < 10; i++)
{
    Car car = new(i + 1);
}
    


class Car
{
    static Semaphore semaphore = new(4, 4);
    Thread carThread;
    int count = 5;
    static Random random = new Random();

    public Car(int id)
    {
        carThread = new(Parking);
        carThread.Name = $"Car {id}";
        carThread.Start();
    }

    public void Parking()
    {
        while(count > 0)
        {
            semaphore.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name} IN parking");

            Thread.Sleep(random.Next(100, 200));

            Console.WriteLine($"{Thread.CurrentThread.Name} OUT parking");
            semaphore.Release();

            count--;
            Thread.Sleep(random.Next(200, 300));
        }
    }
}

