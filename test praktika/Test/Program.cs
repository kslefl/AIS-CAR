using System;
using System.Collections.Generic;

#nullable enable

abstract class Vehicle
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Price { get; set; }
    public double Speed { get; set; }
    public int Year { get; set; }

    public abstract void ShowInfo();
}

class Plane : Vehicle
{
    public double Altitude { get; set; }
    public int Passengers { get; set; }

    public string Port { get; set; } = "";

    public override void ShowInfo()
    {
        Console.WriteLine($"\nСамолёт:");
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price}, Скорость: {Speed}, Год выпуска: {Year}");
        Console.WriteLine($"Высота: {Altitude}, Пассажиров: {Passengers}");
        Console.WriteLine($"Порт приписки: {Port}"); 
    }
}

class Car : Vehicle
{
    public override void ShowInfo()
    {
        Console.WriteLine($"\nАвтомобиль:");
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price}, Скорость: {Speed}, Год выпуска: {Year}");
        Console.WriteLine($"Пассажиров: неизвестно");
    }
}

class Ship : Vehicle
{
    public string Port { get; set; } = "";


    public override void ShowInfo()
    {
        Console.WriteLine($"\nКорабль:");
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price}, Скорость: {Speed}, Год выпуска: {Year}");
        Console.WriteLine($"Порт приписки: {Port}");
        Console.WriteLine($"Пассажиров: ???");
    }
}
class Program
{
    static void Main()
    {
        Plane plane = new Plane
        {
            X = 100,
            Y = 200,
            Price = 1000000,
            Speed = 800,
            Year = 2020,
            Altitude = 10000,
            Passengers = 150,
            Port = "Шереметьево"
        };

        Car car = new Car
        {
            X = 10,
            Y = 20,
            Price = 30000,
            Speed = 180,
            Year = 2019
        };

        Ship ship = new Ship
        {
            X = 50,
            Y = 70,
            Price = 500000,
            Speed = 50,
            Year = 2015,
            Port = "Одесса"
        };

        plane.ShowInfo();
        car.ShowInfo();
        ship.ShowInfo();
    }
}