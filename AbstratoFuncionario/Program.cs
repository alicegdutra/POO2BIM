using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Luciane", 1000);

Comissionado c1 = new Comissionado(3, "Carly", 1000, 20);
Comissionado c2 = new Comissionado(4, "Talia", 1000, 30);

Departamento d1 = new Departamento(10, "TI");
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionarios();
Console.WriteLine($"Total {d1.CalcularFolha(30):c}");

Departamento d2 = new Departamento(20, "Diretoria");
d2.Admitir(a2);
d2.Admitir(c2);
d2.Demitir(4);
d2.ListarFuncionarios();
Console.WriteLine($"Total {d2.CalcularFolha(30):c}");

Dependente dp1 = new Dependente(1, "Alice Gimenez Dutra", 19);
a1.Adicionar(dp1);
Dependente dp2 = new Dependente(2, "Gabriela Gimenez Dutra", 15);
a2.Adicionar(dp2);

a1.ListarDependente();
a2.ListarDependente();