using System;
class Program {
  public static void Main (string[] args) {
   //PROVIDE INSTRUCTIONS ON HOW TO HOLD AND USE FORTUNE TELLER AND WELCOME
    Console.WriteLine("\t\t\tWELCOME TO THE FORTUNE TELLER GAME\nHERE ARE SOME TIPS! ");
    Console.WriteLine("\n\n\t\t\tStart with Orange in the top right corner \n\t\t\t Always move vertically first!!! \n\t\t\t When inputting always capitalize the first letter!!!");
    //Intialize and declare the key of fortunes
    string lvl1;
    string lvl2 = ("");
    string lvl3 = ("");
    string lvl4 = ("");
    string a = ("Your mouse will break tomorrow");
    string b = ("Your laptop will be below 30%");
    string c = ("Tomorrow's mindful moment won't be so mindful");
    string d = ("You will win a new computer");
    string e = ("Ms. D is mad at you!");
    string f = ("Ms. D loves you!");
    string g = ("You will get an A in Vs.Net!");
    string h = ("Your code works first try without errors!");
     //BEGIN BY ASKING USER FIRST LEVEL: lvl1
    //SET lvl1 GIVEN BY USER AS lvl1 VALUE
    Console.WriteLine("\n\n\nPlease choose either Orange, Blue, Green, or Red\n>");
    lvl1 = Console.ReadLine();
   //first if statment for the 1st level
   if (lvl1== "Green"||lvl1== "Red")
    {
      Console.WriteLine("Pick a number between 1, 2, 5 or 6: ");
      lvl2 = Console.ReadLine();
    }
    if (lvl1== "Blue"||lvl1== "Orange")
    {
      Console.WriteLine("Pick a number between 3, 4, 7 or 8: ");
      lvl2 = Console.ReadLine();
    }
    //asks user for lvl2 input roll lvl2 1
    if (lvl2== "1"||lvl2=="4"||lvl2=="5"||lvl2=="8")
    {
      Console.WriteLine("Pick a number between 3, 4, 7 or 8: ");
      lvl3 = Console.ReadLine();
    }
    if (lvl2=="2"||lvl2=="3"||lvl2=="6"||lvl2=="7")
    {
      Console.WriteLine("Pick a number between 1, 2, 5 or 6: ");
      lvl3 = Console.ReadLine();
    }
    //asks user for fortune input lvl2
    if (lvl3== "1"||lvl3=="4"||lvl3=="5"||lvl3=="8")
    {
      Console.WriteLine("Pick a number between 3, 4, 7 or 8: ");
      lvl4 = Console.ReadLine();
    }
    if (lvl3=="2"||lvl3=="3"||lvl3=="6"||lvl3=="7")
    {
      Console.WriteLine("Pick a number between 1, 2, 5 or 6: ");
      lvl4 = Console.ReadLine();
    }
    //asks user for which fortune lvl2 they want
    if (lvl4== "1")
    {
      Console.WriteLine(a);
    }
    if (lvl4== "2")
    {
      Console.WriteLine(b);
    }
        if (lvl4== "3")
    {
      Console.WriteLine(c);
    }
    if (lvl4== "4")
    {
      Console.WriteLine(d);
    }
    if (lvl4== "5")
    {
      Console.WriteLine(e);
    }
    if (lvl4== "6")
    {
      Console.WriteLine(f);
    }
    if (lvl4== "7")
    {
      Console.WriteLine(g);
    }
    if (lvl4== "8")
    {
      Console.WriteLine(h);
    }
  }
}