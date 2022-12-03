Int64[] elfcallories = new Int64[250];

try{
    using (var sr = new StreamReader("input.txt")){
        int currentelf = 1;
        elfcallories[currentelf] = 0;
        String line;
        while ((line = sr.ReadLine()) != null){
            if (line == "")
            {
                //ConsoleDateTime("Elf: " + currentelf + " Callories: " + elfcallories[currentelf]);
                currentelf++;
                elfcallories[currentelf] = 0;
                //ConsoleDateTime("new Elf Time!");
            }
            else{
                elfcallories[currentelf] += int.Parse(line);
                //ConsoleDateTime(line);
            }
        }
    }
}
catch(IOException e){
    ConsoleDateTime("[ERROR] " + e.Data.ToString());
}

//Doesn't Sort Correctly
int topelf = 0;
int secondelf = 0;
int thirdelf = 0;
for (int i = 1; i < elfcallories.Length; i++)
{
    if(topelf == 0){
        topelf = i;
    }
    else{
        if(elfcallories[i] > elfcallories[topelf]){
            thirdelf = secondelf;
            secondelf = topelf;
            topelf = i;
        }
    }
}
    ConsoleDateTime("Current Top Elf: " + topelf + " Callories: " + elfcallories[topelf]);
    ConsoleDateTime("Current Top Elf: " + secondelf + " Callories: " + elfcallories[secondelf]);
    ConsoleDateTime("Current Top Elf: " + thirdelf + " Callories: " + elfcallories[thirdelf]);
    ConsoleDateTime("Top 3 Elvs Total Elf Calories " + (elfcallories[topelf] + elfcallories[secondelf] + elfcallories[thirdelf]));


    // Works :P
    Int64[] elfcallories2 = elfcallories;

    Array.Sort(elfcallories2);
    Array.Reverse(elfcallories2);


    ConsoleDateTime("Top 3 Elvs Total Elf Calories 2 " + (elfcallories[0] + elfcallories[1] + elfcallories[2]));



void ConsoleDateTime(String msg){
    Console.WriteLine("(" + DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + ") " + msg);
}
