using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTry.Generic_collection_example
{
    internal class ListDemo
    {
        public void SortedDictionaryDemo()
        {
            SortedDictionary<string, int> abc = new SortedDictionary<string, int>();
            abc.Add("b", 1);
                abc.Add("a", 2);
            abc.Add("c", 3);
            foreach (var item in abc)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
        public void metho1()
        {
            //List<string> l1= new List<string>();
            //l1.Add("pune");
            //l1.Add("100");
            //l1.Add("mumbai");

            //foreach (var item in l1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("count="+l1.Count);
            //Console.WriteLine("capacity="+l1.Capacity);
            //List<string> l2 = new List<string>();
            //l2.Add(l1[0]);
            //Console.WriteLine("==============");
            //foreach (var item in l1)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<string, int> RTOCity = new Dictionary<string, int>();
            RTOCity.Add("pune", 12);
            RTOCity.Add("solapur", 13);
            RTOCity.Add("pimpri-Chinchwad", 14);

            foreach (var item in RTOCity)
            {
                Console.WriteLine(item.Key);//pune solapur pimprichi
                Console.WriteLine(item.Value);//12 13 14
            }

            List<string> cities1=new List<string>() { "pune","nagar","Nashik"};
            List<string> cities2 = new List<string>() { "vijaypur", "Banglore" };
            List<string> cities3 = new List<string>() { "patana"};

            Dictionary<string, List<string>> states = new Dictionary<string, List<string>>();
            states.Add("Maharashtra", cities1);
            states.Add("Karnataka", cities2);
            states.Add("Bihar", cities3);

            string Fcity = "patana";

            //bool flag = false;
            //foreach (var item in states)
            //{

            //    foreach (var cty in item.Value)
            //    {
            //        if (string.Compare(Fcity,cty)==0)
            //        {
            //            flag = true;
            //            break;
            //        }
            //    }
            //    if (flag==true)
            //    {
            //        break;
            //    }
            //}
            //if (flag==true)
            //{
            //    Console.WriteLine("found");
            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}
        

            string result = null;
            foreach (var item in states)
            {
                 result = item.Value.FirstOrDefault(x => x == Fcity);
                if (result!=null)
                {
                    Console.WriteLine("found");
                    break;
                }
            }
            if (result==null)
            {
                Console.WriteLine("Not found");
            }
            //foreach (var item in states)
            //{
            //    Console.WriteLine("state:"+item.Key);
            //    foreach (var cty in item.Value)
            //    {
            //        Console.Write(" "+cty);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
