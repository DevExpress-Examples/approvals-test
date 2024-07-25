// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


int[] edges = new int[3];
for(int i = 0; i < 3; i++)
{
    edges[i] = int.Parse(Console.ReadLine());
}
Stopwatch sw = Stopwatch.StartNew();
//if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
if ((edges[0] + edges[1]) <= edges[2] || (edges[0] + edges[2]) <= edges[1] || (edges[1] + edges[2]) <= edges[0])
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}
Console.WriteLine(sw.ElapsedTicks);
Console.WriteLine("String added");
Console.WriteLine("String added");
Console.WriteLine("String added");
Console.WriteLine("String added");


