using System;

namespace CaesarCipher
{
  class Cipher
  {
    static void Main(string[] args)
    {
      //Encrypts a message using Caesar Cipher encryption
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      //Input your message
      Console.WriteLine("Enter the secret message: ");
      string secretMessageString = Console.ReadLine();
      char[] secretMessage = secretMessageString.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];

      for(int i=0; i<secretMessage.Length; i++)
      {
        char currentChar = secretMessage[i];
        int alphabetIndex = Array.IndexOf(alphabet, currentChar);
        int newAlphabetIndex = (alphabetIndex + 3) % 26;
        char newChar = alphabet[newAlphabetIndex];
        encryptedMessage[i] = newChar;
      }

      //Print the encrypted message
      Console.WriteLine(String.Join("", encryptedMessage));
    }
  }
}