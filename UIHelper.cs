using System;
using System.Media;
using System.Threading;

namespace ChatbotPart1
{
    /// <summary>
    /// Static UI Helper class for enhanced console interface - colors, effects, media (PROG6221 POE Part 1)
    /// </summary>
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

        /// <summary>
        /// Cyber-themed ASCII art logo for Cybersecurity Awareness Bot
        /// </summary>
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

        /// <summary>
        /// Play welcome voice greeting (expects welcome.wav in app dir)
        /// </summary>
        public static void PlayWelcomeSound()
        {
            try
            {
                using var player = new SoundPlayer("welcome.wav");
                player.PlaySync(); // Blocking play for intro effect
            }
            catch (FileNotFoundException)
            {
                ColorWriteLine("💻 Voice greeting ready! (Place 'welcome.wav' in bin/Debug/net8.0-windows for audio)", AppColor.Info);
                Thread.Sleep(1500); // Simulate audio duration
            }
            catch (Exception ex)
            {
                UIHelper.ColorWriteLine($"Audio init error: {ex.Message}", UIHelper.AppColor.Error);
                Thread.Sleep(1500); // Simulate audio duration
            }
        }

        /// <summary>
        /// Write line with color, auto-reset
        /// </summary>
        public static void ColorWriteLine(string text, AppColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(text);
            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// Typing effect simulation for conversational feel
        /// </summary>
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

        /// <summary>
        /// Draw horizontal/vertical border for sections
        /// </summary>
        public static void DrawBorder(int width = 60, char symbol = '═')
        {
            Console.WriteLine(new string(symbol, width));
        }

        /// <summary>
        /// Animated border effect for enhanced UX (polish)
        /// </summary>
        public static void AnimateBorder(int width = 60, char symbol = '═', int speedMs = 100)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(new string(' ', Console.WindowWidth)); // Clear line
                ColorWriteLine(new string(symbol, width), AppColor.Info);
                Thread.Sleep(speedMs);
            }
        }

        /// <summary>
        /// Display main menu of topics
        /// </summary>
        public static void ShowMenu()
        {
            ColorWriteLine("\n📋 Available Topics:", AppColor.Info);
            ColorWriteLine("🔑 Passwords | 📧 Phishing | 🌐 Safe Browsing", AppColor.Welcome);
            ColorWriteLine("🦠 Malware | 🧠 Social Engineering | 🔐 2FA", AppColor.Welcome);
            ColorWriteLine("🛡️ VPN | 💥 Ransomware | ⚡ Load Shedding | 🏦 Banking", AppColor.Welcome);
            ColorWriteLine("📱 Social Media | 📲 Updates | 'what can i ask' for more", AppColor.Info);
            DrawBorder(50, '─');
        }

        /// <summary>
        /// Display full logo with borders
        /// </summary>
        public static void DisplayLogo()
        {
            AnimateBorder();
            Console.WriteLine(Logo);
            DrawBorder();
            ShowMenu();
        }
    }
}

