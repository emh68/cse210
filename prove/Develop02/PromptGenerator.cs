using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public Random random = new Random();
    public List<string> prompts;
    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What is something interesting that happened to you today?",
            "What is something you did or accomplished today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }
    public string GetRandomPrompt()
    {
        int indexVal = random.Next(prompts.Count);
        return prompts[indexVal];
    }
}