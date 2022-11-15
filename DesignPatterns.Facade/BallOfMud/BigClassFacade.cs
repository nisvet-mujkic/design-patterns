namespace DesignPatterns.Facade.BallOfMud
{
    public class BigClassFacade
    {
        private readonly BigClass _bigClass;

        public BigClassFacade()
        {
            _bigClass = new BigClass();
            _bigClass.SetValueI(0);
        }

        public void IncrementBy(int value) => _bigClass.IncrementI(value);

        public void DecrementBy(int value) => _bigClass.DecrementI(value);

        public int GetCurrentValue() => _bigClass.GetValueA();
    }
}