using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _190133369Task1
{
    public partial class ReplacingBooks : Form
    {
        //declaring objects and array lists
       private static  CallNumList c = new CallNumList();
        public ArrayList userNums = new ArrayList();
        public ArrayList callnumsList ;

        public ReplacingBooks()
        {
            InitializeComponent();
        }

        private void ReplacingBooks_Load(object sender, EventArgs e)
        {
            //calling on method form load
            formLoad();
            
        

        }
        public void formLoad()
        {
            //clears the users arraylist
            userNums.Clear();

            //get random call numbers and stores in arraylist
            callnumsList = c.NumList();

            //clears the rich edit box
            rtbList.Clear();

            // displays each calling number in a button and the button is made visible to the user
            btnItemOne.Text = callnumsList[0].ToString();
            btnItemOne.Visible = true;
            btnItemTwo.Text = callnumsList[1].ToString();
            btnItemTwo.Visible = true;
            btnItemThree.Text = callnumsList[2].ToString();
            btnItemThree.Visible = true;
            btnItemFour.Text = callnumsList[3].ToString();
            btnItemFour.Visible = true;
            btnItemFive.Text = callnumsList[4].ToString();
            btnItemFive.Visible = true;
            btnItemSix.Text = callnumsList[5].ToString();
            btnItemSix.Visible = true;
            btnItemSeven.Text = callnumsList[6].ToString();
            btnItemSeven.Visible = true;
            btnItemEight.Text = callnumsList[7].ToString();
            btnItemEight.Visible = true;
            btnItemNine.Text = callnumsList[8].ToString();
            btnItemNine.Visible = true;
            btnItemTen.Text = callnumsList[9].ToString();
            btnItemTen.Visible = true;

        }

        private void btnItemOne_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemOne.Text +" ");
            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemOne.Text);
            btnItemOne.Visible = false;
        }

        private void btnItemTwo_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemTwo.Text + " ");

            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemTwo.Text);

            //the button is not visible to the user after selected
            btnItemTwo.Visible = false;
        }

        private void btnItemThree_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemThree.Text + " ");

            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemThree.Text);

            //the button is not visible to the user after selected
            btnItemThree.Visible = false;
        }

        private void btnItemFour_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemFour.Text + " ");

            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemFour.Text);

            //the button is not visible to the user after selected
            btnItemFour.Visible = false;

        }

        private void btnItemFive_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemFive.Text + " ");

            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemFive.Text);

            //the button is not visible to the user after selected
            btnItemFive.Visible = false;

        }

        private void btnItemSix_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemSix.Text + " ");

            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemSix.Text);

            //the button is not visible to the user after selected
            btnItemSix.Visible = false;

        }

        private void btnItemSeven_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemSeven.Text + " ");

            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemSeven.Text);

            //the button is not visible to the user after selected
            btnItemSeven.Visible = false;

        }

        private void btnItemEight_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemEight.Text + " ");

            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemEight.Text);

            //the button is not visible to the user after selected
            btnItemEight.Visible = false;

        }

        private void btnItemNine_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemNine.Text + " ");

            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemNine.Text);

            //the button is not visible to the user after selected
            btnItemNine.Visible = false;

        }

        private void btnItemTen_Click(object sender, EventArgs e)
        {
            //shows the user the calling number they have selected
            rtbList.AppendText(btnItemTen.Text + " ");

            //adds the selected calling number to an arraylist called userNums
            userNums.Add(btnItemTen.Text);

            //the button is not visible to the user after selected
            btnItemTen.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
           //declares arraylist to store sorted array
             ArrayList sortNum = new ArrayList();

            //stores sorted array
                sortNum = c.sortedNumList(callnumsList);

            //declares string
           string result = " ";

            //checks if the user has selected all ten numbers / the length of the arraylist is 10 and whether the order is ascending
            if (userNums.Count == 10)
            {
                for (int i = 0; i < sortNum.Count && i < userNums.Count; i++)

                {

                    if (!Object.Equals(sortNum[i], userNums[i]))

                        result = "true";
                    else
                        result = "false";


                }
            }
            else
            {
                result = "true";
            }
            
           
            //if the user doesnt not select all ten and in ascending order the try again button is made available
           if(result == "true")
            {
                btnTry.Visible = true;
                btnTry.Enabled = true;

               
            }
            else
            {
                // if the user does select all ten and in ascending order they will be awarded a badge by making the picture box visible
                //Gamification feature
                pbBadge.Visible = true;
                lblBadge.Visible = true;
                btnTry.Visible = false;
                btnTry.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //stops running the program
            this.Close(); 
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            //refreshs the form for another try for the user
            formLoad();


        }
    }
}
