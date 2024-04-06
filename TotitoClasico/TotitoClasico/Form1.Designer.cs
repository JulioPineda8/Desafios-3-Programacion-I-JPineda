namespace TotitoClasico
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            label1 = new Label();
            lbljugador1 = new Label();
            label3 = new Label();
            lbljugador2 = new Label();
            label5 = new Label();
            lblempate = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(145, 52);
            btn1.Name = "btn1";
            btn1.Size = new Size(84, 85);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(235, 52);
            btn2.Name = "btn2";
            btn2.Size = new Size(84, 85);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(325, 52);
            btn3.Name = "btn3";
            btn3.Size = new Size(84, 85);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(325, 143);
            btn6.Name = "btn6";
            btn6.Size = new Size(84, 85);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(235, 142);
            btn5.Name = "btn5";
            btn5.Size = new Size(84, 85);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(143, 142);
            btn4.Name = "btn4";
            btn4.Size = new Size(84, 85);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(325, 231);
            btn9.Name = "btn9";
            btn9.Size = new Size(84, 85);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(235, 231);
            btn8.Name = "btn8";
            btn8.Size = new Size(84, 85);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(144, 230);
            btn7.Name = "btn7";
            btn7.Size = new Size(84, 85);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(497, 72);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 9;
            label1.Text = "Jugador 1";
            label1.Click += label1_Click;
            // 
            // lbljugador1
            // 
            lbljugador1.AutoSize = true;
            lbljugador1.Location = new Point(646, 72);
            lbljugador1.Name = "lbljugador1";
            lbljugador1.Size = new Size(17, 20);
            lbljugador1.TabIndex = 10;
            lbljugador1.Text = "0";
            lbljugador1.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(497, 120);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 11;
            label3.Text = "Jugador 2";
            // 
            // lbljugador2
            // 
            lbljugador2.AutoSize = true;
            lbljugador2.Location = new Point(646, 120);
            lbljugador2.Name = "lbljugador2";
            lbljugador2.Size = new Size(17, 20);
            lbljugador2.TabIndex = 12;
            lbljugador2.Text = "0";
            lbljugador2.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(497, 170);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 13;
            label5.Text = "Empates";
            // 
            // lblempate
            // 
            lblempate.AutoSize = true;
            lblempate.Location = new Point(646, 170);
            lblempate.Name = "lblempate";
            lblempate.Size = new Size(17, 20);
            lblempate.TabIndex = 14;
            lblempate.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblempate);
            Controls.Add(label5);
            Controls.Add(lbljugador2);
            Controls.Add(label3);
            Controls.Add(lbljugador1);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Label label1;
        private Label lbljugador1;
        private Label label3;
        private Label lbljugador2;
        private Label label5;
        private Label lblempate;
    }
}
