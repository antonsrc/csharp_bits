// sequence of numbers
int[] seq = Enumerable.Range(1, 1000000).ToArray();
string[] seq_s = seq.Select(i => i.ToString()).ToArray();

//random numbers
int[] rnd = new int[1000000];
Random RND = new Random();
for (int i = 0; i < 1000000; i++) {
    rnd[i] = RND.Next(1, 1000000);
}
string[] rnd_s = rnd.Select(i => i.ToString()).ToArray();

string pathS = "seq1_000_000.txt";
File.AppendAllLines(pathS, seq_s);

string pathR = "rnd1_000_000.txt";
File.AppendAllLines(pathR, rnd_s);