namespace WinFormsApp2
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            czas = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            debug = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 458);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "czas";
            // 
            // czas
            // 
            czas.AutoSize = true;
            czas.Location = new Point(300, 458);
            czas.Name = "czas";
            czas.Size = new Size(38, 15);
            czas.TabIndex = 1;
            czas.Text = "label2";
            czas.Click += czas_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // debug
            // 
            debug.AllowDrop = true;
            debug.AutoEllipsis = true;
            debug.AutoSize = true;
            debug.CausesValidation = false;
            debug.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            debug.Location = new Point(569, 371);
            debug.Name = "debug";
            debug.Size = new Size(38, 15);
            debug.TabIndex = 2;
            debug.Text = "label2";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(585, 435);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(593, 275);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 508);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(debug);
            Controls.Add(czas);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label czas;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        public Label debug;
        private Label label2;
        private Label label3;
    }
}