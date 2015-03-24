using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCvSharp;

namespace CVLeap
{
	class StereoCalibrator
	{
		public StereoCalibrator(string path, int width, int height)
		{
			outPath = path;
			size = new CvSize(width, height);
		}


		public void Calibrate()
		{
			int NBoards = size.Width * size.Height;

			//Cv.Corn
		}

		private string outPath;
		private CvSize size;
	}
}
