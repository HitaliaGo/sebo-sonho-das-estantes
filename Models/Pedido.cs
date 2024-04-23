public class Pedido
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public double ValorPedido { get; set; }
    public enum StatusPedido { efetuado, emPreparacao, enviado }
    public StatusPedido Status { get; set; }
    public MetodoPagamento MetodoPag { get; set; }
    public enum MetodoPagamento
    {
        Débito,
        Crédito,
        Dinheiro,
        pix,
        Boleto
    }


    public Pedido(
 DateTime dataPedido,
 double valorPedido,
 StatusPedido status,
 MetodoPagamento metodoPagamento


    )
    {
        DataPedido = dataPedido;
        ValorPedido = valorPedido;
        Status = status;
        MetodoPag = MetodoPag;



    }

}
