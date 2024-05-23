using  InterfaceAutenticavel;

Cliente c = new Cliente ();
c.Senha = 100;

// UMA VARIÁVEL DO TIPO INTERFACE NÃO PODE SER INSTACIADA!!! MAS PODE RECEBER UM OBJETO JÁ INSTANCIADO IAutenticavel it = new IAutenticavel();

IAutenticavel itc = c;
System.Console.WriteLine("Autenticou? " + itc.Autenticar(100));

Diretor d = new Diretor ();
d.Senha = 200;

IAutenticavel itd = d;
System.Console.WriteLine("Autenticou? " + itd.Autenticar(201)); // SENHA DIFERENTE - N AUTENTICOU

Gerente g = new Gerente ();
g.Senha = 300;

IAutenticavel it = g;
System.Console.WriteLine("Autenticou? " + it.Autenticar(300)); // SENHA DIFERENTE - N AUTENTICOU

