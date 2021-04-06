
namespace ExplainingStateChartDiagrams
{
    partial class TwoButtonWatchForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttons1and2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtHours
            // 
            this.txtHours.Enabled = false;
            this.txtHours.Location = new System.Drawing.Point(78, 48);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 2;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Enabled = false;
            this.txtMinutes.Location = new System.Drawing.Point(184, 48);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(100, 20);
            this.txtMinutes.TabIndex = 3;
            // 
            // txtSeconds
            // 
            this.txtSeconds.Enabled = false;
            this.txtSeconds.Location = new System.Drawing.Point(290, 48);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(100, 20);
            this.txtSeconds.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttons1and2
            // 
            this.buttons1and2.Location = new System.Drawing.Point(153, 237);
            this.buttons1and2.Name = "buttons1and2";
            this.buttons1and2.Size = new System.Drawing.Size(131, 49);
            this.buttons1and2.TabIndex = 5;
            this.buttons1and2.Text = "Button1 + 2";
            this.buttons1and2.UseVisualStyleBackColor = true;
            this.buttons1and2.Click += new System.EventHandler(this.buttons1and2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seconds";
            // 
            // TwoButtonWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttons1and2);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TwoButtonWatchForm";
            this.Text = "Two Button Watch";
            this.Load += new System.EventHandler(this.TwoButtonWatchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttons1and2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}