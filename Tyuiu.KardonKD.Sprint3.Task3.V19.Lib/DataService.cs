namespace Tyuiu.KardonKD.Sprint3.Task3.V19.Lib
{
    public class DataService
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    value = value.Replace(c, replacement);
                }
            }
            return value;
        }
    }
}
