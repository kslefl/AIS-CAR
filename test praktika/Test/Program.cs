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

    public string Port { get; set; } = ""; //Должно быть удалено лишнее свойство Port, так как у самолета не должно быть порта приписки.

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
  //Должен быть добавлен метод "Main", подходящий для точки входа
    
}
