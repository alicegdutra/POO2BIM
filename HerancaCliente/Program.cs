// método Main()
using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Cliente Fatec";
c.Endereco = "Rua Terezina, 75";
c.Mostrar();

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Cliente Fisica Ana";
cf.Endereco = "Rua Centro, 2";
cf.Rg = 2;
cf.Mostrar();
ClienteFisico cf2 = new ClienteFisico(4,"Cliente Lia","Rua Lia",44);
cf2.Mostrar();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Empresa Bia";
cj.Endereco = "Rua Sol, 3";
cj.Cnpj = 3;
cj.Mostrar();

ClienteJuridico cj2 = new ClienteJuridico(33, "Empresa Teo","Rua Teo", 3333);
cj2.Mostrar();