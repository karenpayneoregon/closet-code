using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace LoginConsoleApp.Models
{
    //[Serializable]
    [ProtoContract]
    public class User
    {
        [ProtoMember(1)]
        public string Name { get; set; }
        [ProtoMember(2)]
        public string Password { get; set; }
        public override string ToString() => Name;
    }
}
