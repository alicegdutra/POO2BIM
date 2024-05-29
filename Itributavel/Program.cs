using Itributavel;


ContaCorrente contaCorrente = new ContaCorrente(3500);
SeguroVida seguroVida = new SeguroVida();

Console.WriteLine("Tributo do Seguro de Vida: " + seguroVida.CalculaTributos());
Console.WriteLine("Tributo da Conta Corrente: " + contaCorrente.CalculaTributos());


TotalTributo totalizador = new TotalTributo();
totalizador.AdicionaTributo(contaCorrente);
totalizador.AdicionaTributo(seguroVida);

Console.WriteLine($"Total de tributos acumulados: {totalizador.TotalTributos}");
