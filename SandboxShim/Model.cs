using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Model
    {
        public virtual bool IsError { get; set; }

        public static Model Load(string path)
        {
            throw new NotImplementedException();
        }

        public Attachment GetAttachment(string attachment)
        {
            throw new NotImplementedException();
        }

        public T GetData<T>(string data)
        {
            throw new NotImplementedException();
        }
    }
}
