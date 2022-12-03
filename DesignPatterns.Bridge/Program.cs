namespace DesignPatterns.Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Bridge - one of the structural design patterns that allows you to separate the abstraction from the implementation.
             */

            var remote = new Remote(new TV());

            remote.TogglePower();
            remote.TurnVolumeUp();
            remote.TurnVolumeUp();

            remote.Mute();
        }
    }
}