static void Main(string[] args)
        {
            List<Product> prdct = new List<Product>();

            string x= "";
        
            HTML(x,prdct);
            Console.WriteLine("It is completed");
            string filename = DateTime.Now.ToString();
            //StreamWriter sw = File.CreateText("list.csv");
            StreamWriter sw = new StreamWriter(File.Open("list.csv", FileMode.Create), Encoding.UTF8);
            foreach(var s in prdct)
            {
                string t = "";
                t = s.title + "; " + s.price + "; " + s.category + "; " + s.quantity;
                Console.WriteLine(t);
                sw.WriteLine(t);
            }
            Console.ReadKey();



        }
