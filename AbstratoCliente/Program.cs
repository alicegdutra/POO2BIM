﻿using AbstratoCliente;

//Cliente c = new Cliente(); //não instanciara

// a utilização do metodo abstatro faz a reutilização total do metodo da super classe 
// ; - ao colocar ponto e virgula, indicamos o final da função

//metodo abstrato apenas em classe abstratas; Uma classe abstrata n precisa ter necessariamente metodos abstratos


ClienteFisico cf = new ClienteFisico(1, "Ana", "Rua A", 20, 111);
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(100, "Empresa", "Rua B", 43, 11000);
cj.Mostrar();

Teste t = new Teste();
t.VerificaIdade(cf);