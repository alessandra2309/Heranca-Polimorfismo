
    internal class Conta
    {
        public int NumeroC { get; set; }
        public string Agenncia { get; set; }
        public string Titular { get; set; }
        public double SaldoC { get; set; }

        public Conta(){ }

        public Conta(int numeroC, string agenncia, string titular,double saldoC)
        {
            NumeroC = numeroC;
            Agenncia = agenncia;
            Titular = titular;
            SaldoC = saldoC;
           
           
        }

        public virtual void Sacar(double valor)
        {
            double conta = 0;
            if(saldoC >= valor)
            {
                conta = SaldoC - valor;
              Console.WriteLine($"seu saldo atual agora é {conta} reais");
            }
            else
            {
               Console.WriteLine("saldo insuficiente");
            }
           

        }

        public void Depositar(double valor)
        {
           if(valor >= 0)
           {
             double conta2 = SaldoC + valor;
            Console.WriteLine($"seu saldo atual agora é {conta2} reais");
           }
           else
           {
            Console.WriteLine("opção invalida");

           }
      
        }
    }

