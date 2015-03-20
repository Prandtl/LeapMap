using System;
using System.Windows.Forms;

namespace CVLeap
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		//[STAThread]
		static void Main()
		{
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MainForm());

			PhotographerSession();

		}

		static void PhotographerSession()
		{
			Console.Write("Amount: ");
			var amount = int.Parse(Console.ReadLine());
			Console.Write("Delay: ");
			var delay = int.Parse(Console.ReadLine());

			Photographer photomaker = new Photographer("img/", amount, delay);

			while (!photomaker.done)
			{
				
			}

			Console.WriteLine("Done!");
		}
	}
}
