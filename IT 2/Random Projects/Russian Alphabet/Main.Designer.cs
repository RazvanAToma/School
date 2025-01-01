namespace Russian_Alphabet
{
    partial class RussianAlphabetTrainer
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
            StartButton = new Button();
            SettingsLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            ToggleCheck = new CheckBox();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 18F);
            StartButton.Location = new Point(340, 363);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(135, 46);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // SettingsLabel
            // 
            SettingsLabel.AutoSize = true;
            SettingsLabel.Font = new Font("Segoe UI", 24F);
            SettingsLabel.Location = new Point(340, 25);
            SettingsLabel.Name = "SettingsLabel";
            SettingsLabel.Size = new Size(135, 45);
            SettingsLabel.TabIndex = 1;
            SettingsLabel.Text = "Settings";
            SettingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(340, 25);
            label1.Name = "label1";
            label1.Size = new Size(135, 45);
            label1.TabIndex = 1;
            label1.Text = "Settings";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(340, 25);
            label2.Name = "label2";
            label2.Size = new Size(135, 45);
            label2.TabIndex = 1;
            label2.Text = "Settings";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ToggleCheck
            // 
            ToggleCheck.Appearance = Appearance.Button;
            ToggleCheck.Font = new Font("Segoe UI", 12F);
            ToggleCheck.Location = new Point(300, 176);
            ToggleCheck.Name = "ToggleCheck";
            ToggleCheck.Size = new Size(209, 41);
            ToggleCheck.TabIndex = 4;
            ToggleCheck.Text = "Click me!";
            ToggleCheck.TextAlign = ContentAlignment.MiddleCenter;
            ToggleCheck.UseVisualStyleBackColor = true;
            ToggleCheck.CheckedChanged += ToggleCheckBox_CheckedChanged;
            // 
            // RussianAlphabetTrainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ToggleCheck);
            Controls.Add(SettingsLabel);
            Controls.Add(StartButton);
            Name = "RussianAlphabetTrainer";
            Text = "Russian Alphabet Trainer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Label SettingsLabel;
        private Label label1;
        private Label label2;
        private CheckBox ToggleCheck;
    }
}
