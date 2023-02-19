
namespace BlockChain
{
  class Program
  {
    static void Main(string[] args){
      Console.WriteLine("================ BLOCKCHAIN PROGRAM STARTED ================");

      // Initialize blockchain
      BlockChain chain = new BlockChain();   

      // Starting value to kick off chain
      string? input = "valid";

      StreamWriter sw = new StreamWriter("document.txt");

      while(true){
        
        // Get input
        Console.Write("Make a transaction: ");
        input = Console.ReadLine();
        Console.Write("\n");

        // Check condition
        if (input == ""){
          break;
        }

        sw.WriteLine(input);
        sw.WriteLine(chain.Chain.Last().Hash);


        // Complete the transaction
        chain.Mine(input);
      }
      sw.Close();
      Console.WriteLine("================ BLOCKCHAIN PROGRAM FINISHED ===============");
      readDoc();
    }

    static void readDoc(){
      String line;
      StreamReader sr = new StreamReader("document.txt");
      line = sr.ReadLine();
      while (line != null){
          Console.WriteLine(line);
          line = sr.ReadLine();
      }

      sr.Close();
      Console.ReadLine();
    }
  }
}