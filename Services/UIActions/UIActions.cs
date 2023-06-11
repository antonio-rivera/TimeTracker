using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components;

namespace TimeTracker.Services.UIActions
{
    public partial class UIActions : IUIActions
    {
        public string? InitialHeight { get; set; }
        public string InitialWidth { get; set; }


        public void ExpandTextArea(ChangeEventArgs e, ref string width, ref string height)
        {
            SetWidth(e, ref width);
            SetWidth(e, ref height);
        }

        public void SetHeight(ChangeEventArgs e, ref string height)
        {
            InitialHeight = height;
            if (!string.IsNullOrEmpty((string?)e.Value))
            {
                string textValue = (string?)e.Value!;
                Regex newLines = MyRegex();
                MatchCollection lineMatches = newLines.Matches(textValue);
                int matchesCount = lineMatches.Count;

                if (matchesCount > 0)
                {
                    double newHeight = 52.4 + matchesCount * 50;
                    height = newHeight.ToString() + "px";
                }

                else if (matchesCount == 0)
                {
                    height = string.IsNullOrEmpty(InitialHeight) ? "10px" : InitialHeight;
                }
            }
        }

        public void SetWidth(ChangeEventArgs e, ref string width)
        {
            if (!string.IsNullOrEmpty((string?)e.Value))
            {
                string text = (string?)e.Value!;
                int x = text.Length;
                double newWidth = 35 * Math.Sqrt(x) + 30;
                width = newWidth.ToString() + "px";

            }
        }

        [GeneratedRegex("\\n")]
        private static partial Regex MyRegex();
    }
}

