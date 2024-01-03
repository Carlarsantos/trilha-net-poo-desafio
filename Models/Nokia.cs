namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
            Console.WriteLine("Digite o número novo:");
            Console.ReadLine();
        }        
        
      
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Installing {nomeApp} on Nokia...");

        }
    }
}









