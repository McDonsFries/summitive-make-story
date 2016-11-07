using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace summitive_make_story
{
    public partial class Story : Form
    {
        int scene = 0;  // tracks what part of the game the user is at

        public Story()
        {
            InitializeComponent();
            //display initial message and options
            outputLabel.Text = "Its the end of the day and you start to walk home from school. Do you walk home with your friends, your crush or alone?";
            mLabel.Text = "Alone";
            bLabel.Text = "Friends";
            spaceLabel.Text = "Crush"; 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            /// First decision
            if (e.KeyCode == Keys.M)      
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
            }
            else if (e.KeyCode == Keys.B)  
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 5;
                }

            }
            else if (e.KeyCode == Keys.Space) 
            {
                if (scene == 0)
                {
                    scene = 3;
                }
                else if (scene == 1)
                {
                    scene = 5;
                }

            }


            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene
                    outputLabel.Text = "Do you walk alone, with your friends or your crush?";
                    mLabel.Text = "Alone";
                    bLabel.Text = "With your crush";
                    spaceLabel.Text = "With your friends";
                    break;
                case 1:
                    outputLabel.Text = "You walk home by yourself sad and then find a cat  on your way to the ice cream store to comfort your feelings. Do you keep the cat or let it be?";
                    mLabel.Text = "Keep it";
                    bLabel.Text = "Leave it be";
                    spaceLabel.Text = "";
                    break;
                case 2:
                    outputLabel.Text = "Your crush asks if you want to hang out at their place.  Do you go or not?";
                    mLabel.Text = "Yes";
                    bLabel.Text = "No";
                    spaceLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "Your friends invite you to tims with them. Do you go or not?";
                    mLabel.Text = "Yes";
                    bLabel.Text = "No";
                    spaceLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "They want to know if you want to watch Netflix or just hang out. Do you choose Netflix or hangout?";
                    mLabel.Text = "Netflix";
                    bLabel.Text = "Hangout";
                    spaceLabel.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "Your one friend pulls out a cigarette before entering the tims and asks you if you want one. Do you take a cigarette?";
                    mLabel.Text = "Yes";
                    bLabel.Text = "No";
                    spaceLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "At the pet store you get your new pet a name tag and a collar. You see a missing pet sign with your new friend on it. Do you return it or run?";
                    mLabel.Text = "Return it like a good person";
                    bLabel.Text = "RUN FORREST RUN";
                    spaceLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "They ask what you want to watch. What do you say?";
                    mLabel.Text = "Supernatural";
                    bLabel.Text = "The Vampire Diaries";
                    spaceLabel.Text = "The Saw movies";
                    break;
                case 8:
                    outputLabel.Text = "What do you buy?";
                    mLabel.Text = "Doughnut";
                    bLabel.Text = "Timbits";
                    spaceLabel.Text = "Ice Capp";
                    break;
                case 9:
                    outputLabel.Text = "You get scared and they put their arm around you. What do you do?";
                    mLabel.Text = "Run";
                    bLabel.Text = "Let them";
                    spaceLabel.Text = "";
                    break;

            }
        }
    }
}
