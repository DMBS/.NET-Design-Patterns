using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMediator
{
    /// <summary>
    /// Colleague interface
    /// </summary>
    public interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
    }
}
