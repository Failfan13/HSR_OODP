// class DNA {
//     public string Seq;

//     public DNA(string seq) => Seq = seq;
// }

// class Program {
//     public static void Main() {
//         List<DNA> seqList = new List<DNA> {
//             new DNA("ACGT"),
//             new DNA("GCTTAC"),
//             new DNA("CGTTAGCTT"),
//             new DNA("TACA")
//         };
//         int input = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("The filtered list:");
//         foreach(var seq in seqList.Where(s => s.Seq.Length >= input)) {
//             Console.WriteLine(seq.Seq);
//         }
//     }
// }