namespace DesignPatterns.Bridge
{
    public class Remote
    {
        private readonly IDevice _device;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if (_device.IsEnabled())
            {
                _device.Disable();

                return;
            }

            _device.Enable();
        }

        public void TurnVolumeUp()
        {
            var volume = _device.GetVolume();
            _device.SetVolume(volume + 10);
        }

        public void TurnVolumeDown()
        {
            var volume = _device.GetVolume();
            _device.SetVolume(volume - 10);
        }

        public void Mute()
        {
            _device.SetVolume(0);
        }
    }

    public interface IDevice
    {
        bool IsEnabled();

        void Enable();

        void Disable();

        void SetVolume(int volume);

        int GetVolume();
    }

    public class TV : IDevice
    {
        private bool _enabled;
        private int _volume = 35;

        public void Disable()
        {
            _enabled = false;

            Console.WriteLine("TV is turned off");
        }

        public void Enable()
        {
            _enabled = true;

            Console.WriteLine("TV is turned on");
        }

        public int GetVolume()
        {
            return _volume;
        }

        public bool IsEnabled()
        {
            return _enabled;
        }

        public void SetVolume(int volume)
        {
            _volume = volume;

            Console.WriteLine($"TV's volume is set to {_volume}");
        }
    }
}