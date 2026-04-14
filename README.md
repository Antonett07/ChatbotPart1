# 🔒 Cybersecurity Awareness Chatbot 🔒

[![.NET CI](https://github.com/YOUR_USERNAME/ChatbotPart1/actions/workflows/ci.yml/badge.svg)](https://github.com/YOUR_USERNAME/ChatbotPart1/actions) [![Tests](https://github.com/YOUR_USERNAME/ChatbotPart1/workflows/CI/badge.svg)](https://github.com/YOUR_USERNAME/ChatbotPart1/actions/workflows/ci.yml)

## 📖 Overview
**ChatbotPart1** is a console-based **Cybersecurity Awareness Chatbot** developed for **PROG6221 POE Part 1** (Programming assignment). It educates South African users on essential cybersecurity topics like phishing, passwords, malware, and local threats (e.g., load shedding scams, banking fraud). Features voice intro, ASCII art, interactive UI with typing effects, emojis, and keyword-based responses.

**Marks Coverage**:
- Voice/ASCII (10+15 marks)
- Interaction/UI (10+15 marks)
- Responses/Validation (15+15 marks)

## ✨ Features
- 🎵 **Voice Welcome**: Plays `welcome.wav` on startup (optional).
- 🎨 **Enhanced UI**: Colored console, typing effects, animated borders, cyber-themed ASCII logo.
- 🧠 **Smart Responses**: 20+ topics with exact/keyword/fuzzy matching, SA-specific (ransomware, load shedding, banks like FNB/Capitec).
- ✅ **Validation**: Input sanitization, length checks, graceful fallbacks.
- 🧪 **Tests**: Unit tests for bot logic + GitHub CI.
- 🇿🇦 **Local Context**: Banking scams, load shedding phishing, social media risks.

## 📸 Screenshots / Demo

### ASCII Logo
```
           
      ██████╗██╗  ██╗ █████╗ ████████╗██████╗  ██████╗ ████████╗
     ██╔════╝██║  ██║██╔══██╗╚══██╔══╝██╔══██╗██╔═══██╗╚══██╔══╝
     ██║     ███████║███████║   ██║   ██████╔╝██║   ██║   ██║   
     ██║     ██╔══██║██╔══██║   ██║   ██╔══██╗██║   ██║   ██║   
     ╚██████╗██║  ██║██║  ██║   ██║   ██████╔╝╚██████╔╝   ██║   
      ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
```

### Sample Chat
```
💬 You say: phishing
🤖 📧 Phishing emails/links trick you into sharing info. Check sender 👀, hover links (don't click), look for HTTPS 🔒. Report suspicious emails to authorities 🚨.

💬 You say: load shedding
🤖 ⚡ During loadshedding, phishing spikes & backups fail. Use UPS for PC, cloud backups (Google Drive), verify emails 2x. Offline mode training helps.
```

## 🛠 Quick Start

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Windows (for console/audio)
- `welcome.wav` (optional, place in `bin/Debug/net8.0-windows/`)

### Build & Run
```bash
# From project root
cd ChatbotPart1
dotnet restore
dotnet build
dotnet run  # Or ./bin/Debug/net8.0-windows/ChatbotPart1.exe
```

**Pro Tip**: Copy `welcome.wav` to `bin/Debug/net8.0-windows/` for voice intro. ✅ **CI**: After Git push, green checkmarks on [Actions tab](https://github.com/YOUR_USERNAME/ChatbotPart1/actions). Screenshot for rubric!

### Test
```bash
cd ChatbotPart1.Tests
dotnet test
```

## 📖 Usage
1. Run the app → Hear voice/logo → Enter name.
2. See menu/topics.
3. Chat! Type keywords like `phishing`, `password`, `2fa`, `banking`.
4. `exit`/`bye` to quit.

## 📋 Topics Covered
| Keyword | Topic |
|---------|-------|
| password | Strong passwords, 2FA, managers |
| phishing | Email/link verification, HTTPS |
| safe browsing | Updates, antivirus, VPN |
| malware | Scans, trusted downloads |
| social engineering | Verify requests |
| 2fa | Enable everywhere |
| vpn | Public WiFi encryption |
| ransomware | Backups, don't pay |
| load shedding | Offline prep, cloud backups |
| banking | OTP safety, fraud reporting |
| social media | Privacy, fake contests |
| updates | Patch vulnerabilities |

Full responses in `CybersecurityBot.cs`.

## 🗂 Project Structure
```
ChatbotPart1/
├── ChatbotPart1.csproj
├── Program.cs          # Entry point
├── CybersecurityBot.cs # Logic & responses
├── UIHelper.cs         # UI/Audio
├── ChatbotPart1.Tests/ # Unit tests
├── .github/workflows/  # CI
└── bin/Debug/...       # Built exe + welcome.wav
```

## 🤝 Contributing
Fork, PR with tests. Issues welcome!

## 📹 Video Presentation
**Rubric Required**: 8-10min unlisted YouTube video (voice-over, no AI voice). Demo: Run app, explain classes (UIHelper logo/sound, Bot responses/validation, Program loop). Link: [ADD_YOUR_YOUTUBE_UNLISTED_LINK_HERE](https://youtube.com/watch?v=PLACEHOLDER)

**Screenshot CI Green Run**: ![CI Success](https://github.com/YOUR_USERNAME/ChatbotPart1/actions/workflows/ci.yml/badge.svg) 

## 📄 License
MIT (or assignment rules apply).

**Stay safe online! 🔒🇿🇦 #CyberAware**

---


