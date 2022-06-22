internal class Program
{
    private static void Main(string[] args)
    {

        Console.Title = "Name randomizer 1.2 Made by: FLKS";

        List<string> NameList = new List<string>();                                                    //Create a list
        
        Random randomnumber = new Random();                                                            //Generator random numbers
        bool alreadyTyped; alreadyTyped = false;                                                       // Bool to see if the user as already typed a name
        
        
        Console.WriteLine("Type here how many names you want to randomize:");
        Console.Write(" "); int numberofNames = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(300); Console.Clear();                                                            //Clear screen
        Console.WriteLine("How many output names you want:");
        Console.Write(" "); int numberofnamesRandomized = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(300); Console.Clear();                                                            //Clear screen
        
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < numberofNames; i++){                                                       //This is gona repeat the names the user wanted to randomized
            
           

            if(alreadyTyped == false){                                                                 //Condition to not show the same message every time
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Type here the names you want to randomize:");
            }
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" "); string nametoadd = Convert.ToString(Console.ReadLine());               //Reads the input from the user
            NameList.Add(nametoadd);                                                                   //Gona add the name to the list "NameList"
            alreadyTyped = true;                                                                       // This is foor a condtion in line 20
        }
        
        Thread.Sleep(300); Console.Clear();                                                            //Clear the console
        Console.WriteLine("Here is the final result:"); 
        Console.ForegroundColor = ConsoleColor.Green;                                                  // Sets the result to green
    
       
        for(int i = 0; i < numberofnamesRandomized; i++){                                              // This is gona repeat how many names the user wanted to randomized

            if(numberofnamesRandomized == 1){                                                          //If the desire output of the user equals one(1)
                Console.WriteLine(NameList[randomnumber.Next(numberofNames)]);                         //Outputs a random number of the list
            }
            else{
                string name1 = NameList[randomnumber.Next(NameList.Count)];                            //Sets name1 to a random string  of the list
                Console.WriteLine(name1);                                                              //Outputs the string
                NameList.Remove(name1);                                                                //Removes the same string on the list to not GET the same output twice
            }
        }
            
        Exit();                                                                                        // This is a function to close the dscreen
    }

    public static void Exit(){                                                                         //Function to close the console when the user inputs any letter or number
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Black;
        Thread.Sleep(750); 
        Console.ReadLine();
    }
}