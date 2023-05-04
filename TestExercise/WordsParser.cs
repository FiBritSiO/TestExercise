using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace TestExercise
{
    internal class WordsParser
    {
        private List<string> words = new List<string>();
        private Random random = new Random();
        public WordsParser(string wordsFilePath)
        {
           using(StreamReader reader= new StreamReader(wordsFilePath,Encoding.Default))
            {
                while (!reader.EndOfStream)
                {
                    words.Add(reader.ReadLine());
                }
            }
        }
        public List<string> GetRandomWordsList(int n)
        {        
            List<string> randomWords = new List<string>();
            for (int i = 0; i < n;i++) randomWords.Add(words[random.Next(words.Count)]);
            return randomWords ;
            
        }
    }
}
