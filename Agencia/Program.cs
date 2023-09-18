while (true)
{
    
    Console.WriteLine("digite seu saldo:");
    double saldoC = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("digite o valor que deseja:");
    double valor = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("CONTA");
    Conta c = new Conta(50, "caixa","caixa" ,saldoC,valor);
    c.Sacar(valor,saldoC);
    c.Depositar(valor, saldoC);

    Console.WriteLine("Cempres0a");
    Cempresa ces = new Cempresa(10, 7000,8000, 01,4000, "1", "caixa",4444, saldoC);
    ces.FzrEmprestimo(200);
    ces.Sacar(valor, saldoC);

    Console.WriteLine("Cestudante");
    Cestudante ce = new Cestudante(600, "ifro", "000", 01, "agencia", "caixa", saldoC,valor);
    ce.Sacar(valor, saldoC);


}


