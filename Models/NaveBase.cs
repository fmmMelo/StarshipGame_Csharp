using System.Dynamic;

public class NaveBase{
    public string Nome {get; set;}

    private int vidaInic;
    public int Vida {get => vidaInic; protected set => vidaInic = Math.Max(0, value);}
    public int Dano {get; set;}

    public NaveBase(string nome, int vida, int dano){
            Nome = nome;
            Vida = vida;
            Dano = Math.Abs(dano);
        }

        public int Atacar() => Dano;
        public void ReceberDano(int calcdano){
            Vida = Math.Max(0, Vida - Math.Max(0, calcdano));
            Console.WriteLine($"Vida de {Nome}: {Vida} (-{calcdano} HP)\n");}

        public bool EstaVivo() => Vida > 0;  
    }
