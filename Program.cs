using DesafioPOO.Models;

namespace DesafioPOO
{

    class Program
    {
        static void Main()
        {

            Nokia meuNokia = new Nokia("123456");
            meuNokia.Ligar();
            meuNokia.ReceberLigacao();
            meuNokia.InstalarAplicativo("WhatsApp");

            Iphone meuIphone = new Iphone("7890105");
            meuIphone.Ligar();
            meuIphone.ReceberLigacao();
            meuIphone.InstalarAplicativo("Instagram");
        }
    }


}   
