public class Program
{
    static void Main()
    {
        NavePlayer player = new NavePlayer("Millennium Falcon", 100, 25, TipoNave.Exploradora);
        NaveInimiga inimigo = new NaveInimiga("TIE Fighter", 85, 20, 55);
        Random randnum = new Random();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=============================================");
        Console.WriteLine("                INICIANDO COMBATE            ");
        Console.WriteLine("=============================================");
        Console.ResetColor();

        while(player.EstaVivo() && inimigo.EstaVivo())
        {
            bool playerPar = randnum.Next(0,2) == 0;
            bool numPar = randnum.Next(1, 1001) % 2 == 0;
            bool PrimeiroAtaque = (playerPar == numPar);

            if(PrimeiroAtaque){
                if(player.EstaVivo()){
                    Console.WriteLine($"Ataque de {player.Nome}!");
                    inimigo.ReceberDano(player.Atacar()); 
                }
            }else{
                if(inimigo.EstaVivo()){
                    Console.WriteLine($"Ataque de {inimigo.Nome}!");
                    player.ReceberDano(inimigo.Atacar());
                }
            }
        }
        if (player.EstaVivo())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=============================================");
            Console.WriteLine($"🏆 VITÓRIA! {player.Nome} destruiu {inimigo.Nome}!\nSUA RECOMPENSA É {inimigo.Recompensa} PONTOS!");
            Console.WriteLine("=============================================");
        }
        else{
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("=============================================");
            Console.WriteLine($"💀 GAME OVER! {inimigo.Nome} venceu...");
            Console.WriteLine("============================================="); 
        }
      Console.ResetColor();  
    }
}
