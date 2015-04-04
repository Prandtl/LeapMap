using System;
using System.Drawing;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Extensions;

namespace CVLeap
{
	class DisparityGenerator
	{
		public DisparityGenerator(Settings settings)
		{
			this.settings = settings;
			sgbm = new StereoSGBM();
			sgbm.SADWindowSize = 5;
			sgbm.NumberOfDisparities = 192;
			sgbm.PreFilterCap = 4;
			sgbm.MinDisparity = -64;
			sgbm.UniquenessRatio = 1;
			sgbm.SpeckleWindowSize = 150;
			sgbm.SpeckleRange = 2;
			sgbm.Disp12MaxDiff = 10;
			sgbm.FullDP = false;
			sgbm.P1 = 600;
			sgbm.P2 = 2400;

			//using (CvFileStorage fs = new CvFileStorage("..\\..\\extrinsinc.yml", null, FileStorageMode.Read))
			//{
			//	CvFileNode node;
			//	node = fs.GetFileNodeByName(null,"R");
			//	CvMat R = fs.Read<CvMat>(node);
			//	Console.WriteLine(R);
			//}
		}

		public Bitmap GenerateDisparityFrom(Bitmap left, Bitmap right)
		{
			try
			{
				sgbm.SADWindowSize = settings.SADwindowSize.Value * 2 - 1;
				sgbm.MinDisparity = settings.minDisparity.Value;
				sgbm.NumberOfDisparities = settings.numOfDisparities.Value * 16;
				sgbm.P1 = (int)Math.Pow(settings.SADwindowSize.Value, 2) * 32;
				sgbm.P2 = (int)Math.Pow(settings.SADwindowSize.Value, 2) * 128;
				sgbm.SpeckleRange = settings.speckleRange.Value;
				sgbm.PreFilterCap = settings.preFilterCap.Value;
				sgbm.Disp12MaxDiff = settings.dispMaxDiff.Value;
				res = new Mat();
				sgbm.Compute(left.ToMat(), right.ToMat(), res);
				var realRes = new Mat();
				res.ConvertTo(realRes, MatType.CV_8U);
				return realRes.ToBitmap();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			return null;
		}

		private Bitmap Rectify(Bitmap image)
		{
			return image;
		}


		private Mat res;
		private StereoSGBM sgbm;
		private Settings settings;

	}
}
