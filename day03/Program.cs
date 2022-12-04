int priotitiessum = 0;
Dictionary<string, int> priorities = new Dictionary<string, int>();

priorities.Add("a", 1);
priorities.Add("b", 2);
priorities.Add("c", 3);
priorities.Add("d", 4);
priorities.Add("e", 5);
priorities.Add("f", 6);
priorities.Add("g", 7);
priorities.Add("h", 8);
priorities.Add("i", 9);
priorities.Add("j", 10);
priorities.Add("k", 11);
priorities.Add("l", 12);
priorities.Add("m", 13);
priorities.Add("n", 14);
priorities.Add("o", 15);
priorities.Add("p", 16);
priorities.Add("q", 17);
priorities.Add("r", 18);
priorities.Add("s", 19);
priorities.Add("t", 20);
priorities.Add("u", 21);
priorities.Add("v", 22);
priorities.Add("w", 23);
priorities.Add("x", 24);
priorities.Add("y", 25);
priorities.Add("z", 26);

priorities.Add("A", 27);
priorities.Add("B", 28);
priorities.Add("C", 29);
priorities.Add("D", 30);
priorities.Add("E", 31);
priorities.Add("F", 32);
priorities.Add("G", 33);
priorities.Add("H", 34);
priorities.Add("I", 35);
priorities.Add("J", 36);
priorities.Add("K", 37);
priorities.Add("L", 38);
priorities.Add("M", 39);
priorities.Add("N", 40);
priorities.Add("O", 41);
priorities.Add("P", 42);
priorities.Add("Q", 43);
priorities.Add("R", 44);
priorities.Add("S", 45);
priorities.Add("T", 46);
priorities.Add("U", 47);
priorities.Add("V", 48);
priorities.Add("W", 49);
priorities.Add("X", 50);
priorities.Add("Y", 51);
priorities.Add("Z", 52);


try{
    using (var sr = new StreamReader("input.txt")){
        String line;
        while ((line = sr.ReadLine()) != null){

            //Console.WriteLine(line);

            String front = line.Substring(0, line.Length/2);
            String back = line.Substring(line.Length /2, line.Length /2);

            char[] frontchar = front.ToCharArray();
            
            for (int i = 0; i < frontchar.Length; i++)
            {
                if (back.Contains(frontchar[i])){
                    //ConsoleDateTime("Letter: " + frontchar[i]);
                    priotitiessum += priorities[frontchar[i].ToString()];
                    break;
                }
            }

            //ConsoleDateTime("FRONT: " + front + " BACK " + back);

        }
    }
}
catch(IOException e){
    ConsoleDateTime("[ERROR] " + e.Data.ToString());
}

ConsoleDateTime("Sum of Priotities: " + priotitiessum);



int sumbadgepriotie = 0;

String bag1 = "";
String bag2 = "";
String bag3 = "";
try{
    using (var sr = new StreamReader("input.txt")){

        String line;

        while ((line = sr.ReadLine()) != null){

            //Console.WriteLine(line);

            if(bag1 == ""){
                bag1 = line;
            }
            else if(bag2 == ""){
                bag2 = line;
            }
            else if(bag3 == ""){
                bag3 = line;

                bool allset = false;
                char[] bag1char = bag1.ToCharArray();
                char[] bag2char = bag2.ToCharArray();
                char[] bag3char = bag3.ToCharArray();

                for (int i = 0; i < bag1char.Length; i++)
                {
                    for (int j = 0; j < bag2char.Length; j++)
                    {
                        for (int l = 0; l < bag3char.Length; l++)
                        {
                            if(bag1char[i] == bag2char[j]){
                                if(bag1char[i] == bag3char[l]){
                                    ConsoleDateTime("Bag1: " + bag1char[i] + " Bag2: " + bag2char[j] + " Bag3 " + bag3char[l]);
                                    if(allset){
                                        break;
                                    }
                                    else{
                                        sumbadgepriotie += priorities[bag1char[i].ToString()];
                                        allset = true;
                                    }
                                    break;
                                }
                            }   
                        }
                    }
            }

                bag1 = "";
                bag2 = "";
                bag3 = "";

                bag1char = null;
                bag2char = null;
                bag3char = null;

                allset = false;
            }

        }
    }
}
catch(IOException e){
    ConsoleDateTime("[ERROR] " + e.Data.ToString());
}

ConsoleDateTime("Badge SUM: " + sumbadgepriotie);

void ConsoleDateTime(String msg){
    Console.WriteLine("(" + DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + ") " + msg);
}
