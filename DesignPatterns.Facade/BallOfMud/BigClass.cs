namespace DesignPatterns.Facade.BallOfMud
{
    public class BigClass
    {
        private int _i;

        public void SetValueI(int value) => _i = value;

        public void IncrementI(int value) => _i += value;

        public void DecrementI(int value) => _i -= value;

        public int GetValueA() => _i;


        public string GetValueB() => "Big Ball of Mud";
    }
}
