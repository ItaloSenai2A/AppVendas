namespace AppVendas.Models
{
    public class ItemDaVenda
    {
        /*Relacionamento com a tabela Vendas */
        public Guid ItemDaVendaId { get; set; }
        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }

        /* Relacionamento com a tabela Produtos */
        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        public double QtadeVendida { get; set; }
        public double ValorTotalDoItem { get; set; }
    }
}
