using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task task = null;
            Jukebox jukebox= new Jukebox();
            jukebox.InsertCoin();
            jukebox.InsertCoin();
            task = jukebox.PlayMusic();
            jukebox.InsertCoin(); //Made it so that customer can add music while listening to music and 
            jukebox.StopMusic(); //doesn't have to wait for all the musics to end in order to add a music                     
            await task;
            
            jukebox.InsertCoin();
            jukebox.InsertCoin();
            jukebox.PlayMusic();


            Console.ReadLine();
        }
    }
}
