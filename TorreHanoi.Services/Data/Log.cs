using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorreHanoi.Domain;
using TorreHanoi.Domain.Interface;

namespace TorreHanoi.Services
{
    public class Log : ILog
    {
        //mockado list static, pode ser um sql, texto
        private static List<MonitorarDto> ListMonitorarDto;
        public Log()
        {
            if (ListMonitorarDto == null)
                ListMonitorarDto = new List<MonitorarDto>();
        }

        public void Save(object data)
        {
            var monitorarDto = data as MonitorarDto;
            if (monitorarDto != null)
                ListMonitorarDto.Add(monitorarDto);
        }

        public object Get(object id)
        {
            return ListMonitorarDto.Where(t => t.Id == (Guid)id).ToList();
        }
    }
}
