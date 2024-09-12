int a = 18;
int b = 6;
int c = a / b;
Console.WriteLine(c);

int a2 = 5;
int b2 = 4;
int c2 = 2;
int d2 = (a2 + b2) - 6 * c2 + (12 * 4) / 3 + 12;Console.WriteLine(d2);

int aa = 7;
int bb = 4;
int cc = 3;
int dd = (aa + bb) / cc;
int ee = (aa + bb) % cc;
Console.WriteLine($"quotient: {dd}");
Console.WriteLine($"remainder: {ee}");
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
