namespace TestExercise
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.minWordsCountTextBox = new System.Windows.Forms.TextBox();
            this.maxWordsCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textGenerateButton = new System.Windows.Forms.Button();
            this.fileCountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFilePathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFolderButton.Location = new System.Drawing.Point(49, 111);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(255, 94);
            this.chooseFolderButton.TabIndex = 0;
            this.chooseFolderButton.Text = "Выбрать путь сохранения файлов";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // minWordsCountTextBox
            // 
            this.minWordsCountTextBox.Location = new System.Drawing.Point(791, 118);
            this.minWordsCountTextBox.Name = "minWordsCountTextBox";
            this.minWordsCountTextBox.Size = new System.Drawing.Size(56, 22);
            this.minWordsCountTextBox.TabIndex = 2;
            // 
            // maxWordsCountTextBox
            // 
            this.maxWordsCountTextBox.Location = new System.Drawing.Point(791, 190);
            this.maxWordsCountTextBox.Name = "maxWordsCountTextBox";
            this.maxWordsCountTextBox.Size = new System.Drawing.Size(56, 22);
            this.maxWordsCountTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(473, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Минимальное число слов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(463, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Максимальное число слов\r\n";
            // 
            // textGenerateButton
            // 
            this.textGenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textGenerateButton.Location = new System.Drawing.Point(51, 233);
            this.textGenerateButton.Name = "textGenerateButton";
            this.textGenerateButton.Size = new System.Drawing.Size(253, 84);
            this.textGenerateButton.TabIndex = 6;
            this.textGenerateButton.Text = "Сгенерировать файлы";
            this.textGenerateButton.UseVisualStyleBackColor = true;
            this.textGenerateButton.Click += new System.EventHandler(this.textGenerateButton_Click);
            // 
            // fileCountTextBox
            // 
            this.fileCountTextBox.Location = new System.Drawing.Point(791, 259);
            this.fileCountTextBox.Name = "fileCountTextBox";
            this.fileCountTextBox.Size = new System.Drawing.Size(56, 22);
            this.fileCountTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(598, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Число файлов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Путь сохранения: ";
            // 
            // saveFilePathLabel
            // 
            this.saveFilePathLabel.AutoSize = true;
            this.saveFilePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFilePathLabel.Location = new System.Drawing.Point(223, 70);
            this.saveFilePathLabel.Name = "saveFilePathLabel";
            this.saveFilePathLabel.Size = new System.Drawing.Size(17, 25);
            this.saveFilePathLabel.TabIndex = 10;
            this.saveFilePathLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 533);
            this.Controls.Add(this.saveFilePathLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileCountTextBox);
            this.Controls.Add(this.textGenerateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxWordsCountTextBox);
            this.Controls.Add(this.minWordsCountTextBox);
            this.Controls.Add(this.chooseFolderButton);
            this.Name = "Form1";
            this.Text = "Текстовый генератор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox minWordsCountTextBox;
        private System.Windows.Forms.TextBox maxWordsCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button textGenerateButton;
        private System.Windows.Forms.TextBox fileCountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label saveFilePathLabel;
    }
}

