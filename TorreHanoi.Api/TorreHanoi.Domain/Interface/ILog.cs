using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreHanoi.Domain.Interface
{
    public interface ILog
    {
        void Save(object data);
        object Get(object id);
    }
}
