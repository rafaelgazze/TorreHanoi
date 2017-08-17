using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorreHanoi.Domain;
using TorreHanoi.Domain.Interface;

namespace TorreHanoi.Services
{
    public class TorreHanoi
    {
        private readonly ILog _log;
        private readonly TorreHanoiDto _torreHanoiDto;
        private int _numeroMovimentos;
        private Guid _IdMonitorar;

        public TorreHanoi(ILog log, TorreHanoiDto torreHanoiDto)
        {
            _log = log;
            _torreHanoiDto = torreHanoiDto;
            _numeroMovimentos = 0;
            _IdMonitorar = Guid.NewGuid();
        }

        public async Task<Guid> Start()
        {
            MoveTorre(_torreHanoiDto.Discos,'A','B','C');

            return _IdMonitorar;
        }

        private void MoveUmDisco(char inicio, char fim)
        {
            _numeroMovimentos++;

            _log.Save(new MonitorarDto
            {
                Id = _IdMonitorar,
                Inicio = inicio,
                Fim = fim,
                NumeroMovimentos = _numeroMovimentos
            });
        }

        private void MoveTorre(int disco, char inicio, char fim, char temp)
        {
            if (disco == 1)
            {
                MoveUmDisco(inicio, fim);
            }
            else
            {
                MoveTorre(disco - 1, inicio, temp, fim);
                MoveUmDisco(inicio,fim);
                MoveTorre(disco -1, temp,fim,inicio);
            }
        }


    }
}
