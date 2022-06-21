internal class Program
{
    private static void Main(string[] args)
    {
        List<string> NameList = new List<string>(); //Create a list
        
        Random randomnumber = new Random(); //Generator random numbers
        bool alreadyTyped; alreadyTyped = false; // Bool to see if the user as already typed a name
        
        
        Console.WriteLine("Type here how many names you want to randomize:");
        int numberofNames = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(300); Console.Clear(); //Clear screen
        Console.WriteLine("How many output names you want:");
        int numberofnamesRandomized = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(300); Console.Clear(); //Clear screen
        
        
        for (int i = 0; i < numberofNames; i++){ //This is gona repeat the names the user wanted to randomized
            
            if(alreadyTyped == false){ //Condition to not show the same message every time
                Console.WriteLine("Type here the names you want to randomize:");
            }
            
            string nametoadd = Convert.ToString(Console.ReadLine()); //Reads the input from the user
            NameList.Add(nametoadd); //Gona add the name to the list "NameList"
            alreadyTyped = true; // This is foor a condtion in line 20
        }
        
        Thread.Sleep(300); Console.Clear(); // Clear the console
        Console.WriteLine("Here is the final result:"); 
        Console.ForegroundColor = ConsoleColor.Green; // Sets the result to green
    
       
        for(int i = 0; i < numberofnamesRandomized; i++){ // This is gona repeat how many names the user wanted to randomized
            Console.WriteLine(NameList[randomnumber.Next(numberofNames)]);
        }
            
        Exit(); // This is a function to close the screen
    }

    public static void Exit(){ //Function to close the console when the user inputs any letter or number
        Thread.Sleep(750); 
        Console.ReadLine();
    }
}