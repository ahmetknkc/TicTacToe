
namespace TicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lbl_Turn = new System.Windows.Forms.Label();
            this.cb_Computer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 2);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 2);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(166, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 304);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(268, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 304);
            this.label4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(66, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 4;
            this.button1.Tag = "Buttons";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(168, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 4;
            this.button2.Tag = "Buttons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(270, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 4;
            this.button3.Tag = "Buttons";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(65, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 4;
            this.button4.Tag = "Buttons";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(168, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 4;
            this.button5.Tag = "Buttons";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(270, 156);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 4;
            this.button6.Tag = "Buttons";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(65, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 4;
            this.button7.Tag = "Buttons";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(168, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 4;
            this.button8.Tag = "Buttons";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(270, 258);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 4;
            this.button9.Tag = "Buttons";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // lbl_Turn
            // 
            this.lbl_Turn.AutoSize = true;
            this.lbl_Turn.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Turn.Location = new System.Drawing.Point(24, 372);
            this.lbl_Turn.Name = "lbl_Turn";
            this.lbl_Turn.Size = new System.Drawing.Size(52, 20);
            this.lbl_Turn.TabIndex = 5;
            this.lbl_Turn.Text = "Sıra: X";
            // 
            // cb_Computer
            // 
            this.cb_Computer.AutoSize = true;
            this.cb_Computer.Location = new System.Drawing.Point(293, 376);
            this.cb_Computer.Name = "cb_Computer";
            this.cb_Computer.Size = new System.Drawing.Size(77, 17);
            this.cb_Computer.TabIndex = 6;
            this.cb_Computer.Text = "PCye Karşı";
            this.cb_Computer.UseVisualStyleBackColor = true;
            this.cb_Computer.CheckedChanged += new System.EventHandler(this.cb_Computer_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.cb_Computer);
            this.Controls.Add(this.lbl_Turn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lbl_Turn;
        private System.Windows.Forms.CheckBox cb_Computer;
    }
}

