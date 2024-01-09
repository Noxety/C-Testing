namespace Win
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
            text1 = new TextBox();
            text2 = new TextBox();
            butt1 = new Button();
            outcome = new Label();
            SuspendLayout();
            // 
            // text1
            // 
            text1.Location = new Point(12, 33);
            text1.Name = "text1";
            text1.Size = new Size(220, 23);
            text1.TabIndex = 0;
            // 
            // text2
            // 
            text2.Location = new Point(12, 93);
            text2.Name = "text2";
            text2.Size = new Size(220, 23);
            text2.TabIndex = 1;
            text2.TextChanged += text2_TextChanged;
            // 
            // butt1
            // 
            butt1.Location = new Point(382, 67);
            butt1.Name = "butt1";
            butt1.Size = new Size(75, 23);
            butt1.TabIndex = 2;
            butt1.Text = "Sum";
            butt1.UseVisualStyleBackColor = true;
            butt1.Click += butt1_Click;
            // 
            // outcome
            // 
            outcome.AutoSize = true;
            outcome.BackColor = SystemColors.ButtonFace;
            outcome.BorderStyle = BorderStyle.FixedSingle;
            outcome.Location = new Point(252, 169);
            outcome.Name = "outcome";
            outcome.Size = new Size(40, 17);
            outcome.TabIndex = 3;
            outcome.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 261);
            Controls.Add(outcome);
            Controls.Add(butt1);
            Controls.Add(text2);
            Controls.Add(text1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text1;
        private TextBox text2;
        private Button butt1;
        private Label outcome;
    }
}
