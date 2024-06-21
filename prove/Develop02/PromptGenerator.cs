using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?",
                                                    "What was the best part of my day?",
                                                    "How did I see the hand of the Lord in my life today?",
                                                    "What was the strongest emotion I felt today?",
                                                    "If I had one thing I could do over today, what would it be?",
                                                    "What did I do today that I am proud of?",
                                                    "What was the most surprising thing that happened today?",
                                                    "What was the most interesting thing I saw or heard today?",
                                                    "What did I learn today?",
                                                    "What was the worst thing that happened today?",
                                                    "What is something I am grateful for right now?",
                                                    "What’s the best thing that could happen to me tomorrow?",
                                                    "What’s my happy place and why?",
                                                    "What did you see today that was beautiful?",
                                                    "Did I offer assistance to anyoune today?",
                                                    "What does it mean to truly embody self-love and body positivity, and how can I take small steps towards this every day?",
                                                    "What is one small creative project that I can do today, and how can I make it unique to my personal style?"};

    public string GetRandomPrompt()
    {
        var random = new Random();
        int count = _prompts.Count;

        int randomPrompt = random.Next(count);
        return _prompts[randomPrompt];

    }
}