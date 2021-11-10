using System;
using System.Collections.Generic;
using System.Text;

namespace _190133369Task1
{
    class MatchColQues
    {
        //declared dictionaries that store the call numbers and descriptions 
       public  Dictionary<int , string> SetACall { get; }
        public Dictionary<int, string> SetADes { get; }
        public Dictionary<int, string> SetBCall { get; }
        public Dictionary<int, string> SetBDes { get; }

        public MatchColQues()
        {
            //Populating the dictionaries with call numbers and descriptions 
            //This is the first set of questions
            SetACall = new Dictionary<int, string>
            {

                { 1, "005.73"},
                { 2, "547.63" },
                { 3, "775.80" },
                { 4, "112.46" }
            };
            SetADes = new Dictionary<int, string> {
                { 1, "Art & recreation" },
                {2, "Religion" },
                { 3, "Languages" },
                { 4, "General knowledge" },
                { 5, "History & geography" },
                { 6, "Science" },
                { 7, "Philosophy & psychology" }
                };

            //This is the second set of questions
            SetBCall = new Dictionary<int, string>
            {
                { 1, "Social sciences" },
                { 2, "Literature" },
                { 3, "Technology" },
                { 4, "General knowledge" }
        };


            SetBDes = new Dictionary<int, string>
            {
                { 1, "002.89" },
                { 2, "999.99" },
                { 3, "795.12" },
                { 4, "877.64" },
                { 5, "118.05" },
                { 6, "648.73" },
                { 7, "323.55" }

        };
        }

      
    }
}
