namespace TestProject
{
    public class Dollar
    {
        public decimal Amount { get; private set; }

        private Dollar(decimal amount)
        {
        }

        public static Dollar Give(decimal amount)
        {
            return new Dollar(amount);
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(multiplier);
        }
    }
}