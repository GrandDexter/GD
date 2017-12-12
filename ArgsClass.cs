using System;

namespace GD{
	public class ArgsClass{
		public static int Main(string[] args){
			for(int i = 0; i < args.Length; i++){
				Console.WriteLine(args[i]);
			}
			Console.ReadLine();
			return 0;
		}
	}
}