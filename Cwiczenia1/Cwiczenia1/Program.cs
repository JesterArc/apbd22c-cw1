// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello Once Moar");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i * i);
}
int a = 5;
while (a-- > 0)
{
    Console.WriteLine(a + "...");
    System.Threading.Thread.Sleep(1000);
}
Console.WriteLine("BOOM");
