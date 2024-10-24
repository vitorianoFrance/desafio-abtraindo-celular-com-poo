namespace DesafioPOO.Models
{
    public abstract class Smartphone //definida como abstrata, uma classe que não poderá ser instanciada, ela será a base para minhas outras classe herdarem dela.
    {

        // Foi Implementado as propriedades de acordo com o diagrama da pasta imagens
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }


        // Passei os parâmetros do construtor para as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
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