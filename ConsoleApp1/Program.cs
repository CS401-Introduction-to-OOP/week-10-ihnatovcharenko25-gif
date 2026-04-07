using ConsoleApp1;


//Нічого не встиг, нічо не зрозумів

Random random = new Random();

var myParty = new Party();
var myEventLog = new EventLog();

int ch_i = 0;
int ev_i = 0;

Console.WriteLine("'0' to quit");
Console.WriteLine("'1' to generate new character");
Console.WriteLine("'2' to generate new event");
Console.WriteLine("'3' to print all party");
Console.WriteLine("'4' to print all events");
Console.WriteLine("'5' to print all characters alive");
Console.WriteLine("'6' to get all wounded");
Console.WriteLine("'7' to get all events");

bool run = true;
while (run)
{
    string input = Console.ReadLine();
    switch (input)
    {
        case "0" : run = false; break;
        case "1":
        {
            ch_i++;
            myParty.Add(new Character($"Name{ch_i}", $"Class{ch_i}", random.Next()%100, random.Next()%100, random.Next()%100, "Alive"));
            break;
        }
        case "2":
        {
            ev_i++;
            myEventLog.Add(new Event(ev_i, $"description_{ev_i}", $"type_{ev_i}", $"change_{ev_i}"));
            break;
        }
        case "3":
        {
            Console.WriteLine("Party List");
            foreach (var c in myParty) 
                Console.WriteLine(c);
            break;
        }
        case "4" : 
        {
            Console.WriteLine("Event List");
            foreach (var e in myEventLog) 
                Console.WriteLine(e);
            break;
        }
        case "5":
        {
            Console.WriteLine("Alive Characters");
            foreach (var c in myParty.GetIAliveEnumerator()) 
                Console.WriteLine(c);
            break;
        }
    }
}


Console.WriteLine("Enter 'new' to create a character");
while (Console.ReadLine() == "new")
{
    
}

Console.WriteLine(myParty.MaxLevel());
