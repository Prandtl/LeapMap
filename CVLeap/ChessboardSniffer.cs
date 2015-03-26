using System;
using OpenCvSharp;

namespace CVLeap
{
	class ChessboardSniffer
	{
		public ChessboardSniffer(int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		public void Sniff(IplImage img)
		{
			Cv.ShowImage("input image", img);
			Cv.WaitKey();

			var size = new CvSize(width,height);
			CvPoint2D32f[] corners = null;
			var count = 0;

			var found = Cv.FindChessboardCorners(img, size, out corners,out count,ChessboardFlag.AdaptiveThresh|ChessboardFlag.FilterQuads);
			Console.WriteLine(found);

			Cv.DrawChessboardCorners(img, size, corners, found);

			Cv.ShowImage("output image",img);
			Cv.WaitKey();
		}

		private int width;
		private int height;
	}
}
