namespace cadastro_de_veiculos
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // O Application.Run será descomentado assim que o FormPrincipal (MDI) for adicionado
             Application.Run(new Form1());
        }
    }
}