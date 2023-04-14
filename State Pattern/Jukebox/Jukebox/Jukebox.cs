using JukeboxStates;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jukebox
{
    public class Jukebox
    {
        private IState JukeboxState = null;
        private Queue<Music> musicQueue = new Queue<Music>();
        public CancellationTokenSource _tokensource = null;
        public Jukebox() {
            StateTransition(new IdleState());
        }

        public void StateTransition(IState state)
        {
            JukeboxState = state;
            JukeboxState.SetContext(this);
        }

        public void InsertCoin()
        {
            JukeboxState.InsertCoin();
        }

        public async Task PlayMusic()
        {
            if (_tokensource != null) _tokensource = null;
            if (musicQueue.Count != 0)
            {
                StateTransition(new PlayingState());
                while (musicQueue.Count > 0)
                {
                    if (_tokensource != null)
                    {
                        return;
                    }
                    await Task.Run(() => JukeboxState.PlayMusic(musicQueue.Dequeue().Title));
                }
                Console.WriteLine("No more musics left to play!");
            }
            else
            {
                StateTransition(new IdleState());
            }
        }

        public void StopMusic()
        {
            JukeboxState.StopMusic();
            musicQueue.Clear();
        }

        public void AddMusic()
        {
            Console.WriteLine("Name of the music");
            musicQueue.Enqueue(new Music(Console.ReadLine()));
        }
    }
}
