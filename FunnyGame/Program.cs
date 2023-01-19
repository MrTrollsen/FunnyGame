Console.WriteLine("welcome to tamagotchi game");

Tamagotchi tamaClone = new Tamagotchi();

Console.WriteLine("Choose name for Tamagotchi");
tamaClone.name = Console.ReadLine();

Console.WriteLine($"ok! {tamaClone.name} is a mediocre name but thats alright!!");

 (while tamaClone.GetAlive() == true)
{
    Console.Clear();
    tamaClone.PrintStats();
    Console.WriteLine("now what?");
    Console.WriteLine($"1. Teach {tamaClone.name} a new term");
    Console.WriteLine($"2. Talk to {tamaClone.name}");
    Console.WriteLine($"3. Feed {tamaClone.name}");
    Console.WriteLine($"4. Do nothing");

  string NowWhat = Console.ReadLine();
  if (NowWhat == "1")
  {
    Console.WriteLine("What word?");
    string word = Console.ReadLine();
    tamaClone.Teach(word);
  }
  if (NowWhat == "2")
  {
    tamaClone.Hi();
  }
  if (NowWhat == "3")
  {
    tamaClone.Feed();
  }
  else
  {
    Console.WriteLine("Doing nothing...");
  }
  tamaClone.Tick();
  
}

Console.WriteLine($"OH NO! {tamaClone.name} is dead!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();

