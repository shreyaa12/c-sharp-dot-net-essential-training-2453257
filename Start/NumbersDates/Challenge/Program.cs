// See https://aka.ms/new-console-template for more information
string theDate = "";
DateTime today = DateTime.Today;

do {
    Console.WriteLine($"Which Date? or (EXIT) ");
    theDate = Console.ReadLine();

    if(theDate == "EXIT" ^ theDate == "exit"){
        break;
    } 
    DateTime parsedDate ;
    TimeSpan ts; 
if(DateTime.TryParse(theDate, out parsedDate )){
    if(parsedDate > today){
        ts = parsedDate - today;
        Console.WriteLine($"The entered date is yet to come in {ts.Days} days!" );
    }
    else if(parsedDate == today){
        Console.WriteLine($"The entered date is today!" );
    }
    else{
        ts = today - parsedDate;
        Console.WriteLine($"The entered date went by {ts.Days} days ago!" );
    }
}
else{
    Console.WriteLine($"The date is invalid");
}

}
while ( theDate != "EXIT" ^ theDate != "exit");