//Mikayla, Brooke
//November 9, 2016
//Make your own story project

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace summitive_make_story
{
    public partial class Story : Form
    {
        int scene = 0;  // tracks what part of the game the user is at
        Random randgen = new Random();
        int rand = 0;          

        public Story()
        {
            InitializeComponent();
            //display initial message and options

            SoundPlayer player = new SoundPlayer(Properties.Resources.walkin);
            player.Play();
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
                else if (scene == 5)
                {
                    scene = 2;
                }
                else if (scene == 3)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                   // rand = randgen.Next(1,5);
                    scene = 17;
                }

                else if (scene == 2)
                {
                    scene = 8;
                }
                else if (scene == 6 )
                {
                    scene = 17 ;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 15)
                {
                    scene = 16;
                }
                else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    this.Close();
                }
                else if (scene == 13)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 15;
                }
                else if (scene == 7)
                {
                    scene = 17;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
            }
            else if (e.KeyCode == Keys.B)  
            {
                if (scene == 0)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 1;
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 8)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {
                    scene = 12;
                }
                else if (scene == 12)
                {
                    scene = 17;
                }
                else if (scene == 13)
                {
                    scene = 15; 
                }
                else if (scene == 17)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                if (scene == 0)
                {
                    scene = 2;
                }

                else if (scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 11;
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
                    outputLabel.Text = "You walk home by yourself and find a cat on your way to the ice cream store to comfort your sad feelings. Do you keep the cat or let it be?";
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
                    outputLabel.Text = "You and your new friend go on a great adventure to the pet store. At the pet store you get your new pet a name tag and a collar. You see a missing pet sign with your new friend on it. Do you return it or run?";
                    mLabel.Text = "Return it like a good person";
                    bLabel.Text = "RUN FORREST RUN";
                    spaceLabel.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "The cat gets hit by a car and you get sadder. You proceed to the ice cream store, where you see your crush.";
                    mLabel.Text = "Continue";
                    bLabel.Text = "";
                    spaceLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "You get a reward for returning the cat, you then walk home alone again.";
                    mLabel.Text = "Continue";
                    bLabel.Text = "";
                    spaceLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You get tackled by the owner, who has just walked through the pet store door. The cat is taken from you and you walk home.";
                    mLabel.Text = "Continue";
                    bLabel.Text = "";
                    spaceLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "They want to know if you want to watch netflix or just hang out.";
                    mLabel.Text = "Netflix";
                    bLabel.Text = "Hangout";
                    spaceLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "They ask you what you want to watch. What do you choose?";
                    mLabel.Text = "Supernatural";
                    bLabel.Text = "Vamire Diaries";
                    spaceLabel.Text = "Any of the Saw movies";
                    break;
                case 10:
                    outputLabel.Text = "You get scared.";
                    mLabel.Text = "Continue";
                    bLabel.Text = "";
                    spaceLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "They put their arm around you. What do you do?";
                    mLabel.Text = "Run";
                    bLabel.Text = "Let them";
                    spaceLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "You get really nervous and die of a heart attack.";
                    mLabel.Text = "Continue";
                    bLabel.Text = "";
                    spaceLabel.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "Your one friend pulls out a cigarette before entering tims and tells you to wait with them. Do you take an offered cigarette?";
                    mLabel.Text = "Yes";
                    bLabel.Text = "No";
                    spaceLabel.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "You cough up blood and get sent to the hospital. They couldnt save you.";
                    mLabel.Text = "Continue";
                    bLabel.Text = "";
                    spaceLabel.Text = "";
                    break;
                case 15:
                    if (rand == 1)
                    {
                        outputLabel.Text = "timbits";
                    }
                    else if (rand == 2)
                    {
                        outputLabel.Text = "donut";
                    }
                    else if (rand == 3)
                    {
                        outputLabel.Text = "coffee";
                    }
                    else
                    {
                        outputLabel.Text = "Your friend buys you something instead";
                    }

                    mLabel.Text = "Continue";
                    bLabel.Text = "";
                    spaceLabel.Text = "";

                    break;
                case 16:
                    outputLabel.Text = "After buying your treat you then walk home with your friends.";
                    mLabel.Text = "Continue";
                    bLabel.Text = "";
                    spaceLabel.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "The end. Would you like to play again?";
                    mLabel.Text = "No";
                    bLabel.Text = "Yes";
                    spaceLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "Your friend offers to buy you something";
                    mLabel.Text = "Continue";
                    bLabel.Text = "";
                    spaceLabel.Text = "";
                    break;
            }
        }
    }
}
