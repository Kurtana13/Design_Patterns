using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JukeboxStates
{
    public abstract class IState
    {
        protected Jukebox.Jukebox jukebox;

        public void SetContext(Jukebox.Jukebox jukebox)
        {
            this.jukebox = jukebox;
        }

        public abstract void PlayMusic(string musicName);
        public abstract void StopMusic();
        public abstract void InsertCoin();

    }

    public class PlayingState : IState
    {
        public override void InsertCoin()
        {
            Console.WriteLine("Add music to the list!");
            jukebox.AddMusic();
        }

        public override void PlayMusic(string musicName)
        {
            Console.WriteLine($"Playing {musicName}");
            Thread.Sleep(5000);
            Console.WriteLine($"{musicName} has Finished");
        }

        public override void StopMusic()
        {
            Console.WriteLine("Finishing the last music!");
            jukebox._tokensource = new CancellationTokenSource();
            jukebox._tokensource.Cancel();
            jukebox.StateTransition(new IdleState());
        }

    }

    public class IdleState : IState
    {
        public override void InsertCoin()
        {
            Console.WriteLine("Coin inserted choose a music!");
            jukebox.AddMusic();
        }

        public override void PlayMusic(string musicName)
        {
            Console.WriteLine($"Playing {musicName}");
            Thread.Sleep(5000);
            Console.WriteLine($"{musicName} has Finished");
        }

        public override void StopMusic()
        {
            Console.WriteLine("Cannot stop music during idle");
        }
    }
}
