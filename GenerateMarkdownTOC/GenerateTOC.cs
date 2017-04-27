using System.Collections.Generic;
using System.Text;
using System.IO;


namespace GenerateMarkdownTOC
{
    class GenerateToc
    {
        public static string Toc(string filepath, bool saveToFile)
        {
            var elements = new List<string>();
            var elementsHierarchy = new List<int>();
            var outputFileStringbuilder = new StringBuilder();
            var tocStringBuilder = new StringBuilder();
            using (var currentStreamReader = new StreamReader(filepath))
            {
                while (true)
                {
                    var currentline = currentStreamReader.ReadLine();
                    if (currentline == null)
                    {
                        break;
                    }
                    if (saveToFile)
                    {
                        outputFileStringbuilder.AppendLine(currentline);
                    }
                    if (currentline.Trim().Length > 0 && currentline.Trim()[0] == '#')
                    {
                        var hierarchy = -1;
                        for (var i = 0; i < currentline.Trim().Length; i++)
                        {
                            if (currentline.Trim()[i] == '#')
                            {
                                hierarchy++;
                            }
                            else
                            {
                                elementsHierarchy.Add(hierarchy);
                                elements.Add(currentline.Trim().TrimEnd('#').TrimStart('#').Trim());
                                break;
                            }
                        }
                    }
                }
                tocStringBuilder.AppendLine("**Table of Contents**");
                tocStringBuilder.AppendLine("");
                for (var i = 0; i < elements.Count; i++)
                {
                    tocStringBuilder.AppendLine(new string('\t', elementsHierarchy[i]) + "- " + "[" + elements[i] + "]" + "(#" + elements[i].Replace(' ', '-').Replace(".", "").Replace("(", "").Replace(")", "").ToLower() + ")");
                }
            }
            if (saveToFile)
            {
                using (var currentFileStreamWriter = new StreamWriter(filepath, false))
                {
                    currentFileStreamWriter.WriteLine(tocStringBuilder.ToString());
                    currentFileStreamWriter.WriteLine(outputFileStringbuilder.ToString());
                }
            }
            return tocStringBuilder.ToString();

        }
    }
}
