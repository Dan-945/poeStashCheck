using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class Api 
    {
        public static async void Funksjonen()
        {
            var stashesData = await ApiProcessor.LoadpoeInformation();
            Console.WriteLine("skulle hatt lest informasjon");
            Console.WriteLine(stashesData.Results.accountName.ToString());
            Console.WriteLine(stashesData.Results.stashType.ToString());
            Console.WriteLine(stashesData.Results);
            Console.WriteLine(stashesData);
            Program.firstTry = stashesData.Results.stashType.ToString();
            return ;
        }
    }

}
