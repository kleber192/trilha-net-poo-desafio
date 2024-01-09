    namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }


       

       // TODO: Passar os parâmetros do construtor para as propriedades
        public Smartphone(string Numero, string Modelo,string Imei,int Memoria )
        {
            this.Numero = Numero;
            this.Modelo = Modelo;
            this.Imei = Imei;
            this.Memoria = Memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}



            