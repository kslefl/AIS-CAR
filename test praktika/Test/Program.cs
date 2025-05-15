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

      // Удалено лишнее свойство Port, так как у самолёта не должно быть порта приписки.

    public override void ShowInfo()
    {
        Console.WriteLine($"\nСамолёт:");
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price}, Скорость: {Speed}, Год выпуска: {Year}");
        Console.WriteLine($"Высота: {Altitude}, Пассажиров: {Passengers}");
        
    }
}

class Car : Vehicle
{
    public override void ShowInfo()
    {
        Console.WriteLine($"\nАвтомобиль:");
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price}, Скорость: {Speed}, Год выпуска: {Year}");
        // Удалено сообщение о пассажирах, так как у Car нет такого свойства.
    }
}

class Ship : Vehicle
{
    public string Port { get; set; } = "";
public int Passengers { get; set; } // Добавлено обязательное свойство Passengers.

    public override void ShowInfo()
    {
        Console.WriteLine($"\nКорабль:");
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price}, Скорость: {Speed}, Год выпуска: {Year}");
        Console.WriteLine($"Порт приписки: {Port}");
        Console.WriteLine($"Пассажиров: {Passengers}"); // Исправлено: теперь выводит значение Passengers.
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
            // Port удалён, так как у Plane больше нет такого свойства.
        };

        Car car = new Car
        {
            X = 10,
            Y = 20,
            Price = 30000,
            Speed = 180,
            Year = 2019
            // Удалено сообщение о пассажирах.
        };

        Ship ship = new Ship
        {
            X = 50,
            Y = 70,
            Price = 500000,
            Speed = 50,
            Year = 2015,
            Port = "Одесса",
            Passengers = 300 // Добавлено свойство Passengers.
        };

        plane.ShowInfo();
        car.ShowInfo();
        ship.ShowInfo();
    }
}