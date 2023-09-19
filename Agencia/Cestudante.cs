
internal class Cestudante :Conta
{
    public double Limitechequeespecial { get; set; }
    public string NomeInstituicao { get; set; }
    public string Cpf { get; set; }

    public Cestudante(double limitechequeespecial, string nomeInstituicao, string cpf,
        int numeroC, string agenncia, string titular, double saldoC) : base( numeroC,  agenncia,  titular,saldoC)
    {
        this.Limitechequeespecial = limitechequeespecial;
        this.NomeInstituicao = nomeInstituicao;
        this.Cpf = cpf;
    }
    public override void Sacar(double valor)
    {
        if(valor <= SaldoC + limitechequeespecial)
        {
            SaldoC -= valor;
        }
        else
        {
            Console.WriteLine("saldo insuficiente!");
        }
    }
}

