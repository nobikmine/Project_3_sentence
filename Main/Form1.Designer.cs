namespace Main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInput = new TextBox();
            buttonReverse = new Button();
            labelResult = new Label();
            labelTask = new Label();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(47, 41);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(298, 23);
            textBoxInput.TabIndex = 0;
            // 
            // buttonReverse
            // 
            buttonReverse.Location = new Point(149, 84);
            buttonReverse.Name = "buttonReverse";
            buttonReverse.Size = new Size(75, 23);
            buttonReverse.TabIndex = 1;
            buttonReverse.Text = "Запустить";
            buttonReverse.UseVisualStyleBackColor = true;
            buttonReverse.Click += buttonReverse_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(149, 133);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 15);
            labelResult.TabIndex = 2;
            labelResult.Text = "Результат";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(12, 9);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(372, 15);
            labelTask.TabIndex = 3;
            labelTask.Text = "Введите предложение. Программа развернет порядок слов в нем.";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(287, 164);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 200);
            Controls.Add(buttonClear);
            Controls.Add(labelTask);
            Controls.Add(labelResult);
            Controls.Add(buttonReverse);
            Controls.Add(textBoxInput);
            KeyPreview = true;
            Name = "Form1";
            Text = "Разворот порядка слов";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox textBoxInput;
        private Button buttonReverse;
        private Label labelResult;
        private Label labelTask;
        private Button buttonClear;
    }
}
