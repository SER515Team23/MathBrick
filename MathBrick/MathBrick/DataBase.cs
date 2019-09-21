namespace MathBrick
{
    sealed class DataBase
    {
        public static DataBase Instance => instance;
        private static readonly DataBase instance = new DataBase();
        static DataBase()
        {

        }

        public bool IsOddNumber(int num)
        {
            return (num % 2 == 1);
        }
    }
}
