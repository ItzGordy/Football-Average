using System;

namespace Average
{
	class MainClass
	{
		public static void Main(string[] args)
		{
		start:
			Console.WriteLine("Enter Players Name: ");
			string NamePlayer = Console.ReadLine();

			Console.WriteLine("How many goals did " + NamePlayer +" Score: ");
			int GoalsScored = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Great, " + NamePlayer + " Scored " + GoalsScored + " Goals!");

			Console.WriteLine("How many games did " + NamePlayer + " Play in:");
			int GamesPlayed = Convert.ToInt32(Console.ReadLine());

			int average = GoalsScored / GamesPlayed;

			Console.WriteLine("OK, " + NamePlayer + " Scored " + GoalsScored + " Goals and played in " + GamesPlayed + " Games.");
			Console.WriteLine("He scored an average of " + average + " Goals a game");

			Console.WriteLine("<Press Any Key to Continue>");
			Console.ReadLine();
			goto start;
		}
	}
}
