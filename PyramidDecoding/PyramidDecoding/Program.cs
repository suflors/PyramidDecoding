namespace PyramidDecoding
{
	class Program
	{
		static void Main()
		{
			string filepath = "coding_qual_input.txt";
			string input = File.ReadAllText(filepath);
			string[] lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
			Dictionary<int, string> words = [];
			foreach (string line in lines)
			{
				string[] parts = line.Split(' ');
				words.Add(int.Parse(parts[0]), parts[1]);
			}
			string output = "";
			int step = 1;
			bool run = true;
			while (run)
			{
				int lastInCurrentStep = step * (step + 1) / 2;
				if (lastInCurrentStep <= words.Count())
				{
					output += words[lastInCurrentStep] + ' ';
					step++;
				} else
				{
					run = false;
				}
			}
			Console.WriteLine(output);
		}
	}
}