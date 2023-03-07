// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

static string ReverseDateFormat(string sourceData){
    const int TIMEOUT = 1000;
    try{
        return Regex.Replace(sourceData,
        @"^(?<mon\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$",
        "${year}-${mon}-${day}", RegexOptions.None,
        TimeSpan.FromMilliseconds(TIMEOUT));
        
    }
    catch(RegexMatchTimeoutException){
        return sourceData;
    }
}

do{
    Console.WriteLine("Date to Convert? (Use mm/dd/yyyy, or exit to quit)");
    string inputstr = Console.ReadLine();

    if(inputstr == "exit"){
        break;
    }
    else{
        DateTime result;
        if(DateTime.TryParse(inputstr, out result)){
            string reverseDate = ReverseDateFormat(inputstr);
            Console.WriteLine($"The reversed format is {reverseDate}");
        }
        else{
            Console.WriteLine("That's not a valid date");
        }
    }

}while(true);