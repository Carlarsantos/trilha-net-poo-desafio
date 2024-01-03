namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        
    
        public Iphone(string numero) : base(numero)
        {
            Console.WriteLine("Digite o número novo:");
            Console.ReadLine();
        }

        
        public override void InstalarAplicativo(string nomeApp)
        {
            
            Console.WriteLine($"Installing {nomeApp} on iPhone...");

        }
    }
}
    
