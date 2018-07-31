static public void HTML(string input, List<Product> prdct)
        {
            Uri url = new Uri(input);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument documents = new HtmlAgilityPack.HtmlDocument();
            documents.LoadHtml(html);

            HtmlNodeCollection titles = documents.DocumentNode.SelectNodes("//span[@class='item-name']");
            HtmlNodeCollection prices = documents.DocumentNode.SelectNodes("//span[@class='item-price']");
            HtmlNodeCollection categories = documents.DocumentNode.SelectNodes("//li[@class='active']");
            HtmlNodeCollection quantity = documents.DocumentNode.SelectNodes("//span[@class='productUnit']");
            string t = "";
            string p = "";
            string c = "";
            string q = "";
            for(var i = 0; i < titles.Count; i++)
            {
                //Console.WriteLine(titles[i].InnerText);
                t = titles[i].InnerText;
                if(prices != null)
                {
                    if (i < prices.Count)
                    {
                        //Console.WriteLine(prices[i].InnerText);
                        p = prices[i].InnerText;
                    }
                    else
                    {
                        p = " ";
                        //Console.WriteLine(" ");
                    }
                }
                else
                {
                    p = " ";

                }

                if (categories != null)
                {
                    if (i < categories.Count)
                    {
                        c = categories[i].InnerText;
                        //Console.WriteLine(categories[i].InnerText);
                    }
                    else
                    {
                        // Console.WriteLine(" ");
                        c = " ";

                    }
                }
                else
                {
                    c = " ";

                }

                if (quantity != null)
                {
                    if (i < quantity.Count)
                    {
                        q = quantity[i].InnerText;
                        //Console.WriteLine(quantity[i].InnerText);
                    }
                    else
                    {
                        q = " ";
                        //Console.WriteLine(" ");
                    }
                }
                else
                {
                    q = " ";
                }
                
                prdct.Add(new Product(t,c,p,q));
                //Console.WriteLine("---------------");

            }
            Console.Write(".............");



        }
