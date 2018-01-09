using System;

namespace Word_DLL
{

    public static class plural
    {
        /// <summary>
        /// Returns the plural form of the specified word.
        /// </summary>
        /// <param name="count">How many of the specified word there are. A count equal to 1 will not pluralize the specified word.</param>
        /// <returns>A string that is the plural form of the input parameter.</returns>
        public static string ToPlural(this string @this, int count = 0)
        {
            return count == 1 ? @this : System.Data.Entity.Design.PluralizationServices.PluralizationService.CreateService(new System.Globalization.CultureInfo("en-US")).Pluralize(@this);
        }

    }

    public  class Words
    {

        public  string Pluralize(string theWord) {
            
            string plural = theWord.ToPlural();
            // Console.WriteLine(theWord + " in plural form is " + theWord.ToPlural());
            theWord = theWord + " in plural form is " + plural;
            return theWord;
        }

    }
}
