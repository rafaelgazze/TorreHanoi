using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorreHanoi.Domain;
using TorreHanoi.Services;

namespace TorreHanoiTest
{
    [TestClass]
    public class TorreHanoiServiceTest
    {

        private TorreHanoiService _torreHanoiService;
        [TestInitialize]
        public void Initialize()
        {
            _torreHanoiService = new TorreHanoiService(new Log());
        }

        [TestMethod]
        public void MoverUmDisco()
        {
            var dto = new TorreHanoiDto();
            dto.Discos = 1;
            _torreHanoiService.Start(dto);

            Assert.AreEqual(_torreHanoiService._numeroMovimentos,1);
        }
        [TestMethod]
        public void MoverDoisDiscos()
        {
            var dto = new TorreHanoiDto();
            dto.Discos = 2;
            _torreHanoiService.Start(dto);

            Assert.AreEqual(_torreHanoiService._numeroMovimentos, 3);
        }

        [TestMethod]
        public void MoverTresDiscos()
        {
            var dto = new TorreHanoiDto();
            dto.Discos = 3;
            _torreHanoiService.Start(dto);

            Assert.AreEqual(_torreHanoiService._numeroMovimentos, 7);
        }
    }
}
