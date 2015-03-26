using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCvSharp;

namespace CVLeap
{
	class StereoCalibrator
	{
		public StereoCalibrator(string path, int imagesNum, int width, int height)
		{
			outPath = path;
			size = new CvSize(width, height);
			this.imagesNum = imagesNum;
			leftPoints=new List<CvPoint2D32f>();
			rightPoints=new List<CvPoint2D32f>();
		}


		public void Calibrate()
		{
			int nBoards = size.Width * size.Height;
			int allPoints = nBoards * imagesNum;

			string[] namePair = { "{0}left{1}.bmp", "{0}right{1}.bmp" };
			var fileNames = new List<string[]>();
			for (int i = 0; i < imagesNum; i++)
			{
				fileNames.Add(new string[2] { 
					string.Format(namePair[0], outPath, i + 1),
					string.Format(namePair[1], outPath, i + 1) });
			}

			foreach (var pair in fileNames)
			{
				var left = new IplImage(pair[0]);
				leftPoints.AddRange(FindChessboardCorners(left));
				var right = new IplImage(pair[1]);
				rightPoints.AddRange(FindChessboardCorners(right));
				Console.Write(".");
			}

			CvPoint3D32f[, ,] objects = new CvPoint3D32f[imagesNum, size.Height, size.Width];
			for (int i = 0; i < imagesNum; i++)
				for (int j = 0; j < size.Height; j++)
					for (int k = 0; k < size.Width; k++)
						objects[i, j, k] = new CvPoint3D32f(j * squareSize, k * squareSize, 0.0f);
			CvMat objectPoints = new CvMat(allPoints, 3, MatrixType.F32C1, objects);

			CvMat imagePoints1 = new CvMat(allPoints, 1, MatrixType.F32C2, leftPoints.ToArray());
			CvMat imagePoints2 = new CvMat(allPoints, 1, MatrixType.F32C2, rightPoints.ToArray());
			CvMat pointCount = new CvMat(imagesNum, 1, MatrixType.S32C1, allPoints);
			CvMat cameraMatrix1 = CvMat.Identity(3, 3, MatrixType.F64C1);
			CvMat cameraMatrix2 = CvMat.Identity(3, 3, MatrixType.F64C1);
			CvMat distCoeffs1 = new CvMat(1, 4, MatrixType.F64C1);
			CvMat distCoeffs2 = new CvMat(1, 4, MatrixType.F64C1);
			CvMat R = new CvMat(3, 3, MatrixType.F64C1);
			CvMat T = new CvMat(3, 1, MatrixType.F64C1);
			CvMat E = null;
			CvMat F = null;

			try
			{

				Cv.StereoCalibrate(objectPoints,
					imagePoints1,
					imagePoints2,
					pointCount,
					cameraMatrix1,
					distCoeffs1,
					cameraMatrix2,
					distCoeffs2,
					size,
					R,
					T,
					E,
					F,
					new CvTermCriteria(CriteriaType.Iteration | CriteriaType.Epsilon, 100, 1e-5),
					CalibrationFlag.SameFocalLength | CalibrationFlag.ZeroTangentDist);
			}
			catch (Exception e)
			{
				Console.WriteLine("no no NOOOO!");
				Console.WriteLine(e.Message);
				Console.WriteLine(imagePoints1.Rows);
			}
			Console.WriteLine("sucsess");
		}

		private CvPoint2D32f[] FindChessboardCorners(IplImage image)
		{
			CvPoint2D32f[] corners = null;
			var count = 0;
			Cv.FindChessboardCorners(image, size, out corners, out count,
				ChessboardFlag.AdaptiveThresh | ChessboardFlag.FilterQuads);//can refine here
			return corners;
		}



		private string outPath;
		private CvSize size;
		private int imagesNum;
		private List<CvPoint2D32f> leftPoints;
		private List<CvPoint2D32f> rightPoints;

		private float squareSize = 4.0f;
	}
}
