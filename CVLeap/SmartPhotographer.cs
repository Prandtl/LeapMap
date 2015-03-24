using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace CVLeap
{
	class SmartPhotographer : IPhotographer
	{

		public SmartPhotographer(string path, int amount, int delay)
		{
			outPath = path;
			this.amount = amount;
			sw = new Stopwatch();
			picturesMade = 0;
			size = new CvSize(9,6);
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

			if (images.Select(IsValidForCalibration).Contains(false))
			{
				Console.WriteLine("no checkerboard here. :(");
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
		private bool IsValidForCalibration(Bitmap img)
		{

			CvPoint2D32f[] corners = null;

			var count = 0;
			var found = Cv.FindChessboardCorners(img.ToIplImage(),
				size, out corners, out count, ChessboardFlag.AdaptiveThresh | ChessboardFlag.FilterQuads);
			return found;
		}

		private ImageProvider provider;
		private string outPath;
		private int picturesMade;
		private int amount;
		private int delay;
		private Stopwatch sw;
		private bool done;
		private CvSize size;
	}

}


