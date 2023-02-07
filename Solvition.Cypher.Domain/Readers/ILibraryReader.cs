using Solvition.Cypher.Domain.Library;

namespace Solvition.Cypher.Domain.Readers
{
    public interface ILibraryReader
    {
        void LoadFile();
        IEnumerable<Point> ReadAllPoints();
    }
}
