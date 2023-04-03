using System;

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        int x = Console.WindowWidth / 2;
        int y = Console.WindowHeight / 2;
        int dx = 1, dy = 1;
        string[] frames = new string[] {
            @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
      /   \    
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
     /   \     
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
    /   \      
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
   /   \       
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
  /   \        
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
 /   \         
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
/   \          
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
 \   /         
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
  \   \        
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
   \   \       
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
    \   \      
", @"
     /\_/\    
    ( o o )   
   ==_~(_~_)_
     \   \     
"};
        int currentFrame = 0;
        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(frames[currentFrame]);
            currentFrame = (currentFrame + 1) % frames.Length;
            x += dx;
            y += dy;
            if (x >= Console.WindowWidth - 14 || x <= 0)
            {
                dx = -dx;
            }
            if (y >= Console.WindowHeight - 4 || y <= 0)
            {
                dy = -dy;
            }
            System.Threading.Thread.Sleep(100);
        }
    }
}
