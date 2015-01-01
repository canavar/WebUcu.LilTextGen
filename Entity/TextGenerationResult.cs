using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUcu.LilTextGen.Entity
{
    /// <summary>
    /// Text generation output entity.
    /// </summary>
    public class TextGenerationResult
    {
        /// <summary>
        /// Result lines.
        /// </summary>
        public List<string> Results { set; get; }

        public TextGenerationResult()
        {
            Results = new List<string>();
        }

        public override string ToString()
        {
            return String.Join("\r\n", Results.ToArray<string>());
        }
    }
}
