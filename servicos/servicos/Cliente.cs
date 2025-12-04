public class Cliente 
{
    public int Id { get; set; }
    public string _telefoneDeContato { get; set; }
    public string _email { get; set; }
    public string _dataCadSistema { get; set; }
    public Servicos servicos;

    //colocar como abstrato para usar em outra classe tem o override
    public  virtual double DescontoEspecial(double valor)
    {
        servicos._valorSugerido = valor;
        return valor;
    } 
}
// cliente pf e cliente pj
public class ClientePJ : Cliente 
{
    public string _cnpj { get; set; }
    public string _nomeFantasia { get; set; }
    public string _razaoSocial { get; set; }
    public override double DescontoEspecial(double valor)
    {
        if (valor > 500 && valor < 1000)
        {
            double total = valor - (valor * 0.5);
            return total;
        }
        else 
        {
            double total = valor - (valor * 0.7);
            return total;
        }
    }
}
public class ClientePF : Cliente 
{
    public string _cpf {  get; set; }
    public string _nome { get; set; }
    public DateOnly _dataNasc { get; set; }
    public override double DescontoEspecial(double valor)
    {
        if (valor > 500 && valor < 1000)
        {
            double total = valor - (valor * 0.6);
            return total;
        }
        else
        {
            double total = valor - (valor * 0.9);
            return total;
        }
    }
}