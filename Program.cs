using System;

namespace ChatbotPart1
{
    /// <summary>
    /// Full implementation - PROG6221 POE Part 1: Voice, ASCII, interaction, responses, UI (10+15+10+15+10+15 marks)
    /// Classes used: UIHelper, CybersecurityBot. Run: dotnet run (place welcome.wav)
    /// Emojis for visual indicators as requested. Enhanced with borders, SA responses.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fix emoji display: Set UTF-8 encoding for Windows Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // Intro: Voice + Logo (10 marks)
            UIHelper.PlayWelcomeSound();
            UIHelper.DisplayLogo();

            // Greet & personalize (10 marks)
            UIHelper.ColorWriteLine("🤖 Hello! What is your name?", UIHelper.AppColor.Welcome);
            string? nameInput;
            do
            {
                UIHelper.ColorWriteLine("👤 Enter your name: ", UIHelper.AppColor.User);
                nameInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nameInput))
                {
                    break;
                }
                UIHelper.ColorWriteLine("❌ Please enter your name to start chatting!", UIHelper.AppColor.Error);
            } while (true);

            var bot = new CybersecurityBot { UserName = nameInput!.Trim() };
            // Text greeting after ASCII/audio/name (rubric)
            UIHelper.TypingEffect($"🌟 Welcome, {bot.UserName}! Lets Engage more to help you to be aware about Cyber Security Attacks - now with SA topics like load shedding & banking scams! Type 'menu' for topics, 'exit' to quit. 🔒", UIHelper.AppColor.Welcome);
            UIHelper.ShowMenu();

            // Main loop with borders (enhanced UI)
            UIHelper.DrawBorder(60, '─');
            string? input;
            while (true)
            {
                UIHelper.ColorWriteLine("\n💬 You say: ", UIHelper.AppColor.User);
                input = Console.ReadLine();
                if (bot.ShouldExit(input ?? string.Empty))
                {
                    UIHelper.TypingEffect($"👋 Goodbye, {bot.UserName}! Stay safe online! 🔒", UIHelper.AppColor.Bot);
                    break;
                }

                string response = bot.GetResponse(input ?? string.Empty);
                UIHelper.TypingEffect($"🤖 {response}", UIHelper.AppColor.Bot);
            }
            UIHelper.DrawBorder(60, '─');

            UIHelper.ColorWriteLine("\n👋 Thanks for chatting! Press Enter to exit...", UIHelper.AppColor.Info);
            Console.ReadLine();
        }
    }
}
