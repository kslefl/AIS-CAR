using System;
using System.Collections.Generic;

#nullable enable // Включаем строгую проверку на null

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
    }
}

class Ship : Vehicle
{
    public required string Port { get; set; } = ""; // исправлен CS8618
    public int Passengers { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"\nКорабль:");
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price}, Скорость: {Speed}, Год выпуска: {Year}");
        Console.WriteLine($"Порт приписки: {Port}, Пассажиров: {Passengers}");
    }
}

class Program
{
    static List<Vehicle> vehicles = new();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить самолёт");
            Console.WriteLine("2. Добавить автомобиль");
            Console.WriteLine("3. Добавить корабль");
            Console.WriteLine("4. Показать все объекты");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите пункт: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1": AddPlane(); break;
                case "2": AddCar(); break;
                case "3": AddShip(); break;
                case "4": ShowAll(); break;
                case "5": return;
                default: Console.WriteLine("Неверный выбор."); break;
            }
        }
    }

    static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        return double.TryParse(Console.ReadLine(), out double value) ? value : 0;
    }

    static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        return int.TryParse(Console.ReadLine(), out int value) ? value : 0;
    }

    static string ReadString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? "";
    }

    static void AddPlane()
    {
        Plane plane = new Plane
        {
            X = ReadDouble("Введите X: "),
            Y = ReadDouble("Введите Y: "),
            Price = ReadDouble("Введите цену: "),
            Speed = ReadDouble("Введите скорость: "),
            Year = ReadInt("Введите год выпуска: "),
            Altitude = ReadDouble("Введите высоту: "),
            Passengers = ReadInt("Введите количество пассажиров: ")
        };
        vehicles.Add(plane);
        Console.WriteLine("Самолёт добавлен.");
    }

    static void AddCar()
    {
        Car car = new Car
        {
            X = ReadDouble("Введите X: "),
            Y = ReadDouble("Введите Y: "),
            Price = ReadDouble("Введите цену: "),
            Speed = ReadDouble("Введите скорость: "),
            Year = ReadInt("Введите год выпуска: ")
        };
        vehicles.Add(car);
        Console.WriteLine("Автомобиль добавлен.");
    }

    static void AddShip()
    {
        Ship ship = new Ship
        {
            X = ReadDouble("Введите X: "),
            Y = ReadDouble("Введите Y: "),
            Price = ReadDouble("Введите цену: "),
            Speed = ReadDouble("Введите скорость: "),
            Year = ReadInt("Введите год выпуска: "),
            Port = ReadString("Введите порт приписки: "),
            Passengers = ReadInt("Введите количество пассажиров: ")
        };
        vehicles.Add(ship);
        Console.WriteLine("Корабль добавлен.");
    }

    static void ShowAll()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("Список пуст.");
            return;
        }

        Console.WriteLine("\nСписок всех транспортных средств:");
        foreach (var v in vehicles)
            v.ShowInfo();
    }
}
