
int opponentscore = 0;
int myscore = 0;

try{
    using (var sr = new StreamReader("input.txt")){
        String line;
        while ((line = sr.ReadLine()) != null){
           String[] str = line.Split(' ');
           String opponentplay = str[0];
           String myplay = str[1];

           String opponentplayconverted = "";
            switch(opponentplay){
                case "A":
                    opponentplayconverted = "rock";
                    opponentscore += 1;
                    break;
                case "B":
                    opponentplayconverted = "paper";
                    opponentscore += 2;
                    break;
                case "C":
                    opponentplayconverted = "scissors";
                    opponentscore += 3;
                    break;
                default:
                    break;
            }

           String myplayconverted = "";
            switch(myplay){
                case "X":
                    myplayconverted = "rock";
                    myscore += 1;
                    break;
                case "Y":
                    myplayconverted = "paper";
                    myscore += 2;
                    break;
                case "Z":
                    myplayconverted = "scissors";
                    myscore += 3;
                    break;
                default:
                    break;
            }

            String outcome = "";

            //DRAWS
                if(myplayconverted == opponentplayconverted){
                    myscore += 3;
                    opponentscore += 3;
                    outcome = "draw";
                }

                if(myplayconverted.Equals("rock") && opponentplayconverted.Equals("scissors")){
                    myscore += 6;
                    outcome = "win";
                }
                else if(myplayconverted.Equals("scissors") && opponentplayconverted.Equals("paper")){
                    myscore += 6;
                    outcome = "win";
                }
                else if(myplayconverted.Equals("paper") && opponentplayconverted.Equals("rock")){
                    myscore += 6;
                    outcome = "win";
                }
                else if(opponentplayconverted.Equals("rock") && myplayconverted.Equals("scissors")){
                    opponentscore += 6;
                    outcome = "lost";
                }
                else if(opponentplayconverted.Equals("scissors") && myplayconverted.Equals("paper")){
                    opponentscore += 6;
                    outcome = "lost";
                }
                else if(opponentplayconverted.Equals("paper") && myplayconverted.Equals("rock")){
                    opponentscore += 6;
                    outcome = "lost";
                }

            ConsoleDateTime("MYPLAY: " + myplayconverted.ToUpper() + " OpponentPlay: " + opponentplayconverted.ToUpper() + " || OUTCOME: " + outcome.ToUpper());

        }
    }
}
catch(IOException e){
    ConsoleDateTime("[ERROR] " + e.Data.ToString());
}

ConsoleDateTime("MY Final Score: " + myscore);


int opponentscorepart2 = 0;
int myscorepart2 = 0;

try{
    using (var sr = new StreamReader("input.txt")){
        String line;
        while ((line = sr.ReadLine()) != null){
           String[] str = line.Split(' ');
           String opponentplay = str[0];
           String outcome = str[1];

           String opponentplayconverted = "";
            switch(opponentplay){
                case "A":
                    opponentplayconverted = "rock";
                    opponentscore += 1;
                    break;
                case "B":
                    opponentplayconverted = "paper";
                    opponentscore += 2;
                    break;
                case "C":
                    opponentplayconverted = "scissors";
                    opponentscore += 3;
                    break;
            }

            String outcomeconverted = "";

            switch (outcome){
                case "X":
                    outcomeconverted = "lost";
                    break;
                case "Y":
                    outcomeconverted = "draw";
                    myscorepart2 += 3;
                    break;
                case "Z":
                    outcomeconverted = "win";
                    myscorepart2 += 6;
                    break;
            }

            switch(opponentplayconverted){
                case "rock":
                    switch(outcomeconverted){
                        case "lost":
                            myscorepart2 += 3;
                            break;
                        case "draw":
                            myscorepart2 += 1;
                            break;
                        case "win":
                            myscorepart2 += 2;
                            break;
                    }
                    break;
                case "paper":
                    switch(outcomeconverted){
                        case "lost":
                            myscorepart2 += 1;
                            break;
                        case "draw":
                            myscorepart2 += 2;
                            break;
                        case "win":
                            myscorepart2 += 3;
                            break;
                    }
                    break;
                case "scissors":
                    switch(outcomeconverted){
                        case "lost":
                            myscorepart2 += 2;
                            break;
                        case "draw":
                            myscorepart2 += 3;
                            break;
                        case "win":
                            myscorepart2 += 1;
                            break;
                    }
                    break;
            }
        }
    }
}
catch(IOException e){
    ConsoleDateTime("[ERROR] " + e.Data.ToString());
}

ConsoleDateTime("MY Final Score: " + myscorepart2);

void ConsoleDateTime(String msg){
    Console.WriteLine("(" + DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + ") " + msg);
}
