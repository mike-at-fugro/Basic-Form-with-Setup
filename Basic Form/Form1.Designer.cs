namespace Basic_Form
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
            btnChangeText = new Button();
            lblTitle = new Label();
            tbInput = new TextBox();
            SuspendLayout();
            // 
            // btnChangeText
            // 
            btnChangeText.Location = new Point(150, 166);
            btnChangeText.Name = "btnChangeText";
            btnChangeText.Size = new Size(83, 88);
            btnChangeText.TabIndex = 0;
            btnChangeText.Text = "Click Me!";
            btnChangeText.UseVisualStyleBackColor = true;
            btnChangeText.Click += btnChangeText_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(62, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(71, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "I Am A Title!";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(62, 100);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(259, 23);
            tbInput.TabIndex = 2;
            tbInput.Text = "Insert Text By Yer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(tbInput);
            Controls.Add(lblTitle);
            Controls.Add(btnChangeText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeText;
        private Label lblTitle;
        private TextBox tbInput;
    }
}
