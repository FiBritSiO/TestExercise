using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestExercise
{
    public partial class Form1 : Form
    {
        private string savePath ;
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                savePath = folderBrowserDialog1.SelectedPath;
                saveFilePathLabel.Text = savePath;
            }

        }

        private void textGenerateButton_Click(object sender, EventArgs e)
        {
            string wordsPath = "RUS.txt";
            Random random = new Random();
            try              
            {
                if (Int32.Parse(minWordsCountTextBox.Text) < 0 || Int32.Parse(maxWordsCountTextBox.Text) < 0) throw new Exception("Число слов не должно быть отрицательным");
                if (Int32.Parse(fileCountTextBox.Text) <= 0) throw new Exception("Недопустимое кол-во файлов");
                if (savePath == null) throw new Exception("Выберете путь сохранения");
                WordsParser parser = new WordsParser(wordsPath);            
                FileWriter writer = new FileWriter(savePath);
                for(int i = 0; i < Int32.Parse(fileCountTextBox.Text);i++)
                writer.Write(parser.GetRandomWordsList(random.Next(Int32.Parse(minWordsCountTextBox.Text),Int32.Parse(maxWordsCountTextBox.Text)+1)));
                MessageBox.Show("Выполнено");
            }
            catch(FormatException)
            {
                MessageBox.Show("Неверно введены параметры");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
