using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingstruct
{
	public class program2
	{
		public struct UserLocation
		{
			int x;
			int y;
			int z;
		}
		public static void Main()
		{
			Dictionary<String, UserLocation> userLocations = new Dictionary<String, UserLocation>();
			Console.WriteLine("created");
			Console.ReadKey();
		}
	}
}