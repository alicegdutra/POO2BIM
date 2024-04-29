using HerancaProduto;

Produto p = new Produto();
p.Mostrar();
Produto p1 = new Produto(1, "celular", 50);
p1.Mostrar();

Perecivel pe = new Perecivel(); //vazio, por instaciou nas classes
pe.Mostrar();
Perecivel pe2 = new Perecivel(2, "lanche", 21, "28/04/2024", "29/04/2024", 22); //vazio, por instaciou nas classes
pe2.Mostrar();

//base. - chama o método 
//base() - chama o construtor
