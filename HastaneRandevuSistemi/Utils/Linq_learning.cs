namespace HastaneRandevuSistemi.Utils
{
    public class Linq_learning
    {
        public Linq_learning()
        {
        }

        public static String result() {
            String res="";
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mango" };

            var queryFruits = from fruit in fruits
                              where fruit.Length > 5
                              select fruit;

            foreach (var fruit in queryFruits)
            {
                res +=  fruit.ToString()+ " " ;
            }
            return res;
        }
    }
}
