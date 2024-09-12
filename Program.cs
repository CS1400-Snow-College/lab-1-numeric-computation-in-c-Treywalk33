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


double a1 = 57;
double b1 = 4;
double c1 = 23;
double d1 = (a1 + b1) / c1;
Console.WriteLine(d1);
double max1 = double.MaxValue;
double min1 = double.MinValue;
Console.WriteLine($"The range of double is {min1} to {max1}");
double third = 1.0 / 3.0;
Console.WriteLine(third);

decimal min2 = decimal.MinValue;
decimal max2 = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

double a3 = 1.0;
double b3 = 3.0;
Console.WriteLine(a3 / b3);

decimal c3 = 1.0M;
decimal d3 = 3.0M;
Console.WriteLine(c3 / d3);

double r = 2.50;
double x = Math.PI;
Console.WriteLine(x*r*r);
