namespace WinFormsApp2
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dydunie = new TextBox();
            kroxy = new TextBox();
            szopy = new TextBox();
            x = new TextBox();
            y = new TextBox();
            label7 = new Label();
            czas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 103);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 182);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "KroXy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 103);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "DYd31Fy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 173);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 3;
            label4.Text = "y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 344);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "CzAs";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 241);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 5;
            label6.Text = "szopy XDDDD";
            // 
            // dydunie
            // 
            dydunie.Location = new Point(387, 126);
            dydunie.Name = "dydunie";
            dydunie.Size = new Size(100, 23);
            dydunie.TabIndex = 6;
            dydunie.TextChanged += dydunie_TextChanged;
            // 
            // kroxy
            // 
            kroxy.Location = new Point(387, 215);
            kroxy.Name = "kroxy";
            kroxy.Size = new Size(100, 23);
            kroxy.TabIndex = 7;
            kroxy.TextChanged += kroxy_TextChanged;
            // 
            // szopy
            // 
            szopy.Location = new Point(433, 259);
            szopy.Name = "szopy";
            szopy.Size = new Size(100, 23);
            szopy.TabIndex = 8;
            szopy.TextChanged += szopy_TextChanged;
            // 
            // x
            // 
            x.Location = new Point(151, 95);
            x.Name = "x";
            x.Size = new Size(100, 23);
            x.TabIndex = 9;
            x.TextChanged += x_TextChanged;
            // 
            // y
            // 
            y.Location = new Point(151, 179);
            y.Name = "y";
            y.Size = new Size(100, 23);
            y.TabIndex = 10;
            y.TextChanged += y_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 52);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 11;
            label7.Text = "planSZa";
            // 
            // czas
            // 
            czas.Location = new Point(272, 341);
            czas.Name = "czas";
            czas.Size = new Size(100, 23);
            czas.TabIndex = 12;
            czas.TextChanged += textBox6_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(czas);
            Controls.Add(label7);
            Controls.Add(y);
            Controls.Add(x);
            Controls.Add(szopy);
            Controls.Add(kroxy);
            Controls.Add(dydunie);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox dydunie;
        private TextBox kroxy;
        private TextBox szopy;
        private TextBox x;
        private TextBox y;
        private Label label7;
        private TextBox czas;
    }
}