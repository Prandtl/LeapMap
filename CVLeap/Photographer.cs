using System;
using System.Diagnostics;
using System.Drawing;

namespace CVLeap
{
	class Photographer
	{
		public bool done;
		public Photographer(string path, int amount, int delay)
		{
			outPath = path;
			this.amount = amount;
			sw = new Stopwatch();
			photosInSeries = 0;
			this.delay = delay;
			done = false;
			provider = new ImageProvider();
			provider.AddNewAction(OnNewImages);
			sw.Start();
		}

		public void OnNewImages(Bitmap[] images)
		{
			Console.WriteLine("got new images");
			if (done)
			{
				Console.WriteLine("already done.");
				return;
			}

			if (sw.ElapsedMilliseconds < delay)
			{
				Console.WriteLine("too early!");
				Console.WriteLine(sw.ElapsedMilliseconds);
				return;
			}
			sw.Reset();

			foreach (var image in images)
			{
				Console.WriteLine("saving");
				photosInSeries++;
				var name = outPath + photosInSeries + ".bmp";
				image.Save(name);
			}

			if (photosInSeries > amount)
			{
				done = true;
			}

			sw.Start();
		}

		private ImageProvider provider;
		private string outPath;
		private int photosInSeries;
		private int amount;
		private int delay;
		private Stopwatch sw;
	}
}
