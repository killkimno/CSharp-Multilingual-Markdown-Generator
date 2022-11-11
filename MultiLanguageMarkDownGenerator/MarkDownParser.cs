using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageMarkDownGenerator
{
    internal class MarkDownParser
    {
        private struct LanguageInformation
        {
            public LanguageType LanguageType;
            public string FileName;
            public string Display;

            public LanguageInformation(LanguageType languageType, string fileName, string display)
            {
                LanguageType = languageType;
                FileName = fileName;
                Display = display;
            }
        }

        public enum CommandType
        {
            None,
            Language,
            Igonore,
            DcoumentLink
        }

        public enum LanguageType
        {
            En,
            Kr,
            Jp,
            Fr,
            Common,
            Error
        }


        private const string KeyLanguageStart = "<!--";
        private const string KeyEn = "<!--[en-US]-->";
        private const string KeyKo = "<!--[ko-KR]-->";
        private const string KeyJp = "<!--[ja-JP]-->";
        private const string KeyFr = "<!--[fr-FR]-->";
        private const string KeyCommon = "<!--[common]-->";
        private const string KeyIgonre = "<!--[ignore]-->";
        private const string KeyLink = "<!--[document_link]-->";


        private Dictionary<LanguageType, bool> _usingLanguage = new Dictionary<LanguageType, bool>();
        private Dictionary<LanguageType, StringBuilder> _dataDic = new Dictionary<LanguageType, StringBuilder>();
        private Dictionary<LanguageType, LanguageInformation> _infoDic = new Dictionary<LanguageType, LanguageInformation>();
        private string _baseFileName;


        private void Init()
        {
            _infoDic.Clear();
            _usingLanguage.Clear();
            _dataDic.Clear();

            _infoDic.Add(LanguageType.Kr, new LanguageInformation(LanguageType.Kr, "ko-KR", "한국어"));
            _infoDic.Add(LanguageType.En, new LanguageInformation(LanguageType.En, "en-US", "English"));
            _infoDic.Add(LanguageType.Jp, new LanguageInformation(LanguageType.Jp, "ja-JP", "日本語"));
            _infoDic.Add(LanguageType.Fr, new LanguageInformation(LanguageType.Fr, "fr-FR", "Français"));
        }


        public void GenerateDocument(string filePath, string baseFileName, LanguageType mainLanguage)
        {
            Init();
            _baseFileName = baseFileName;
            //두번 읽는다.
            string[] lines = System.IO.File.ReadAllLines(filePath);
            InitializeLanguage(lines);
            ParseLines(lines);

            //저장한다
            string savePath = Path.GetDirectoryName(filePath) + @"\";
            foreach (var pair in _dataDic)
            {
                string fileName = $"{_baseFileName}.{_infoDic[pair.Key].FileName}.md";

                System.IO.File.WriteAllText($@"{savePath}{fileName}", pair.Value.ToString());
            }

            if(!_dataDic.ContainsKey(mainLanguage))
            {
                mainLanguage = _dataDic.First().Key;
            }


            System.IO.File.WriteAllText($@"{savePath}{_baseFileName}.md", _dataDic[mainLanguage].ToString());

        }

        private CommandType ParaseCommand(string line)
        {
            if (line == KeyIgonre)
            {
                return CommandType.Igonore;
            }

            if(line == KeyLink)
            {
                return CommandType.DcoumentLink;
            }

            if (line.Substring(0, Math.Min(KeyLanguageStart.Length, line.Length)) == KeyLanguageStart)
            {
                return CommandType.Language;
            }

            return CommandType.None;
        }

        private LanguageType ParseLanguage(string line)
        {
            switch (line)
            {
                case KeyEn:
                    return LanguageType.En;

                case KeyKo:
                    return LanguageType.Kr;

                case KeyJp:
                    return LanguageType.Jp;

                case KeyFr:
                    return LanguageType.Fr;

                case KeyCommon:
                    return LanguageType.Common;

            }

            //이게 맞나??
            return LanguageType.Common;
        }


        private void InitializeLanguage(string[] lines)
        {
            foreach (string readLine in lines)
            {
                string line = readLine.Replace(" ", "");

                switch (line)
                {
                    case KeyEn:
                        _usingLanguage[LanguageType.En] = true;
                        break;

                    case KeyKo:
                        _usingLanguage[LanguageType.Kr] = true;
                        break;

                    case KeyJp:
                        _usingLanguage[LanguageType.Jp] = true;
                        break;

                    case KeyFr:
                        _usingLanguage[LanguageType.Fr] = true;
                        break;
                }
            }
        }

        private void ParseLines(string[] lines)
        {
            foreach (var pari in _usingLanguage)
            {
                _dataDic[pari.Key] = new StringBuilder();
            }

            LanguageType currentLanguage = LanguageType.Common;
            CommandType currentCommand = CommandType.None;

            foreach (var readLine in lines)
            {
                string line = readLine.Replace(" ", "");
                CommandType command = ParaseCommand(line);

                if (currentCommand == CommandType.Igonore && command == CommandType.None)
                {
                    //이전 명령어가 무시고 새로 얻은 명령어가 일반이면 넘긴다 -> 명령어가 바뀔때까지 뺑뺑이
                    continue;
                }

                currentCommand = command;

                switch (currentCommand)
                {
                    case CommandType.Igonore:
                        continue;

                    case CommandType.Language:
                        var language = ParseLanguage(line);

                        if (language != LanguageType.Error)
                        {
                            currentLanguage = language;
                        }

                        break;

                    case CommandType.DcoumentLink:
                        AddDocumentLink();
                        break;

                    case CommandType.None:

                        //여러 언어를 예약하는 기능은 후에 만들자
                        //데이터나 넣는다
                        //공용 + 현재 언어

                        if (currentLanguage != LanguageType.Common)
                        {
                            _dataDic[currentLanguage].AppendLine(readLine);
                        }
                        else
                        {
                            foreach (var pair in _dataDic)
                            {
                                pair.Value.AppendLine(readLine);
                            }
                        }
                        break;
                }
            }
        }

        private void AddDocumentLink()
        {
            string link = "";
            foreach (var pair in _usingLanguage)
            {
                string display = _infoDic[pair.Key].Display;
                string fileName = $"{_baseFileName}.{_infoDic[pair.Key].FileName}.md";

                link += $"[{display}]({fileName}){System.Environment.NewLine}";
              
            }

            //TODO : 현재 선택한 주 언어는 제외해야 한다
            foreach (var pair in _dataDic)
            {
                pair.Value.AppendLine(link);
            }
        }
    }
}
