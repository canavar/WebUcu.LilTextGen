using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUcu.LilTextGen.Entity
{
    /// <summary>
    /// Text generation request entity. Carries parameters that needed for text generation.
    /// </summary>
    public class TextGenerationInput
    {
        /// <summary>
        /// Comma seperated input lines.
        /// </summary>
        public List<string> InputLines { set; get; }

        /// <summary>
        /// Template to generate result text.
        /// </summary>
        public string Template { set; get; }

        public TextGenerationInput(string template, List<string> inputLines)
        {
            Template = template;
            InputLines = inputLines;
        }
    }
}
