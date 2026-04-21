namespace Main
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxInput = new TextBox();
            buttonReverse = new Button();
            buttonClear = new Button();
            labelResult = new Label();
            labelTask = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(30, 27);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(298, 23);
            textBoxInput.TabIndex = 0;
            // 
            // buttonReverse
            // 
            buttonReverse.Location = new Point(134, 56);
            buttonReverse.Name = "buttonReverse";
            buttonReverse.Size = new Size(100, 25);
            buttonReverse.TabIndex = 1;
            buttonReverse.Text = "Запустить";
            buttonReverse.UseVisualStyleBackColor = true;
            buttonReverse.Click += buttonReverse_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(286, 122);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 25);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(39, 90);
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
            labelTask.Size = new Size(338, 15);
            labelTask.TabIndex = 3;
            labelTask.Text = "Введите предложение. Программа развернет порядок слов.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 159);
            Controls.Add(textBoxInput);
            Controls.Add(buttonReverse);
            Controls.Add(buttonClear);
            Controls.Add(labelResult);
            Controls.Add(labelTask);
            KeyPreview = true;
            Name = "Form1";
            Text = "Разворот слов";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxInput;
        private Button buttonReverse;
        private Button buttonClear;
        private Label labelResult;
        private Label labelTask;
    }
}