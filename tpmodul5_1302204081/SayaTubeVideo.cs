using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpmodul5_1302204081
{
	internal class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;

		public SayaTubeVideo(string judulVideo)
		{
			this.title = judulVideo;
			Random generator  = new Random();
			int randNum = generator.Next(100000);
			string fiveDigitsNumber = randNum.ToString("D5");
			this.id = Int32.Parse(fiveDigitsNumber);
			this.playCount = 0;
		}
		public void IncreasePlayCount(int x)
		{
			this.playCount = x;
		}
		public void PrintVideoDetails()
		{
			Console.WriteLine("ID Lagu = " + this.id);
			Console.WriteLine("Judul Lagu = "+this.title);
			Console.WriteLine("Total Play Count = " + this.playCount);
		}
	}
}
