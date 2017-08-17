using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorreHanoi.Domain;
using TorreHanoi.Domain.Interface;

namespace TorreHanoi.Services
{
    public class MonitorarServices
    {
        private ILog _log;

        public MonitorarServices(ILog log)
        {
            _log = log;
        }
        public List<MonitorarDto> Movimentos(Guid id)
        {
            return (List<MonitorarDto>)_log.Get(id);
        }
    }
}
