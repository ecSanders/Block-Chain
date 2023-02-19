# Overview

This is a crude implementation of a blockchain using C#. 

The program create 3 classes. The `Block`, `BlockChain`, and `Program` classes are each created for different purposes. The `Block` class is used to store relavent information. The `BlockChain` utilizes a *Genesis Block* and the previous `Block`'s information to either create a new `Block` or start the chain.

I designed this software to better understand block chain technology.



[C# Blockchain Demo](https://www.loom.com/share/5ec7cc900e1f443fb857fbc91647dec0)

# Development Environment

VSCode was the IDE used to develope this software. We utilized the Cryptography library to compute our hashes. We used a SHA256 hashing algorithm.

# Useful Websites


- [StackOverFlow](https://stackoverflow.com/questions/28449564/how-to-use-class-from-other-files-in-c-sharp-with-visual-studio)
- [Microsoft](https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file)

# Future Work

- We need to add a proof of work in the blockchain
- Add users to the blockchain
- Potentially use a database to store and retrieve information
