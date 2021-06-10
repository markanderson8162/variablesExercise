using System;

namespace VariablesExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			string movieName = "The Incredibles";
			int releaseDate = 2004;
			char firstInitial = 'i';
			bool isAnimated = true;
			double worldwideGross = 631.4;
			decimal budget = 92;


			Console.WriteLine($"My favorite movie is {movieName}. It released in {releaseDate}, it starts with {firstInitial}, " +
				$"it's budget was {budget} million dollars, and worldwide it grossed {worldwideGross} million dollars. " +
				$"If someone said \"True or False, The Incredibles is animated.\", I would say {isAnimated}.");
		}
	}
}
