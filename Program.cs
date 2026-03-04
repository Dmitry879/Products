using Products.Data;

namespace Products
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Create a concrete instance of CategoryDAO and assigned it to ICategoryRepository
            ICategoryRepository catRepository = new CategoryDAO();
            IProductRepository prodRepository = new ProductDAO();
            Application.Run(new ProductsForm(catRepository, prodRepository));
        }
    }
}