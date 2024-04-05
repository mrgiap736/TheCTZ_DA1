using C_PRL.UI;
using System.Reflection;

namespace C_PRL
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
			//Application.Run(new Form_DangNhap());


			//ch?y luôn form trang ch? b? qua ??ng nh?p
            Application.Run(new Form_DangNhap());

        }
    }
}