using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Solvition.Cypher.Domain.Contracts;
using Solvition.Cypher.Domain.Readers;

namespace Solvition.Cypher.Domain.Test.Readers
{
    [TestClass]
    public class FxlReaderTests
    {
        [TestMethod]
        [DeploymentItem(@"Fakes/FakeFxlVersion9.fxl")]
        public void ReadAllPoints_GetsPointsFromFile()
        {
            var expectedPointCount = 1;

            using (var fileReader = File.OpenRead("FakeFxlVersion9.fxl"))
            {
                var mockFileLoader = new Mock<IFileLoader>();
                mockFileLoader.Setup(m => m.LoadFileAsStream())
                              .Returns(fileReader);

                var fxlReader = new FxlReader(mockFileLoader.Object);
                fxlReader.LoadFile();

                var points = fxlReader.ReadAllPoints();

                Assert.AreEqual(expectedPointCount, points.ToList().Count());
            }
        }
    }
}
