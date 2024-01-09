 namespace DesafioPOO.Models
 {
//     // TODO: Herdar da classe "Smartphone"
     public class Nokia : Smartphone
     {

         public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){

        }
         public string Nome { get; set;}
//         // TODO: Sobrescrever o método "InstalarAplicativo"
         public override void InstalarAplicativo(string nomeApp){
             Nome = nomeApp;
             Console.WriteLine($"O aplicativo {Nome} foi instalado.");
         }
     }
 }