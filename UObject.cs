using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public interface UObject
    {
        public object GetProperty(string key);
        public void SetProperty(string key, object value);
    }
}
