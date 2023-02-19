using System;
using System.Text;
using System.Security.Cryptography;


namespace BlockChain;

public class Block{
    public int sequence;
    public List<string> transactions;
    private readonly DateTime _timeStamp; 
    public string PreviousHash { get; set; }
    public string Hash { get; private set; }

    // BLock constructor
    public Block(DateTime timestamp, string PrevHash, string order){
        Console.WriteLine("---------------- Block Created -----------------------------");

        transactions?.Add(order);
        _timeStamp = timestamp;
        PreviousHash = PrevHash;
        Hash = computeHash(PrevHash);
    }

    // Compute a SHA256 hash using block attributes
    public string computeHash(string prev){
        string hash = PreviousHash + _timeStamp + prev + sequence;
        string real_hash = "";
        // Initialize a SHA256 hash object
        using (SHA256 sha256 = SHA256.Create()){
            // Compute the hash of the given string
            byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(hash));
 
            // Convert the byte array to string format
            foreach (byte b in hashValue) {
                real_hash += $"{b:X2}";
            }
        }
        return "000" + real_hash;

    }
}