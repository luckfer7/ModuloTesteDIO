using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

int num3 = 50;
int num4 = 10;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
Console.WriteLine($"A diferença entre o {num3} e {num4} é {c.Subtrair(num3, num4)}");