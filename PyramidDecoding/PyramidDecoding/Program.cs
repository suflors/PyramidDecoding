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
			for (int i = 0; i < words.Count; i++)
			{
				var word = words[i + 1];
				Console.WriteLine($"{i + 1} {word}");
			}
		}
	}
}