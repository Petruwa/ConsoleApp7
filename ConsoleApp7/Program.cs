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

class Surg : HospitalWorker
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Surgeon:");
        base.DisplayInfo();
    }
}

class MyArray
{
    public virtual void CountAndAdd(int count)
    {
        Console.WriteLine("Массив: {0} элементов", count);
    }
}

class MyStack : MyArray
{
    public override void CountAndAdd(int num)
    {
        Console.WriteLine("Стек имеет: {0} элементов", num);
    }
}

class MyQueue : MyArray
{
    public override void CountAndAdd(int obj)
    {
        Console.WriteLine("В очереди есть: {0} элементов", obj);
    }
}

class Program
{
    static void Main()
    {
        HospitalWorker[] workers = new HospitalWorker[4];

        workers[0] = new HospitalWorker { Position = "General Hospital Worker", Age = 30 };
        workers[1] = new Nurse { Position = "RN Nurse", Age = 26 };
        workers[2] = new Surg { Position = "Orthopedic Surgeon", Age = 37 };
        workers[3] = new Nurse { Position = "LPN Nurse", Age = 25 };

        foreach (var worker in workers)
        {
            worker.DisplayInfo();
            Console.WriteLine();
        }

        MyStack myStack = new MyStack();
        MyQueue myQueue = new MyQueue();

        myStack.CountAndAdd(5);
        myQueue.CountAndAdd(8);

        Console.ReadLine();
    }
}