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
			int outputtedWords = 0;
			int count = 1;
			for (int i = 1; i < words.Count + 1; i++)
			{
				if (count - outputtedWords > 0)
				{
					count = 1;
					outputtedWords++;
					output += words[i] + ' ';
				} else
				{
					count++;
				}
			}
			Console.WriteLine(output);
		}
	}
}