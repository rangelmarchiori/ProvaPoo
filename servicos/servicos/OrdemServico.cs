using System.ComponentModel;

public class OrdemServico 
{
    public int Id { get; set; }
    public string _dataInicio { get; set; }
    public List<ItemServico> itemServico;//verificaressamacumba ai
    public bool _status;
    public Veiculos veiculos;
    public Cliente cliente;

    // calcular valor final basicamente list vai passar pela lista de itens adicionados e vai somar o valor unitario da lista tipo 
    // uma roda custa 10 real ent vai ir indo 10 +10 10+ 
    // usar foreach
    //public ValorFinal(double valorOrdem)
    //{
    //}
    public ValorFinal(double valorOrdem)
    {
        //valorOrdem = new List<ItemServico>();
        itemServico = new List<ItemServico>();
        double teste;
        
        foreach (var itemServico in itemServico) 
        {
            itemServico._valorUnit
            // passa pelo laço e contabiliza a cada contagem 
            //itemServico._valorUnit(itemServico + teste);
           
            return "complexo";
        }

    }


}