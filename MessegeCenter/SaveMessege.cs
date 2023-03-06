using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessegeCenter
{
    public class SaveMessege : ValueChangedMessage<string>
    {
        public SaveMessege(string input):base(input)
        {
            
        }
    }
}
