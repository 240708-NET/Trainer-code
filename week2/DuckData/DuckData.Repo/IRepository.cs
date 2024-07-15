using DuckData.Models;

namespace DuckData.Repo
{
    // Agreement/contract
    // terms - the things that both parties agree to
    // like a template
    // "we" (the class that extends this interface) are agreeing to use all of the methods that are laid out in the interface
    public interface IRepository
    {
        public void ReadAndWriteWithFile(string path);
        public void StreamReaderReadLine(string path);
        public void StreamReaderReadToEnd(string path);
        public List<Duck> ReadDucksFromFile(string path);
        void SaveDuck(Duck myDuck, string path);
        void SaveAllDucks(List<Duck> duckList, string path);
        List<Duck> LoadAllDucks (string path);
    }
}