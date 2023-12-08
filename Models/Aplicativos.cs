namespace DesafioPOO.Models
{
    public class Aplicativos 
    {
        private List<string> aplicativosInstalados;

        public Aplicativos()
        {
            aplicativosInstalados = new List<string>();
        }

        // Método para instalar um aplicativo na lista
        public void Instalar(string nomeApp)
        {
            aplicativosInstalados.Add(nomeApp);
        }

        // Método para listar os aplicativos instalados
        public void Listar()
        {
            Console.WriteLine("Aplicativos instalados:");
            foreach (var app in aplicativosInstalados)
            {
                Console.WriteLine(app);
            }
        }
    }
}