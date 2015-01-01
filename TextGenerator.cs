using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUcu.LilTextGen.Entity;

namespace WebUcu.LilTextGen
{
    /// <summary>
    /// Text generator object.
    /// </summary>
    public class TextGenerator
    {
        /// <summary>
        /// Text generation inputs.
        /// </summary>
        public TextGenerationInput Input { set; get; }

        /// <summary>
        /// Text generation outputs.
        /// </summary>
        public TextGenerationResult Result { get; private set; }

        public TextGenerator(TextGenerationInput input)
        {
            Input = input;
            Result = new TextGenerationResult();
        }

        /// <summary>
        /// Generates text by inputs.
        /// </summary>
        /// <returns></returns>
        public TextGenerationResult Generate()
        {
            foreach (string inputLine in Input.InputLines)
            {
                string modifiedInputLine = inputLine.Replace("\n", "");
                if (modifiedInputLine.Length > 0)
                {
                    string resultText = inputLine;
                    string[] inputValues = modifiedInputLine.Split(',');
                    if (inputValues.Length > 0)
                    {
                        resultText = String.Format(Input.Template, inputValues);
                    }
                    else
                    {
                        // No parameters, just generates template : 
                        resultText = Input.Template;
                    }
                    Result.Results.Add(resultText);
                }
            }
            return Result;
        }
    }
}
