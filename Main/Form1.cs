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
            string result = logic.ReverseWords(input);

            if (result == "")
                MessageBox.Show("Ошибка!");
            else
                labelResult.Text = result;
        }
    }

    public class Logic
    {
        public string ReverseWords(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return "";

            sentence = sentence.Trim();
            string[] words = sentence.Split(' ');
            string[] reversedWords = new string[words.Length];

            int j = 0;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i] != "")
                {
                    reversedWords[j] = words[i];
                    j++;
                }
            }

            string result = "";
            for (int i = 0; i < j; i++)
            {
                result += reversedWords[i];
                if (i < j - 1)
                    result += " ";
            }

            return result;
        }
    }
}
