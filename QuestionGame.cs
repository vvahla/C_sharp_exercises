using System;

namespace TrueOrFalse
{
  class QuestionGame
  {
		static void Main(string[] args)
    {
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {
        "Is Muikku the best cat?",
        "Is Resistace the best Ingress team?",
        "Do pineapples grow in trees?"
      };
      bool[] answers = {true, true, false};
      bool[] responses = new bool[questions.Length];

      if(questions.Length != answers.Length)
      {
        Console.WriteLine("Something went wrong");
      }

      int askingIndex = 0;

      foreach(string question in questions)
      {
        string input;
        bool isBool = true;
        bool inputBool;

        Console.WriteLine(question);
        Console.WriteLine("True or false?");
        input = Console.ReadLine();

        isBool = Boolean.TryParse(input, out inputBool);

        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      int scoringIndex = 0;
      int score = 0;

      foreach (bool answer in answers)
      {
        bool currentResponse = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex + 1}. Input: {currentResponse} | Answer: {answer}");

        if(currentResponse == answer) score++;

        scoringIndex++;
      }

      Console.WriteLine($"You got {score} out of 3 correct!");
    }
  }
}
