using System;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxInput.Text = Properties.Settings.Default.text;
        }
        private void buttonReverse_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            Properties.Settings.Default.text = input;
            Properties.Settings.Default.Save();

            Logic logic = new Logic();

            if (!logic.HasWords(input))
            {
                MessageBox.Show("Ошибка: Введите текст!");
                return;
            }
            string result = logic.ReverseWords(input);

            if (result == "")
            {
                MessageBox.Show("Ошибка: В предложении нет слов!");
            }
            else
            {
                labelResult.Text = result;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            labelResult.Text = "Результат";
            textBoxInput.Focus();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl == buttonClear)
                {
                    buttonClear.PerformClick();
                    textBoxInput.Focus();
                }
                else
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                }

                e.SuppressKeyPress = true;
            }
        }
    }
    public class Logic
    {
        public string ReverseWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return "";

            var words = sentence
                .Trim()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            return string.Join(" ", words);
        }
        public bool HasWords(string sentence)
        {
            if (sentence == null || sentence == "")
                return false;

            string trimmedSentence = sentence.Trim();
            return trimmedSentence != "";
        }
    }
}