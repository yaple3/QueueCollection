namespace QueueCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creates the playNext queue
            Queue<string> playNext = new();

            //adding songs to the queue
            playNext.Enqueue("Singin' in the Rain");
            playNext.Enqueue("Makin' Whoopee");
            playNext.Enqueue("Ain't Misbehavin");
            playNext.Enqueue("Sweet Georgia Brown");
            playNext.Enqueue("Stardust");
            playNext.Enqueue("Charleston");

            // displays the queue contents without removing anything
            Console.WriteLine($"You currently have {playNext.Count} songs in the queue");
            foreach (string m in playNext)
            {
                Console.WriteLine(m);
            }

            // adding more songs to the queue
            Console.WriteLine("How many songs would you like to add to the queue?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Song to Add: ");
                playNext.Enqueue(Console.ReadLine());
            }

            // counts the songs in the queue
            Console.WriteLine($"Here are your {playNext.Count()} Songs");
            // displays the queue contents without removing anything
            foreach (string m in playNext)
            {
                Console.WriteLine(m);
            }
            //Check to see if the queue contains a specific item and display a message. (Do not remove this item from the queue.)
            Console.WriteLine("Enter a song to check if it is in the queue");
            string song = Console.ReadLine();
            if (playNext.Contains(song))
            {
                Console.WriteLine($"{song} is in the queue");
            }
            else
            {
                Console.WriteLine($"{song} is not in the queue");
            }


            //Remove at least 1 different item from the queue.
            Console.WriteLine("Would you like to remove a song from the queue (yes or no)?");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.WriteLine("Which song would you like to remove?");
                string songToRemove = Console.ReadLine();
                Queue<string> newQueue = new();
                while (playNext.Count > 0)
                {
                    song = playNext.Dequeue();
                    if (song != songToRemove)
                    {
                        newQueue.Enqueue(song);
                    }
                }
                playNext = newQueue;

                Console.WriteLine("Would you like to remove another song from the queue (yes or no)?");
                answer = Console.ReadLine();
            }

            // displays the queue contents without removing anything
            Console.WriteLine($"You have {playNext.Count} songs left in the queue");
            foreach (string m in playNext)
            {
                Console.WriteLine(m);
            }


            // views the first item in the queue and displays it to determine if the user wants to remove it
            string nextSong = playNext.Peek();
            Console.WriteLine($"Would you like to remove {nextSong} from the beginning of the queue (yes or no)?");
            _ = Console.ReadLine();
            while (answer == "yes")
            {
                _ = playNext.Dequeue(); // removes item from the top of the queue
                //checks to see if there are any songs left in the queue
                if (playNext.Count == 0)
                {
                    break;
                }
                nextSong = playNext.Peek();
                Console.WriteLine($"Would you like to remove {nextSong} from the beginning of the queue (yes or no)?");
                answer = Console.ReadLine();
            }

            if (playNext.Peek() == null)
            {
                Console.WriteLine("The queue is empty");
            }
            else
            {
                // displays the queue contents without removing anything
                Console.WriteLine($"You have {playNext.Count} songs left in the queue");
                foreach (string m in playNext)
                {
                    Console.WriteLine(m);
                }
            }
        }
    }
}

