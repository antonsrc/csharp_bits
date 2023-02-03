// Read from file
string[] lines = File.ReadLines("seq1_000_000.txt").ToArray();
int[] seq = lines.Select(s => Convert.ToInt32(s)).ToArray();
System.Console.WriteLine(seq[4]);