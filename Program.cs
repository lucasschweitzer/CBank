
using Banco.Modelo;
using Banco.Telas;

namespace Banco
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Conta c;
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaInicial());
        }
    }
}