public class NavePlayer : NaveBase
{
    public TipoNave Tipo { get; }
    public NavePlayer(string nome, int vida, int dano, TipoNave tipo) : base(nome, vida, dano){
    Tipo = tipo;}
}
