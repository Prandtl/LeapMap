using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace CVLeap
{
	class Photographer : IPhotographer
	{
		public Photographer(string path, int amount, int delay)
		{
			outPath = path;
			this.amount = amount;
			sw = new Stopwatch();
			picturesMade = 0;
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


			Console.WriteLine("saving");
			var nameL = outPath + "left" + picturesMade + ".bmp";
			images[0].Save(nameL);
			var nameR = outPath + "right" + picturesMade + ".bmp";
			images[1].Save(nameR);


			picturesMade++;

			Console.WriteLine("made {0} pictures", picturesMade);


			if (picturesMade > amount)
			{
				done = true;
			}

			sw.Start();
		}

		public bool IsDone()
		{
			return done;
		}

		private ImageProvider provider;
		private string outPath;
		private int picturesMade;
		private int amount;
		private int delay;
		private Stopwatch sw;
		private bool done;
	}

	interface IPhotographer
	{
		void OnNewImages(Bitmap[] images);
		bool IsDone();
	}
}
