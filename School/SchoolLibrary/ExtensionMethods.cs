using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public static class ExtensionMethods
    {
        public static int WordCount(this string str)
        {
            //this method will take a body of text and make an array of characters, 
            //split up by space, period, and question mark, and got the length of the array
            //for a word count
            var wordCount = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
    }
}
