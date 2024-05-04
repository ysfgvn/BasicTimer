using System.Media;

namespace BasicTimer 

{ 
class Program 
    
    {
        
        static void Main(string[] args) { 
Console.WriteLine("Hello welcome to basic timer! You can create your timer basically ");
Console.WriteLine("Please enter hour (if you don't want to set hour, just type 0 and proceed to minutes and seconds): ");
int hour = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter minutes");
int minutes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter seconds");
int seconds = Convert.ToInt32(Console.ReadLine());
DateTime startingTime = DateTime.Now;
DateTime endingTime = startingTime.AddHours(hour).AddMinutes(minutes).AddSeconds(seconds);



Console.WriteLine("\n");
Console.WriteLine("Timer is started!");
            Console.WriteLine("\n");

            while (DateTime.Now < endingTime)
{
    TimeSpan timeSpan = endingTime - DateTime.Now;
                Console.Write($"\rRemaining Time: {(endingTime - DateTime.Now).ToString(@"hh\:mm\:ss")} ");
    Thread.Sleep(1000);
}
            Console.WriteLine("\n");

            Console.WriteLine("\nTimer is ended!");
            SoundPlayer sound = new SoundPlayer ("infernospawnmusic.wav");
            sound.PlaySync();
        }
    }
}
