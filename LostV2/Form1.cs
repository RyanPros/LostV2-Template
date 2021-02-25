/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;  

        // random number generator

        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "Horro Madness...Welcome To The Loop ";
            redLabel.Text = "Start";
            blueLabel.Text = "Start There is no end";
            
            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                Random randGen = new Random();
                int value = randGen.Next(1, 11);
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 3)
                {
                    scene = 99;
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 5)
                {
                 scene = 99;
                }
                else if (scene == 6)
                {
                    if (value < 4)
                    {
                        scene = 12;
                    }
                    else
                    {
                        scene = 14;
                    }
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 98;
                }
                else if (scene == 9)
                {
                    scene = 99;
                }
                else if (scene == 10)
                {
                    scene = 98;
                }
                else if (scene == 11)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 11;
                }
                else if (scene == 13)
                {
                    scene = 98;
                }
                else if (scene == 14)
                {
                    scene = 99;
                }
                else if (scene == 15)
                {
                    scene = 21;
                }
                else if (scene == 16)
                {
                    scene = 99;
                }
                else if (scene == 17)
                {
                    if (value < 5)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 19;
                    }
                }
                else if (scene == 18)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 99;
                }
                else if (scene == 20)
                {
                    scene = 98;
                }
                else if (scene == 21)
                {
                    if (value < 5)
                    {
                        scene = 16;
                    }
                    else
                    {
                        scene = 17;
                    }
                }
                else if (scene == 22)
                {
                    scene = 99;
                }
                else if (scene == 23)
                {
                    scene = 24;
                }
                else if (scene == 24)
                {
                    scene = 29;
                }
                else if (scene == 25)
                {
                    scene = 27;
                }
                else if (scene == 26)
                {
                    scene = 98;
                }
                else if (scene == 27)
                {
                    scene = 99;
                }
                else if (scene == 28)
                {
                    scene = 98;
                }
                else if (scene == 29)
                {
                    scene = 98;
                }
                else if (scene == 99)
                {
                    scene = 1;
                }
                else if (scene == 99)
                {
                    scene = 1;
                }
            }
            if (e.KeyCode == Keys.B)  //blue button press
            {
                Random randGen = new Random();
                int value = randGen.Next(1, 11);
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    if (value < 1)
                    {
                        scene = 3;
                    }
                    else
                    {
                        scene = 15;
                    }
                }
                else if (scene == 2)
                {
                    scene = 5;
                }
                else if (scene == 3)
                {
                    scene = 99;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 99;
                }
                else if (scene == 6)
                {
                    if (value < 4)
                    {
                        scene = 12;
                    }
                    else
                    {
                        scene = 14;
                    }
                }
                else if (scene == 7)
                {
                    if (value < 3)
                    {
                        scene = 10;
                    }
                    else
                    {
                        scene = 9;
                    }
                }
                else if (scene == 8)
                {
                    scene = 99;
                }
                else if (scene == 9)
                {
                    scene = 99;
                }
                else if (scene == 10)
                {
                    scene = 98;
                }
                else if (scene == 11)
                {
                    scene = 98;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 98;
                }
                else if (scene == 14)
                {
                    scene = 99;
                }
                else if (scene == 15)
                {
                    scene = 22;
                }
                else if (scene == 16)
                {
                    scene = 99;
                }
                else if (scene == 17)
                {
                    {
                        scene = 18;
                    }
                }
                else if (scene == 18)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 99;
                }
                else if (scene == 20)
                {
                    scene = 98;
                }
                else if (scene == 21)
                {
                    scene = 23;
                }
                else if (scene == 22)
                {
                    scene = 99;
                }
                else if (scene == 23)
                {
                    scene = 25;
                }
                else if (scene == 24)
                {
                    scene = 28;
                }
                else if (scene == 25)
                {
                    scene = 26;
                }
                else if (scene == 26)
                {
                    scene = 98;
                }
                else if (scene == 27)
                {
                    scene = 99;
                }
                else if (scene == 28)
                {
                    scene = 99;
                }
                else if (scene == 29)
                {
                    scene = 98;
                }
                else if (scene == 99)
                {
                    scene = 0;
                }
                else if (scene == 99)
                {
                    scene = 0;
                }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 1:  //start scene  
                    picBox1.BackgroundImage = Properties.Resources.Door;
                    outputLabel.Text = "You awake on a bed in a unknown place with no recollection of how you got there. You hear Footsteps Coming toward the door! What Should You Do?";
                    redLabel.Text = "Hide underneath the bed";
                    blueLabel.Text = "Act like your asleep";
                    break;
                case 2:
                    picBox1.BackgroundImage = Properties.Resources.Under_bed;
                    outputLabel.Text = "The unknow figure noticed you weren't in the bed he starts to search around the room. Do you run or Stay";
                    redLabel.Text = "Run";
                    blueLabel.Text = "Stay";
                    break;
                case 3:
                    picBox1.BackgroundImage = Properties.Resources.Under_bed;
                    outputLabel.Text = "He noticed you were awake a decided you were better asleep then awake. So he then smothers you to death.";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 4:
                    outputLabel.Text = "You make a break for the exit you run towards it and realize the door leading out is locked ";
                    redLabel.Text = "Break Down the door";
                    blueLabel.Text = "1v1 Him in a COD match";
                    break;
                case 5:
                    outputLabel.Text = "He Hears you breathing and Slashes your throat ";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 6:
                    outputLabel.Text = "You try to ask him to 1v1 him on Cod at your house.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "Continue";
                    break;
                case 7:
                    outputLabel.Text = "You bust in the door he noticed the slam You decide to hide somewhere close Or You Jump out the window";
                    redLabel.Text = "Hide";
                    blueLabel.Text = "Jump";
                    break;
                case 8:
                    outputLabel.Text = "You decide to hide in the mans house till the man falls asleep and you escape out the front door.";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 9:
                    outputLabel.Text = "You didn't know you were on the second floor you broke your legs and bled out ";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 10:
                    outputLabel.Text = "You made it through with a couple cuts but made it out. You ran to the police and were finally reunited with your family.";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 11:
                    outputLabel.Text = "He took your advice to heart he then decided to tare yours out.";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 12:
                    outputLabel.Text = "He agrees as You play you notice that the man is losing and starting to get mad do you.Help him out or Make fun of his skill.";
                    redLabel.Text = "Help";
                    blueLabel.Text = "Laugh At";
                    break;
                case 13:
                    outputLabel.Text = "He was surprised to see you make fun of him. He laughed it off and left you alone. But he remembers that you made fun of his dad so he killed yours  ";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 14:
                    outputLabel.Text = "He noticed you rejected your offer and decided to kill you because you became annoying ";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 15:
                    outputLabel.Text = "The unknown figure checks on you without noticing your awake. He leaves food and water out for you then leaves do you want stay in the bed or get up?";
                    redLabel.Text = "Get up";
                    blueLabel.Text = "Stay";
                    break;
                case 16:
                    outputLabel.Text = "The food was tampered you die.";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 17:
                    outputLabel.Text = "You enjoyed the meal and feel at full strength. Which way would be the best for escaping?   ";
                    redLabel.Text = "Wait for a good time";
                    blueLabel.Text = "Breakdown the door?";
                    break;
                case 18:
                    outputLabel.Text = "You died from waiting to long";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 19:
                    outputLabel.Text = "You Slam the door and no budge you end up getting knocked out by the unknown figure never to be heard form again";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 20:
                    outputLabel.Text = "The unknown figure opens the door at the same time you try to break it down. You end up going through him instead of the door knocking him out. You take this time to run out of the unknown figures house to safety";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 21:
                    outputLabel.Text = "You arise from the bed you noticed the food and water on the ground.do you eat or to not eat";
                    redLabel.Text = "Eat";
                    blueLabel.Text = "Don't Eat";
                    break;
                case 22:
                    outputLabel.Text = "You decide to stay in the unknow bed and die because you never left";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 23:
                    outputLabel.Text = "You Decide to not eat. You pass out from exestuation. When you awake you feel better but notice a cut on your leg do you.Inspect the cut or leave it alone .";
                    redLabel.Text = "Inspect the Cut";
                    blueLabel.Text = "Leave it alone";
                    break;
                case 24:
              outputLabel.Text = "You inspect the cut and use the bed sheets to rap the cut to stop the bleeding.Now your ready to escape do Try to kill the unknown figure or Escape through the window";
                    redLabel.Text = "Try to Kill the unknown figure";
                    blueLabel.Text = "Break the window";
                    break;
                case 25:
                    outputLabel.Text = "You leave it for now and focus on getting out of here but you can't walk as fast on on one leg.Now your ready to escape. Do you try to escape through the window or The door  Escape through the window or The door";
                    redLabel.Text = "Door";
                    blueLabel.Text = "Window";
                    break;
                case 26:
                    outputLabel.Text = "You hobble up the stairs you get to the door its locked. Yet the door opens you manage to escape without any challenge ";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 27:
                    outputLabel.Text = "You Break the window and glass goes everywhere you squeeze through the window. When you did that you cut your body to the point of no return and die";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 28:
                    outputLabel.Text = "You Break the window and glass goes everywhere you squeeze through the window. You hobble away to safety ";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 29:
                    outputLabel.Text = "You Thought you were tough and called the unknow figure on. After a couple minutes you hear the door open you're then are shot 10 times after being annoying.Really you got what you Deserve";
                    redLabel.Text = "Push";
                    blueLabel.Text = "Push";
                    break;
                case 98:
                    outputLabel.Text = "You have won Thanks for playing";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "Return To Main Menu";
                    break;
                case 99:
                    outputLabel.Text = "You have Died, You really do suck at this";
                    redLabel.Text = "Play Again";
                    blueLabel.Text = "Return To Main Menu";
                    break;


            }
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RedLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
