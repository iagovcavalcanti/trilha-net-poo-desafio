namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string IMEI { get; private set; }
        public int Memoria { get; private set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        protected List<string> AplicativosInstalados { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

            AplicativosInstalados = new List<string>(); 
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public void ListarAplicativos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Aplicativos instalados para {Modelo}:");
            Console.ResetColor();
            foreach (var app in AplicativosInstalados)
            {
                Console.WriteLine(app);
            }
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}