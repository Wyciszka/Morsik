namespace Morsik
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 45);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(112, 105);
            button1.Name = "button1";
            button1.Size = new Size(157, 65);
            button1.TabIndex = 1;
            button1.Text = "Jak grać?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Bisque;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(112, 212);
            button2.Name = "button2";
            button2.Size = new Size(157, 64);
            button2.TabIndex = 2;
            button2.Text = "Alfabet Morse'a";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(384, 339);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Location = new Point(293, 221);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}