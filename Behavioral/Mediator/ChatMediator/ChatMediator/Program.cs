using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            // create users and add them to chat mediator's user list
            IUser alex = new BasicUser(chatMediator, "Alex");
            IUser vlad = new PremiumUser(chatMediator, "Vlad");
            IUser michael = new PremiumUser(chatMediator, "Michael");
            chatMediator.AddUser(alex);
            chatMediator.AddUser(vlad);
            chatMediator.AddUser(michael);
            // send message
            alex.SendMessage("Hi everybody!");
            michael.SendMessage("Hi, nice to hear you Alex");
            Console.ReadLine();
        }
    }
}
