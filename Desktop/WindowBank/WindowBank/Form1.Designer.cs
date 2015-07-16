namespace WindowBank
{
    partial class Form1
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
            this.pullbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.waitnumberbox = new System.Windows.Forms.MaskedTextBox();
            this.currentNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.counterwait = new System.Windows.Forms.MaskedTextBox();
            this.counter1box = new System.Windows.Forms.MaskedTextBox();
            this.counter2box = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // pullbutton
            // 
            this.pullbutton.Location = new System.Drawing.Point(211, 85);
            this.pullbutton.Name = "pullbutton";
            this.pullbutton.Size = new System.Drawing.Size(59, 63);
            this.pullbutton.TabIndex = 5;
            this.pullbutton.Text = "pull";
            this.pullbutton.UseVisualStyleBackColor = true;
            this.pullbutton.Click += new System.EventHandler(this.pullbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wait Line";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // waitnumberbox
            // 
            this.waitnumberbox.Enabled = false;
            this.waitnumberbox.Location = new System.Drawing.Point(211, 54);
            this.waitnumberbox.Name = "waitnumberbox";
            this.waitnumberbox.Size = new System.Drawing.Size(56, 25);
            this.waitnumberbox.TabIndex = 3;
            this.waitnumberbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.waitnumberbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.waitnumberbox_MaskInputRejected);
            // 
            // currentNumber
            // 
            this.currentNumber.AutoSize = true;
            this.currentNumber.Font = new System.Drawing.Font("Gulim", 54F);
            this.currentNumber.Location = new System.Drawing.Point(46, 73);
            this.currentNumber.Name = "currentNumber";
            this.currentNumber.Size = new System.Drawing.Size(90, 90);
            this.currentNumber.TabIndex = 6;
            this.currentNumber.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Counter2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Counter1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "CurrentNum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "WaitNumber";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // counterwait
            // 
            this.counterwait.Enabled = false;
            this.counterwait.Location = new System.Drawing.Point(183, 296);
            this.counterwait.Name = "counterwait";
            this.counterwait.Size = new System.Drawing.Size(84, 25);
            this.counterwait.TabIndex = 17;
            this.counterwait.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // counter1box
            // 
            this.counter1box.Enabled = false;
            this.counter1box.Location = new System.Drawing.Point(124, 249);
            this.counter1box.Name = "counter1box";
            this.counter1box.Size = new System.Drawing.Size(56, 25);
            this.counter1box.TabIndex = 18;
            this.counter1box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.counter1box.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // counter2box
            // 
            this.counter2box.Enabled = false;
            this.counter2box.Location = new System.Drawing.Point(211, 249);
            this.counter2box.Name = "counter2box";
            this.counter2box.Size = new System.Drawing.Size(56, 25);
            this.counter2box.TabIndex = 19;
            this.counter2box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 407);
            this.Controls.Add(this.counter2box);
            this.Controls.Add(this.counter1box);
            this.Controls.Add(this.counterwait);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentNumber);
            this.Controls.Add(this.pullbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waitnumberbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pullbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox waitnumberbox;
        private System.Windows.Forms.Label currentNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox counterwait;
        private System.Windows.Forms.MaskedTextBox counter1box;
        private System.Windows.Forms.MaskedTextBox counter2box;
    }
}

