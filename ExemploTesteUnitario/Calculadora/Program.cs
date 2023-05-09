using Calculadora.Services;

CalculadoraImp calc = new CalculadoraImp();

int num1 = 1;
int num2 = 1;

Console.WriteLine($"{num1} + {num2} = {calc.Somar(num1, num2)}");


