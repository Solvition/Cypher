using Solvition.Cypher.Domain.Contracts;
using Solvition.Cypher.Domain.Library;
using System.Xml.Linq;

namespace Solvition.Cypher.Domain.Readers
{
    public class FxlReader : ILibraryReader
    {
        private readonly IFileLoader _fileLoader;
        private XElement? _root;
        private XNamespace _namespace;

        public FxlReader(IFileLoader fileLoader)
        {
            _fileLoader = fileLoader;
            _namespace = "";
        }

        public void LoadFile()
        {
            var fxlStream = _fileLoader.LoadFileAsStream();

            _root = XElement.Load(fxlStream);
            _namespace = _root.GetDefaultNamespace();
        }

        public IEnumerable<Point> ReadAllPoints()
        {
            var pointFeatures = _root?.Element(_namespace + "FeatureDefinitions")
                                     ?.Elements(_namespace + "PointFeatureDefinition");

            if (pointFeatures is null)
            {
                throw new NotImplementedException();
            }

            foreach ( var pointFeature in pointFeatures)
            {
                yield return new Point();
            }
        }
    }
}
