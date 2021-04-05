using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Model : Asset
    {
        public bool IsError { get; }

        public static Model Create(string name, Material material, Vertex[] vertices, int[] indices)
        {
            throw new NotImplementedException();
        }

        public static Model Load(string path)
        {
            throw new NotImplementedException();
        }

        public Transform GetAttachment(string id)
        {
            throw new NotImplementedException();
        }

        public T GetData<T>(string id)
        {
            throw new NotImplementedException();
        }
    }
}
