using System;

namespace BlockChain{
class BlockChain{
    // The chain
    public List<Block> Chain { get; set; }

    // Class constructor
    public BlockChain(){
        Chain = new List<Block> {GenesisBlock()};
    }
    
    // Add to the chain
    public void Mine(string s){
        Chain.Add(new Block(DateTime.Now, Chain.Last().Hash, s));
        Console.WriteLine();

        Block lastBlock = Chain.Last();
        Console.WriteLine("Hash:          " + lastBlock.Hash);
        Console.WriteLine("Previous Hash: " + lastBlock.PreviousHash);
        Console.WriteLine("Transaction:   " + s + "\n");
    }

    // Initialize the chain
    public Block GenesisBlock(){
        Console.WriteLine("\n       --------- Blockchain Initialized ---------\n");

        return new Block(DateTime.Now, "000", "NULL");
    }
}
}