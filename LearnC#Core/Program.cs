// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập vào chiều dài của đường tròn:");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine("Bán kính hình tròn:" + radius);
        Console.WriteLine("Diện tích hình tròn:" + circumference);
    }
}
