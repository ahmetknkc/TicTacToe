using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        /*/
         * 
         * Developed By AhmetKnKc
         * Instagram: ahmetknkc_
         * 
        /*/

        string[,] Lines =
        {
            {"", "", ""},
            {"", "", ""},
            {"", "", ""}
        };
        bool isX = true;

        bool ControlHorizontal(int cLine, string cStr)
        {
            if (Lines[cLine, 0] == cStr && Lines[cLine, 1] == cStr && Lines[cLine, 2] == cStr)
                return true;
            return false;
        }

        bool ControlVertical(int cIndex, string cStr)
        {
            if (Lines[0, cIndex] == cStr && Lines[1, cIndex] == cStr && Lines[2, cIndex] == cStr)
                return true;

            return false;
        }

        bool ControlCrossed(string cStr)
        {
            if (Lines[0, 0] == cStr && Lines[1, 1] == cStr && Lines[2, 2] == cStr)
                return true;
            if (Lines[0, 2] == cStr && Lines[1, 1] == cStr && Lines[2, 0] == cStr)
                return true;
            return false;
        }

        void Finish(string FinishText)
        {
            MessageBox.Show(FinishText);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Lines[i, j] = "";
            foreach (Control cont in this.Controls)
                if (cont.Name.StartsWith("button"))
                    cont.Text = "";
            isX = true;
        }

        void PlayComputer()
        {
            if (cb_Computer.Checked && !isX)
            {
                List<Control> Buttons = new List<Control>();

                foreach (Control c in this.Controls)
                    if (c.Name.StartsWith("button"))
                        Buttons.Add(c);
                while (true)
                {
                    int rnd = new Random().Next(0, 9);
                    if (Buttons[rnd].Text == "")
                    {
                        ButtonsClick(Buttons[rnd], null);
                        break;
                    }
                }
            }
        }
        private void cb_Computer_CheckedChanged(object sender, EventArgs e) => PlayComputer();

        private void ButtonsClick(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                ((Button)sender).Text = isX ? "X" : "O";
                isX = !isX;
                lbl_Turn.Text = "Sıra: " + (isX ? "X" : "O");
                int ChCounter = 0, Counter = 0,
                    lineCounter = 0;
                for (int i = 1; i <= 9; i++)
                    foreach (Control cont in this.Controls)
                        if (cont.Name == $"button{i}")
                        {
                            Lines[lineCounter, Counter] = cont.Text;
                            ChCounter++;
                            Counter++;
                            lineCounter =
                                ChCounter == 3 ? 1 :
                                ChCounter == 6 ? 2 : lineCounter;
                            Counter = Counter == 3 ? 0 : Counter;
                        }
                for (int i = 0; i < 3; i++)
                {
                    if (ControlHorizontal(i, "X") || ControlVertical(i, "X") || ControlCrossed("X"))
                    {
                        Finish("Kazanan X!");
                        break;
                    }
                    if (ControlHorizontal(i, "O") || ControlVertical(i, "O") || ControlCrossed("O"))
                    {
                        Finish("Kazanan O!");
                        break;
                    }
                }
            }
            int Cont = 9;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (Lines[i, j] != "")
                        Cont--;
            if (Cont == 0)
                Finish("Berabere.");
            PlayComputer();
        }
    }
}