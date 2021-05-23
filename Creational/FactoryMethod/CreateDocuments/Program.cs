using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDocuments
{
    class Program
    {
        /// <summary>
        /// Factory method design pattern. Real world example
        /// Client code
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // constructors call Factory method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            //Display document pages
            foreach (var document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
