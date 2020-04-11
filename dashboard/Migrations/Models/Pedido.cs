namespace dashboard.Migrations
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public double Valor { get; set; }
        public bool Faturado { get; set; }
    }
}