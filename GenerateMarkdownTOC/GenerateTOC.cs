using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GenerateMarkdownTOC
{
    class GenerateTOC
    {
        public static string TOC(string Filepath, bool SaveToFile)
        {
            List<string> Elements = new List<string>();
            List<int> ElementsHierarchy = new List<int>();
            StringBuilder OutputFileStringbuilder = new StringBuilder();
            StringBuilder TocStringBuilder = new StringBuilder();
            using (StreamReader CurrentStreamReader = new StreamReader(Filepath))
            {
                bool Continue = true;
                while (Continue)
                {
                    string Currentline = CurrentStreamReader.ReadLine();
                    if (Currentline == null)
                    {
                        Continue = false;
                        break;
                    }
                    if (SaveToFile)
                    {
                        OutputFileStringbuilder.AppendLine(Currentline);
                    }
                    if (Currentline.Trim().Length > 0 && Currentline.Trim()[0] == '#')
                    {
                        int Hierarchy = -1;
                        for (int i = 0; i < Currentline.Trim().Length; i++)
                        {
                            if (Currentline.Trim()[i] == '#')
                            {
                                Hierarchy++;
                            }
                            else
                            {
                                ElementsHierarchy.Add(Hierarchy);
                                Elements.Add(Currentline.Trim().TrimEnd('#').TrimStart('#').Trim());
                                break;
                            }
                        }
                    }
                }
                TocStringBuilder.AppendLine("**Table of Contents**");
                TocStringBuilder.AppendLine("");
                for (int i = 0; i < Elements.Count; i++)
                {
                    TocStringBuilder.AppendLine(new string('\t', ElementsHierarchy[i]) + "- " + "[" + Elements[i] + "]" + "(#" + Elements[i].Replace(' ', '-').Replace(".", "").Replace("(", "").Replace(")", "").ToLower() + ")");
                }
            }
            if (SaveToFile)
            {
                using (StreamWriter CurrentFileStreamWriter = new StreamWriter(Filepath, false))
                {
                    CurrentFileStreamWriter.WriteLine(TocStringBuilder.ToString());
                    CurrentFileStreamWriter.WriteLine(OutputFileStringbuilder.ToString());
                }
            }
            return TocStringBuilder.ToString();

        }
    }
}
