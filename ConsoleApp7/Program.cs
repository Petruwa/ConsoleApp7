using System;

class HospitalWorker
{
    public string Position { get; set; }
    public int Age { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Nurse : HospitalWorker
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Nurse:");
        base.DisplayInfo();
    }
}

class Surgeon : HospitalWorker
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Surgeon:");
        base.DisplayInfo();
    }
}

class Program
{
    static void Main()
    {
        HospitalWorker[] workers = new HospitalWorker[4];

        workers[0] = new HospitalWorker { Position = "General Hospital Worker", Age = 25 };
        workers[1] = new Nurse { Position = "RN Nurse", Age = 30 };
        workers[2] = new Surgeon { Position = "Orthopedic Surgeon", Age = 40 };
        workers[3] = new Nurse { Position = "LPN Nurse", Age = 27 };

        foreach (var worker in workers)
        {
            worker.DisplayInfo();
            Console.WriteLine();
        }
    }
}