public class NaveInimiga : NaveBase
{
    public int Recompensa { get;}
    public NaveInimiga(string nome, int vida, int dano, int recompensa) : base(nome, vida, dano){
    Recompensa = Math.Max(0, recompensa); 
    }
}
