using System;
using System.IO;
namespace rot47_sample
{
	class SampleProgram
	{
		public static void Main(string[] args)
		{
			string d = "";
			if (System.Console.IsInputRedirected)
			{
				var ts = Console.In;
				d = ts.ReadToEnd();
				ts.Close();
			}
			else if (args.Length > 0)
			{
				foreach (string a in args)
				{
					d += a;
				}
			}
			else {
				return;
			}

			if (d != "")
			{
				Console.Write(rot47.rot47.rot47_it(d));
			}
			return;
		}
	}
}