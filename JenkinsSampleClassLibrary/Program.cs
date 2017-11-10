namespace JenkinsSampleClassLibrary
{
    public class Program
    {
        public bool Main(string isSuccess)
        {
            bool conversionPossible;           

            var result = bool.TryParse(isSuccess, out conversionPossible);

            if (conversionPossible)
            {
                return result;
            }

            return false;
        }
    }
}
