using System.ComponentModel;

public class OrdemServico 
{
    public int Id { get; set; }
    public DateOnly _dataInicio { get; set; }
    public List<ItemServico> itemServico;//verificaressamacumba ai
    public bool _status;
    public Veiculos veiculos;
    public Cliente cliente;

    // calcular valor final basicamente list vai passar pela lista de itens adicionados e vai somar o valor unitario da lista tipo 
    // uma roda custa 10 real ent vai ir indo 10 +10 10+ 
    //public ValorFinal(double valorOrdem)
    //{
    //}


}