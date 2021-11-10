using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace _190133369Task1
{
    public partial class IdentifyingAreas : Form

    {
        //declaring varibles for set of questions
        string set;
        int i;
        //declaring array list of user answers
        ArrayList userAnswer = new ArrayList();

        public IdentifyingAreas()
        {
            InitializeComponent();
        }

        private void IdentifyingAreas_Load(object sender, EventArgs e)
        {
            i = 0;
            //shows whcih set of questions are shown
            set = "A";
            //loads the questions
            formLoadSetA();
        }
        public void formLoadSetA()
        {
            //changes the instructions accroding the questions set being displayed 
            lblinstruction.Text = "Match the description to the correct calling number.";
            

            //object of match the column question class
            var mcq = new MatchColQues();

            //displaying the first column
            lblFirColOne.Text = "1) " + mcq.SetACall[1];
            lblFirColTwo.Text = "2) " + mcq.SetACall[2];
            lblFirColThree.Text = "3) " + mcq.SetACall[3];
            lblFirColFour.Text = "4) " + mcq.SetACall[4];

            //displaying the first column
            btnSecColOne.Text =   "A) " + mcq.SetADes[1];
            btnSecColTwo.Text =   "B) " + mcq.SetADes[2];
            btnSecColThree.Text = "C) " + mcq.SetADes[3];
            btnSecColFour.Text =  "D) " + mcq.SetADes[4];
            btnSecColFive.Text =  "E) " + mcq.SetADes[5];
            btnSecColSix.Text =   "F) " + mcq.SetADes[6];
            btnSecColSeven.Text = "G) " + mcq.SetADes[7];
        }
        public void formLoadSetB()
        {
            //changes the instructions accroding the questions set being displayed 
            lblinstruction.Text = "Match the call numbers to the correct description.";
           

            //object of match the column question class
            var mcq = new MatchColQues();

            //displaying the first column
            lblFirColOne.Text = "1) " + mcq.SetBCall[1];
            lblFirColTwo.Text = "2) " + mcq.SetBCall[2];
            lblFirColThree.Text = "3) " + mcq.SetBCall[3];
            lblFirColFour.Text = "4) " + mcq.SetBCall[4];

            //displaying the first column
            btnSecColOne.Text =  "A) " + mcq.SetBDes[1];
            btnSecColTwo.Text =  "B) " + mcq.SetBDes[2];
            btnSecColThree.Text ="C) " + mcq.SetBDes[3];
            btnSecColFour.Text = "D) " + mcq.SetBDes[4];
            btnSecColFive.Text = "E) " + mcq.SetBDes[5];
            btnSecColSix.Text =  "F) " + mcq.SetBDes[6];
            btnSecColSeven.Text ="G) " + mcq.SetBDes[7];

        }
        public void showanswer(string letter)
        {
            //add the user's selected answer in to a arraylist 
            userAnswer.Add(letter);
            //increases the count by one to indicate which letter is being matched to which number
            i = i + 1;
            //displays the letter and  number the user has choosen
            rtbAnswer.AppendText(i.ToString() + " - " + letter + ", ");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //stops running the program
            this.Close();
        }

        private void btnTA_Click(object sender, EventArgs e)
        {
            //makes the badges disappear
            pbBadgeT.Visible = false;
            lblBadgeT.Visible = false;
            pbLoser.Visible = false;
            lblLoser.Visible = false;

            //clears the rich edit box
            rtbAnswer.Clear();

            //clears the user's pass answers
            userAnswer.Clear();

            i = 0;

            //alternates between the sets of questions 
            if (set == "A")
            {
                set = "B";
                formLoadSetB();

            }
            else
            {
                set = "A";
                formLoadSetA();
            }
        }

        private void btnSecColOne_Click(object sender, EventArgs e)
        {
            //calls the method to add the user's answer to the arraylist and display the answer
            showanswer("A");
        }

        private void btnSecColTwo_Click(object sender, EventArgs e)
        {
            //calls the method to add the user's answer to the arraylist and display the answer
            showanswer("B");
        }

        private void btnSecColThree_Click(object sender, EventArgs e)
        {
            //calls the method to add the user's answer to the arraylist and display the answer
            showanswer("C");
        }

        private void btnSecColFour_Click(object sender, EventArgs e)
        {
            //calls the method to add the user's answer to the arraylist and display the answer
            showanswer("D");
        }

        private void btnSecColFive_Click(object sender, EventArgs e)
        {
            //calls the method to add the user's answer to the arraylist and display the answer
            showanswer("E");
        }

        private void btnSecColSix_Click(object sender, EventArgs e)
        {
            //calls the method to add the user's answer to the arraylist and display the answer
            showanswer("F");
        }

        private void btnSecColSeven_Click(object sender, EventArgs e)
        {
            //calls the method to add the user's answer to the arraylist and display the answer
            showanswer("G");
        }

        private void btnChe_Click(object sender, EventArgs e)
        {
            //declaring array list of the answers for set A questions
            ArrayList setAAns = new ArrayList();
            setAAns.Add("D");
            setAAns.Add("F");
            setAAns.Add("A");
            setAAns.Add("G");
            //declaring array list of the answers for set B 
            ArrayList setBAns = new ArrayList();
            setBAns.Add("G");
            setBAns.Add("D");
            setBAns.Add("F");
            setBAns.Add("A");

            //declares string
            string result = " ";
            if (set == "A")
            {
                //checks if the length of the arraylist is 4 and if the answers picked are correct
                if (userAnswer.Count == 4)
                {
                    for (int i = 0; i < setAAns.Count && i < userAnswer.Count; i++)

                    {

                        if (!Object.Equals(setAAns[i], userAnswer[i]))

                            result = "true";
                        else
                            result = "false";


                    }
                }
                else
                {
                    result = "true";
                }
            }
            else
            {
                //checks if the length of the arraylist is 4 and if the answers picked are correct
                if (userAnswer.Count == 4)
                {
                    for (int i = 0; i < setBAns.Count && i < userAnswer.Count; i++)

                    {

                        if (!Object.Equals(setBAns[i], userAnswer[i]))

                            result = "true";
                        else
                            result = "false";


                    }
                }
                else
                {
                    result = "true";
                }

            }
            
            if (result == "true")
            {
                /* 
                 Title:  How to play sound in c# (c sharp)
                 Author: Technoland 
                 Avaiable at:https://www.youtube.com/watch?v=W8w-qWga98U&t=1s
                 
                 *******************************************************************************************************/
                //instance of object soud player 
                SoundPlayer p = new SoundPlayer(soundLocation: @"C:\Users\Dishani\Documents\PROG7312\Prog7312_Task1_1901339_Dishaniodayar_G1\190133369Task1\mixkit-horror-lose-2028.wav");
                //plays the loser audio when badge is displayed
                p.Play();
//*********************************************************************************************************************************

                //if the user's answers are incorrect they will be awarded the biggest loser badge by making the picture box visible
                //Gamification feature
                pbLoser.Visible = true;
                lblLoser.Visible = true;


            }
            else
            {
                //instance of object soud player 
                SoundPlayer sp = new SoundPlayer(soundLocation: @"C:\Users\Dishani\Documents\PROG7312\Prog7312_Task1_1901339_Dishaniodayar_G1\190133369Task1\mixkit-fantasy-game-success-notification-270.wav");
                //plays the winner audio when badge is displayed
                sp.Play();

                // if the user's answers are correct they will be awarded with a badge by making the picture box visible
                //Gamification feature
                pbBadgeT.Visible = true;
                lblBadgeT.Visible = true;
                
                
            }

        }
    }
}
