// chamada da função de cada objeto

using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Ana Maria", 1000);
System.Console.WriteLine("Bonificação Funcionário: " + f.CalcularBonificacao());

Secretario s = new Secretario(2, "Luana", 1000);
System.Console.WriteLine("Bonificação Secretário: " + s.CalcularBonificacao());

Gerente g = new Gerente(3, "Leo", 1000);
System.Console.WriteLine("Bonificação Gerente: " + g.CalcularBonificacao());

Diretor d = new Diretor(1, "Aparecida", 1000);
System.Console.WriteLine("Bonificação Diretor: " + d.CalcularBonificacao());

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
gerenciador.TotalizadorBonificacao(f);
gerenciador.TotalizadorBonificacao(s);
gerenciador.TotalizadorBonificacao(g);
gerenciador.TotalizadorBonificacao(d);
Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacao);
