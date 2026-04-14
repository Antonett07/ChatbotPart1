using System;
using System.Media;
using System.Threading;

namespace ChatbotPart1
{
    // Helper class for UI elements and interactions
    public static class UIHelper
    {
        public enum AppColor
        {
            Welcome = ConsoleColor.Yellow,
            Bot = ConsoleColor.Green,
            User = ConsoleColor.Cyan,
            Error = ConsoleColor.Red,
            Info = ConsoleColor.Gray
        }

        // ASCII art logo for the chatbot
        public const string Logo = @"
    ╔════════════════════════════════════════════════════╗
    ║                                                    ║
    ║   ██████╗██╗  ██╗██████╗  █████╗ ██████╗ ███████╗  ║
    ║  ██╔════╝██║ ██╔╝██╔══██╗██╔══██╗██╔══██╗██╔════╝  ║
    ║  ██║     █████╔╝ ██████╔╝███████║██║  ██║███████╗  ║
    ║  ██║     ██╔═██╗ ██╔══██╗██╔══██║██║  ██║╚════██║  ║
    ║  ╚██████╗██║  ██╗██║  ██║██║  ██║██████╔╝███████║  ║
    ║   ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝  ║
    ║                                                    ║
    ║        🔒 Cybersecurity Awareness Chatbot 🔒      ║
    ║                                                    ║
    ╚════════════════════════════════════════════════════╝
";

        // Method to play a welcome sound when the application starts
        public static void PlayWelcomeSound()
        {
            try
            {
                using var player = new SoundPlayer("welcome.wav");
                player.PlaySync(); 
            }
            catch (FileNotFoundException)
            {
                ColorWriteLine("💻 Voice greeting ready! (Place 'welcome.wav' in bin/Debug/net8.0-windows for audio)", AppColor.Info);
                Thread.Sleep(1500); 
            }
            catch (Exception ex)
            {
                UIHelper.ColorWriteLine($"Audio init error: {ex.Message}", UIHelper.AppColor.Error);
                Thread.Sleep(1500); 
            }
        }

        // Method to write colored text to the console
        public static void ColorWriteLine(string text, AppColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(text);
            Console.ForegroundColor = oldColor;
        }

        // Method to display text with a typing effect
        public static void TypingEffect(string text, AppColor color = AppColor.Bot, int delayMs = 50)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
            Console.ForegroundColor = oldColor;
        }

        // Method to draw a horizontal border in the console
        public static void DrawBorder(int width = 60, char symbol = '═')
        {
            Console.WriteLine(new string(symbol, width));
        }

        // Method to animate a border by printing it multiple times with a delay
        public static void AnimateBorder(int width = 60, char symbol = '═', int speedMs = 100)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(new string(' ', Console.WindowWidth)); 
                ColorWriteLine(new string(symbol, width), AppColor.Info);
                Thread.Sleep(speedMs);
            }
        }

        // Method to display the main menu of available topics
        public static void ShowMenu()
        {
            ColorWriteLine("\n📋 Available Topics:", AppColor.Info);
            ColorWriteLine("🔑 Passwords | 📧 Phishing | 🌐 Safe Browsing", AppColor.Welcome);
            ColorWriteLine("🦠 Malware | 🧠 Social Engineering | 🔐 2FA", AppColor.Welcome);
            ColorWriteLine("🛡️ VPN | 💥 Ransomware | ⚡ Load Shedding | 🏦 Banking", AppColor.Welcome);
            ColorWriteLine("📱 Social Media | 📲 Updates | 'what can i ask' for more", AppColor.Info);
            DrawBorder(50, '─');
        }

        // Method to display the logo with an animated border and then show the menu
        public static void DisplayLogo()
        {
            AnimateBorder();
            Console.WriteLine(Logo);
            DrawBorder();
            ShowMenu();
        }
    }
}

