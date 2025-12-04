public class Cliente 
{
    public int Id { get; set; }
    public string _telefoneDeContato { get; set; }
    public string _email { get; set; }
    public DateOnly _dataCadSistema { get; set; }

    //colocar como abstrato para usar em outra classe tem o override
    public double DescontoEspecial(double valor) 
    {

        return valor;
    } 
}
// cliente pf e cliente pj
public class ClientePJ : Cliente 
{
    public string _cnpj { get; set; }
    public Servicos servicos;
    public virtual void DescontoEspecial(double valor)
    {
        servicos._valorSugerido = valor;
        if (valor > 500 && valor < 1000)
        {
            double total = valor - (valor * 0.5);
        }
        else 
        {
            double total = valor - (valor * 0.7);
        }
    }
}
public class ClientePF : Cliente 
{
    public string _cpf {  get; set; }
    public Servicos servicos;
    public virtual void DescontoEspecial(double valor)
    {
        servicos._valorSugerido = valor;
        if (valor > 500 && valor < 1000)
        {
            double total = valor - (valor * 0.6);
        }
        else
        {
            double total = valor - (valor * 0.9);
        }
    }
}