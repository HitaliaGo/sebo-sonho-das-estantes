namespace _.Models;

class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public string ImgUrl { get; set; }

    public Usuario(
        string nome,
        string email,
        string telefone,
        string imgurl

    )
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        ImgUrl = imgurl;
    }
public Usuario(){
    
}

}

