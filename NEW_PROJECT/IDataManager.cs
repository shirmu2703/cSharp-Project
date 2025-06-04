namespace NEW_PROJECT
{
    public interface IDataManager
    {
        // Saves data to a file
        void SaveToFile(string filePath);

        // Loads data from a file
        void LoadFromFile(string filePath);
    }
}
