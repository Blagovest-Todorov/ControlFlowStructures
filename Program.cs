using System;
using System.Collections;

namespace ControlFlowStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // ControlFlowStructure -If, else, Switch, For, while -- >Loops
            // make dependacies obious
            // data  = GetData();  ->  document control flow 
            // groupedData = GroupData(data);
            // PrintGroupedData(groupedData);
            //straight line code ->ordering dependencies, dependancies shoud be mnade clear !
            // in if statments always steart wiht most commoncase - > going down to unusuals 
            Hashtable openwith = new Hashtable();
            openwith.Add("txt", "nodepad.exe");
            openwith.Add("bmp", "paint.exe");
            openwith.Add("dib", "paint.exe");
            openwith.Add("rft", "wordpad.exe");

            try
            {
                openwith.Add("txt", "winword.exe");
            }
            catch (Exception)
            {

                Console.WriteLine("an element with key = \"txt\" alredy exists");
            }

            var table = new Hashtable();
            //  Hashtable works with objects, dicstionary is genric type// the HashTable is non generic collection that store key-vlaue pairs;
            // table.Add("A", new AWorker());
            // starting with positive expression is better and improves the readablility 
            // more than three if statements are not allowed, bad readability , simplifies the logic of code !
            // avoid deep nesting !

        }
    }
}
