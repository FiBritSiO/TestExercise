using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xceed.Words.NET;

namespace TestExercise
{
    internal class FileWriter
    {
        private readonly string fileCreatePath;
        public FileWriter (string fileCreatePath)
        {       
            this.fileCreatePath = fileCreatePath;
        }
        private string FileNameGenerator()
        {
            Random random= new Random();
            string FileName;
            do
            {
                FileName = String.Format("{0}{1}{2}{3}", fileCreatePath, "\\", random.Next().ToString(), ".docx");
            }
            while (File.Exists(FileName));
            return FileName;
        }
        public void Write(List<string> words)
        {
           Random random= new Random();
           string signs = ",.;:!? ";          
           DocX doc = DocX.Create(FileNameGenerator());
            string text = "";
           foreach (string word in words)
           {
                if (word == words.Last()) text += word; 
                else text +=String.Format("{0}{1} ", word, signs[random.Next(signs.Length)]);
            }
            doc.InsertParagraph(text);
            doc.Save();
         }
        }

    }

