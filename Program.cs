Console.Clear();
double medidaEmMilhas, resultadoEmKm;

Console.Write("Entre com a medida em (em milhas): ");

medidaEmMilhas = Convert.ToDouble(Console.ReadLine()!);
resultadoEmKm = medidaEmMilhas * 1.609;


Console.WriteLine($"{resultadoEmKm}Km");