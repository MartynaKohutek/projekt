namespace projekt
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
            button1 = new Button();
            button2 = new Button();
            Cena1 = new TextBox();
            Cena = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(54, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Komputer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(177, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Monitor";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Cena1
            // 
            Cena1.Location = new Point(350, 119);
            Cena1.Name = "Cena1";
            Cena1.Size = new Size(100, 23);
            Cena1.TabIndex = 2;
            // 
            // Cena
            // 
            Cena.AutoSize = true;
            Cena.Location = new Point(350, 90);
            Cena.Name = "Cena";
            Cena.Size = new Size(45, 15);
            Cena.TabIndex = 3;
            Cena.Text = "Cena zl";
            Cena.Click += Cena_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 450);
            Controls.Add(Cena);
            Controls.Add(Cena1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Kalkulator Zestawów Komputerowych";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox Cena1;
        private Label Cena;
    }
}
