using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _190133369Task1
{
    class CallNumList
    {
        //initialising fields
        string author = "", firstNum = "", secNum = "", genCallNum = "";
        

        //constructor
        public ArrayList NumList()
        {
            //declaring array list of call numbers 
            ArrayList callNums = new ArrayList();

            //adding 10 random calling numbers to the array list by calling the CallNumItem() method
            for (int i = 0; i < 10; i++)
                callNums.Add(CallNumItem());

            return callNums;

        }

        //method for generating a random calling number 
        public string CallNumItem()
        {
            //clears the fields
            author = "";
            firstNum = "";
            secNum = "";
            genCallNum = "";

            //declares the alphabet in list to assit with generating 3 random letters
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                        'h', 'i', 'j', 'k', 'l', 'm', 'n',
                        'o', 'p', 'q', 'r', 's', 't', 'u',
                        'v', 'w', 'x', 'y', 'z' };

            //call on the random method
            Random random = new Random();

            //generates a single random letter for each loop which then concatenated on to eachother to create three random letters
            for (int i = 0; i < 3; i++)
                author = author + alphabet[(int)(random.Next(0, 26))];

            //generates a single random number for each loop which then concatenated on to eachother to create three random numbers
            for (int i = 0; i < 3; i++)
                firstNum = firstNum + random.Next(10);

            //generates a single random number for each loop which then concatenated on to eachother to create three random numbers
            for (int i = 0; i < 3; i++)
                secNum = secNum + random.Next(10);

            //concatenates the first three random numbers with a full stop, the second set of random number with the set of random letters
            genCallNum = firstNum + "." + secNum + " " + author.ToUpper();

            //returns the random calling number 
            return genCallNum;


        }

        //method that sorts the list in to ascending order using a bubble sort
        public ArrayList sortedNumList(ArrayList unCallNum)
        {
            /*wedsite: Stackoverflow
             author: Valentin
            link: https://stackoverflow.com/questions/36764347/how-to-bubble-sort-a-string-array*/

            //----------------------------------------------------------------------------------------------------------
            bool swap;
            string temp; 

            do
            {
                swap = false;
                for (int index = 0; index < (unCallNum.Count - 1); index++)
                {
                    if (string.CompareOrdinal(unCallNum[index].ToString(), unCallNum[index + 1].ToString()) > 0) //if first number is greater then second then swap
                    {
   
                        temp = unCallNum[index].ToString();
                        unCallNum[index] = unCallNum[index + 1];
                        unCallNum[index + 1] = temp;
                        swap = true;
                    }
                }


            } while (swap == true);
//------------------------------------------------------

            return unCallNum;
        }
    }
}

