using System;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;

namespace CVLeap
{
	static class Program
	{
		static void Main()
		{
			ChessSniffer();
		}

		static void ChessSniffer()
		{
			var sniffer = new ChessboardSniffer(9, 6);

			string[] pair = { "..\\..\\img\\left{0}.bmp", "..\\..\\img\\right{0}.bmp" };

			for (int i = 0; i <= 25; i++)
			{
				sniffer.Sniff(new IplImage(String.Format(pair[0], i), LoadMode.GrayScale));
				sniffer.Sniff(new IplImage(String.Format(pair[1], i), LoadMode.GrayScale));
			}

		}

		static void PhotographerSession()
		{


			Console.Write("Amount: ");
			var amount = int.Parse(Console.ReadLine());
			Console.Write("Delay: ");
			var delay = int.Parse(Console.ReadLine());

			IPhotographer photomaker = new SmartPhotographer("..\\..\\img\\", amount, delay);

			while (!photomaker.IsDone())
			{

			}

			Console.WriteLine("Done!");
		}

		[STAThread]
		static void GraphicDisparityMap()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
