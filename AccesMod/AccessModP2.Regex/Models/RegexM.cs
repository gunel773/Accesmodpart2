

namespace AccessModP2.Regex.Models
{
    public class RegexM
    {
        public string Text { get; set; }
        public string pattern = "^m..i$";

        public void RegexMethod1(string text)
        {
            Text = text;
            string[] result = default;
            string[] Regexarr = text.ToString().Split(",");
            


           foreach (string item in Regexarr)
            {

                if () 
                {
                    Console.WriteLine(item); ;
                }
                else
                {
                    Console.WriteLine("teleb olunan yoxdur.");
                }
            }

            


        }

    }
}
