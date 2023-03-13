using System;

class Program {
    static void Main(string[] args) {
        int x1, y1, w1, h1, x2, y2, w2, h2;

        Console.Writeline("Put number of centerOne 1 : ");
        x1 = int.Parse(Console.ReadLine());
        Console.Writeline("Put number of centerOne 2 : ");
        y1 = int.Parse(Console.ReadLine());
        Console.Writeline("Put number of wideOne 1 : ");
        w1 = int.Parse(Console.ReadLine());
        Console.Writeline("Put number of heightOne 1 :");
        h1 = int.Parse(Console.ReadLine());
        Console.Writeline("Put number of centerTwo 1 : ");
        x2 = int.Parse(Console.ReadLine());
        Console.Writeline("Put number of centerTwo 2 : ");
        y2 = int.Parse(Console.ReadLine());
        Console.Writeline("Put number of wideTwo : ");
        w2 = int.Parse(Console.ReadLine());
        Console.Writeline("Put number of heightTwo :");
        h2 = int.Parse(Console.ReadLine());

        int x_overlap = Math.Max(0, Math.Min(x1 + w1 / 2, x2 + w2 / 2) - Math.Max(x1 - w1 / 2, x2 - w2 / 2));
        int y_overlap = Math.Max(0, Math.Min(y1 + h1 / 2, y2 + h2 / 2) - Math.Max(y1 - h1 / 2, y2 - h2 / 2));
        int overlap_area = x_overlap * y_overlap;

        if (overlap_area > 8) {
            Console.WriteLine("Too Much Overlapping");
        }
        else if (overlap_area > 0) {
            Console.WriteLine("Not Much Overlapping");
        }
        else {
            Console.WriteLine("No Overlapping");
        }
    }
}