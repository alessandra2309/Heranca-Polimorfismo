
internal class Cestudante :Conta
{
    public double Limitechequeespecial { get; set; }
    public string NomeInstituicao { get; set; }
    public string Cpf { get; set; }

    public Cestudante(double limitechequeespecial, string nomeInstituicao, string cpf,
        int numeroC, string agenncia, string titular, double saldoC, double valor) : base( numeroC,  agenncia,  titular,  saldoC,  valor)
    {
        this.Limitechequeespecial = limitechequeespecial;
        this.NomeInstituicao = nomeInstituicao;
        this.Cpf = cpf;
    }
    public void Sacar(double limitechequeespecial,double valor)
    {
        if(valor > limitechequeespecial)
        {
            Console.WriteLine("não e possível realizar a transação");
        }
        else if(valor < limitechequeespecial)
        {

        }
    }
}

