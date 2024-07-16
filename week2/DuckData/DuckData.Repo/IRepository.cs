using DuckData.Models;

namespace DuckData.Repo
{
    // Agreement/contract
    // terms - the things that both parties agree to
    // like a template
    // "we" (the class that extends this interface) are agreeing to use all of the methods that are laid out in the interface
    public interface IRepository
    {
        // public void ReadAndWriteWithFile();
        // public void StreamReaderReadLine();
        // public void StreamReaderReadToEnd();
        // public List<Duck> ReadDucksFromFile();
        void SaveDuck(Duck myDuck);
        void SaveAllDucks(List<Duck> duckList);
        List<Duck> LoadAllDucks ();
        Duck GetDuckById ( int id );
        void DeleteDuckById ( int id );
    }
}