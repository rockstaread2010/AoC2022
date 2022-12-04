try{
    using (var sr = new StreamReader("input.txt")){
        String line;
        while ((line = sr.ReadLine()) != null){
        
        }
    }
}
catch(IOException e){
    ConsoleDateTime("[ERROR] " + e.Data.ToString());
}

void ConsoleDateTime(String msg){
    Console.WriteLine("(" + DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + ") " + msg);
}
