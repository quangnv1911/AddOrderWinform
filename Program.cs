using Lab_2.Services.Services;

namespace Lab_2
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
            Application.Run(new Form1(
                    new SqlServerCategoryService(),
                    new SqlServerCustomerService(),
                    new SqlServerEmployeeService(),
                    new SqlServerOrderDetailService(),
                    new SqlServerOrderService(),             
                    new SqlServerProductService(),
                    new SqlServerShipperService()

                ));
        }
    }
}