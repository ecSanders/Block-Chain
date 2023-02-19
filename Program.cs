using System;
using System.Collections.Generic;

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

      while(true){
        
        // Get input
        Console.Write("Make a transaction: ");
        input = Console.ReadLine();
        Console.Write("\n");

        // Check condition
        if (input == ""){
          break;
        }

        // Complete the transaction
        chain.Mine(input);
      }

      Console.WriteLine("================ BLOCKCHAIN PROGRAM FINISHED ===============");
    }
    
  }
}