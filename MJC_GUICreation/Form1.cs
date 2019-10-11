using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJC_GUICreation
{
    public partial class Form1 : Form
    {
        //FIELDS
        List<Button> wires = new List<Button>();

        //CONSTRUCTORS
        public Form1()
        {
            InitializeComponent();
        }

        //EVENTS
        //Initialize wires
        private void Form1_Load(object sender, EventArgs e)
        {
            wires.Add(redWire);
            wires.Add(blackWire);
            wires.Add(blueWire);
            wires.Add(whiteWire);
            wires.Add(yellowWire);
        }

        //Enable wires and timer
        private void gameButton_Click(object sender, EventArgs e)
        {
            //Enable all the wires, disable the start button, and clear the status box
            foreach (Button w in wires)
            {
                w.Enabled = true;
            }
            gameButton.Enabled = false;
            gameButton.Text = "Running...";
            resultBox.Text = "";

            //Reset and enable the timer
            progressTimer.Enabled = true;
            timerBar.Value = 0;
            progressTimer.Start();
        }

        private void wire_Click(object sender, EventArgs e)
        {
            //Stop the timer
            progressTimer.Stop();

            //Check if the wire was the correct one
            if((Button)sender == yellowWire)
            {
                resultBox.Text = "You win!";
            }
            else
            {
                resultBox.Text = "KABOOM! You lost.";
            }

            //Disable the wires & enable the reset button
            foreach (Button w in wires)
            {
                w.Enabled = false;
            }

            gameButton.Text = "Reset";
            gameButton.Enabled = true;
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            //Increment the progress bar accordingly, check if time has run out
            if (timerBar.Value < 100)
            {
                timerBar.Value += 1;
            }
            else if(timerBar.Value == 100)
            {
                progressTimer.Stop();
                resultBox.Text = "KABOOM! You lost.";

                foreach (Button w in wires)
                {
                    w.Enabled = false;
                }

                gameButton.Text = "Reset";
                gameButton.Enabled = true;

            }

        }
    }
}
