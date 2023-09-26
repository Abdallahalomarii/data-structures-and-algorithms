namespace Challange_33_Hashmap_LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashMap<string, string> map = new HashMap<string, string>();
            HashMap<string, string> map2 = new HashMap<string, string>();

            map.Set("diligent", "employed");
            map.Set("fond", "enamored");
            map.Set("guide", "usher");
            map.Set("outfit", "garb");
            map.Set("wrath", "anger");
            map2.Set("diligent", "idle");
            map2.Set("fond", "averse");
            map2.Set("guide", "follow");
            map2.Set("flow", "jam");
            map2.Set("wrath", "delight");

            //map.Print();

            var x = LeftJoin(map, map2);

            foreach (var x2 in x)
            {
                foreach (var x3 in x2)
                {
                    if (x3 == null)
                    {
                        Console.Write("NULL" + " ");
                    }
                    else
                    {
                        Console.Write(x3 + " ");

                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static List<List<string>> LeftJoin(HashMap<string, string> map1, HashMap<string, string> map2)
        {
            List<List<string>> rows = new List<List<string>>();
            for (int i = 0; i < map1.Map.Length; i++)
            {
                List<string> array = new List<string>();
                if (map1.Map[i] != null)
                {
                    foreach (var node in map1.Map[i])
                    {
                        array.Add(node.Key);
                        array.Add(node.Value.FirstOrDefault());
                        if (map2.Has(node.Key))
                        {
                            var x = map2.Get(node.Key);
                            if (x != null)
                                array.Add(x.FirstOrDefault().ToString());
                        }
                        else
                        {
                            array.Add(null);
                        }

                    }
                }
                if (array.Count > 0)
                    rows.Add(array);
            }
            return rows;
        }
    }
}
