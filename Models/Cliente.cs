namespace _.Models;

class Cliente : Usuario
{
    public string Endereco { get; set; }


    public Cliente(string endereco) : base()
    {
        Endereco = endereco;
    }

}