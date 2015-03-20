using System;
using System.Drawing;
using System.Windows.Forms;

namespace CVLeap
{
	public partial class MainForm : Form
	{
		private ImageProvider provider;
		private DisparityGenerator generator;

		public MainForm()
		{
			Console.WriteLine("form started.");
			provider = new ImageProvider();
			var settings = new Settings();
			settings.Visible = true;
			generator = new DisparityGenerator(settings);
			provider.AddNewAction(ChangeImages);

			InitializeComponent();
		}

		public void ChangeImages(Bitmap[] images)
		{
			Console.WriteLine("images changed.");
			var leftIm = images[0];
			var rightIm = images[1];
			if (IsHandleCreated)
				Invoke(new Action(() =>
				{
					left.Image = leftIm;
					right.Image = rightIm;
					disparity.Image = generator.GenerateDisparityFrom(leftIm, rightIm);
				}));
		}
	}
}