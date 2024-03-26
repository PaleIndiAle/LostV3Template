using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Timers;
using System.Runtime.Remoting.Lifetime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        int explosives = 0;

        // Tracks what page of the story the user is at | I will erase this, maybe
        int page = 0;

        //Under Development
        //int campaign = campaignNumber.Next(900, 906);

        //Random number generators
        Random randGen = new Random();
        //Random campaignNumber = new Random();

        public Form1()
        {
            // Display initial message and options
            InitializeComponent();
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {

            if (page == -1)
            {
                page = 0;
            }
            else if (page == 0)
            {
                page = 1;
                outputLabel2.Visible = false;
                imageBox.Visible = true;
            }
            else if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue < 50)
                {
                    page = 3;
                }
                else
                {
                    page = 4;
                }
            }
            else if (page == 3)
            {
                page = 27;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue < 60)
                {
                    page = 9;
                }
                else
                {
                    page = 6;
                }
            }
            else if (page == 6)
            {
                explosives = 1;
                page = 9;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 27;
            }
            else if (page == 14)
            {
                page = 27;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 27;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 29;
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 22)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 8;
            }
            else if (page == 24)
            {
                page = 26;
            }
            else if (page == 25)
            {
                page = 27;
            }
            else if (page == 26)
            {
                page = 9;
            }
            else if (page == 27)
            {
                page = 1; //campaign;
                imageBox.Visible = true;
            }
            else if (page == 29)
            {
                page = 30;
            }
            else if (page == 30)
            {
                page = 1; //campaign;
                imageBox.Visible = true;
            }
            else if (page == 32)
            {
                page = 26;
            }

            Refresh();
            DisplayPage();

        }

        private void option2Button_Click(object sender, EventArgs e)
        {

            if (page == -1)
            {
                page = 0;
            }
            else if (page == 0)
            {
                page = 1;
                outputLabel2.Visible = false;
                imageBox.Visible = true;
            }
            else if (page == 1)
            {
                page = 21;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 10)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue < 25)
                {
                    page = 14;
                }
                else
                {
                    page = 15;
                }
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 22)
            {
                page = 32;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 30)
            {
                page = 31;
            }
            else if (page == 32)
            {
                page = 24;
            }

            Refresh();
            DisplayPage();

        }

        private void option3Button_Click_1(object sender, EventArgs e)
        {
            if (page == -1)
            {
                page = 0;
            }
            else if (page == 0)
            {
                page = 1;
                outputLabel2.Visible = false;
                imageBox.Visible = true;
            }
            else if (page == 10)
            {
                if (explosives == 1)
                {
                    page = 12;
                }
                else
                {
                    page = 11;
                }
            }

            Refresh();
            DisplayPage();
        }

        private void option4Button_Click(object sender, EventArgs e)
        {
            if (page == -1)
            {
                page = 0;
            }
            else if (page == 0)
            {
                page = 1;
                outputLabel2.Visible = false;
                imageBox.Visible = true;
            }

            Refresh();
            DisplayPage();

        }

        private void DisplayPage()
        {
            /// Display text and game options to screen based on the current page

            switch (page)
            {
                case 0:
                    imageBox.Visible = false;
                    Refresh();
                    outputLabel2.Text = "You are not expected to survive.";
                    option1Label.Text = "I Understand";
                    option2Label.Text = "Alright.";
                    option3Label.Text = "Yes, sir!";
                    option4Label.Text = "...";
                    break;
                case 1:
                    imageBox.Image = LostAdventure.Properties.Resources.No_Man_Land;
                    Refresh();
                    outputLabel.Text = "You're a Purple Lion Infantrymen. Deployed on the front in an assault. On the field and bullets fly past you. What do you do?";
                    option1Label.Text = "Charge Forward";
                    option2Label.Text = "Crawl Forward";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 2:
                    imageBox.Image = LostAdventure.Properties.Resources.Running_Field;
                    //SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.brook);
                    //soundPlayer.Play();

                    Refresh();
                    outputLabel.Text = "You charged towards the enemy trench";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 3:
                    imageBox.Image = LostAdventure.Properties.Resources.close;
                    Refresh();
                    outputLabel.Text = "Getting yourself mowed down by an enemy machine gun nest.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 4:
                    imageBox.Image = LostAdventure.Properties.Resources.trench_fight;
                    outputLabel.Text = "Diving down and into an enemy. Both of you grapple each other on the ground.";
                    option1Label.Text = "Beat him";
                    option2Label.Text = "Shoot him";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 5:
                    imageBox.Image = LostAdventure.Properties.Resources.trench_fight;
                    outputLabel.Text = "You grab a nearby rock. Bring it over the soldier's head and beat him to death with it.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 6:
                    imageBox.Image = LostAdventure.Properties.Resources.grandepoint;
                    outputLabel.Text = "As you let go, you notice a stick grenade on his uniform strap.";
                    option1Label.Text = "Keep it";
                    option2Label.Text = "Leave it";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 7:
                    imageBox.Image = LostAdventure.Properties.Resources.trench_fight;
                    outputLabel.Text = "You deliver a powerful blow to the enemy and steady yourself, firing your rifle.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 8:
                    imageBox.Image = LostAdventure.Properties.Resources.trench_fight;
                    outputLabel.Text = "The enemy lurches back as he falls lifelessly on the muddy ground.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 9:
                    imageBox.Image = LostAdventure.Properties.Resources.running;
                    outputLabel.Text = "You check yourself before following your fellow mates deeper into the enemy's trenchline.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 10:
                    imageBox.Image = LostAdventure.Properties.Resources.machinegunner;
                    outputLabel.Text = "As you approach the support trench, enemies start firing down towards you";
                    option1Label.Text = "CHARGE!!!";
                    option2Label.Text = "Cover";
                    if (explosives == 1)
                    {
                        option3Label.Text = "GRENADE!";
                    }
                    else
                    {
                        option3Label.Text = "Grenade?";
                    }
                    option4Label.Text = "...";
                    break;
                case 11:
                    imageBox.Image = LostAdventure.Properties.Resources.grenadethrow;
                    outputLabel.Text = "You try to throw a grenade but don't have any.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 12:
                    imageBox.Image = LostAdventure.Properties.Resources.explosion;
                    outputLabel.Text = "You chuck a grenade down a trench line before it violently dismembers the enemy infront.";
                    option1Label.Text = "CHARGE!";
                    option2Label.Text = "Dive for cover";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 13:
                    imageBox.Image = LostAdventure.Properties.Resources.ground;
                    outputLabel.Text = "You charge forward as you're shot by an enemy. Falling on the muddy ground as your comrades continue your charge.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 14:
                    imageBox.Image = LostAdventure.Properties.Resources.coverdeath;
                    outputLabel.Text = "You try to take cover but an enemy kills you before you do.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 15:
                    imageBox.Image = LostAdventure.Properties.Resources.coverdeath;
                    outputLabel.Text = "You take cover as artillery shells rain around you. ";
                    option1Label.Text = "Leave cover";
                    option2Label.Text = "Continue taking cover";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 16:
                    imageBox.Image = LostAdventure.Properties.Resources.explosion;
                    outputLabel.Text = "You die as a shell explodes next to you.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 17:
                    imageBox.Image = LostAdventure.Properties.Resources.coverdeath;
                    outputLabel.Text = "You wait out the artillery fire until all falls deafly silent.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 18:
                    imageBox.Image = LostAdventure.Properties.Resources.looking_around;
                    outputLabel.Text = "You walk out and observe your surronding.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 19:
                    imageBox.Image = LostAdventure.Properties.Resources.looking_around;
                    outputLabel.Text = "It's eerily quiet as you stepped up and out of the trench.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 20:
                    imageBox.Image = LostAdventure.Properties.Resources.Running_Across;
                    outputLabel.Text = "Giant holes were punched into the earth. But more importantly, it became quiet, on the western front.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 21:
                    imageBox.Image = LostAdventure.Properties.Resources.Running_Across;
                    Refresh();
                    outputLabel.Text = "You crawl over to the enemy trench.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 22:
                    imageBox.Image = LostAdventure.Properties.Resources.close;
                    outputLabel.Text = "When you reach it, you come face to face with an enemy soldier.";
                    option1Label.Text = "Bayonet him";
                    option2Label.Text = "Shoot him";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 23:
                    imageBox.Image = LostAdventure.Properties.Resources.trench_fight;
                    outputLabel.Text = "You bayonet the enemy";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 24:
                    imageBox.Image = LostAdventure.Properties.Resources.close;
                    outputLabel.Text = "You remain lying on the ground";
                    option1Label.Text = "Get up and jump in";
                    option2Label.Text = "Continue lying";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 25:
                    imageBox.Image = LostAdventure.Properties.Resources.ground;
                    outputLabel.Text = "Your fake death becomes reality as you lose consciousness.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 26:
                    imageBox.Image = LostAdventure.Properties.Resources.jumping_in;
                    outputLabel.Text = "You jump in the trench";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 27:
                    imageBox.Visible = false;
                    outputLabel.Text = "You've become another statistic in history. Do you wish to change that fate?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 28:
                    imageBox.Visible = false;
                    outputLabel.Text = "Oh well, suit yourself.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                case 29:
                    imageBox.Visible = false;
                    outputLabel.Text = "You've made your mark in this battle. Now men will tell stories about your courage and skill.";
                    option1Label.Text = "Continue...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 30:
                    imageBox.Visible = false;
                    outputLabel.Text = "There are several endings to this story. Do you wish to try again?";
                    option1Label.Text = "Yes!";
                    option2Label.Text = "No.";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                case 31:
                    imageBox.Visible = false;
                    outputLabel.Text = "Very well, ending simulation.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                case 32:
                    imageBox.Image = LostAdventure.Properties.Resources.trench_fight;
                    outputLabel.Text = "You aim your rifle and shoot the enemy, killing him";
                    option1Label.Text = "Jump in";
                    option2Label.Text = "Stay lying down";
                    option3Label.Text = "...";
                    option4Label.Text = "...";
                    break;
                default:
                    break;
            }
        }
    }
}
