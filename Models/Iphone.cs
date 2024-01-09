using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){

        }



        // TODO: Sobrescrever o método "InstalarAplicativo"
       public string Nome { get; set;}
        public override void InstalarAplicativo(string nomeApp){
           Nome = nomeApp;
             Console.WriteLine($"O aplicativo {Nome} foi instalado.");
         }



    }
}