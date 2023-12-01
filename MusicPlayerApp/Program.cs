namespace MusicPlayerApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Creating and populating a dictionary
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("One", 1);
            myDictionary.Add("Two", 2);
            myDictionary.Add("Three", 3);

            // Creating and populating a list
            List<string> myList = new List<string> { "Title", "Playlist", "Repository" };

            // Retrieving a value from the dictionary
            string keyToRetrieve = "Two";
            if (myDictionary.ContainsKey(keyToRetrieve))
            {
                int retrievedValue = myDictionary[keyToRetrieve];
                Console.WriteLine($"Value for key '{keyToRetrieve}': {retrievedValue}");
            }
            else
            {
                Console.WriteLine($"Key '{keyToRetrieve}' not found in the dictionary.");
            }

            // Retrieving a value from the list
            int indexToRetrieve = 1;
            if (indexToRetrieve >= 0 && indexToRetrieve < myList.Count)
            {
                string retrievedValue = myList[indexToRetrieve];
                Console.WriteLine($"Value at index {indexToRetrieve}: {retrievedValue}");
            }
            else
            {
                Console.WriteLine($"Index {indexToRetrieve} is out of bounds for the list.");
            }
        
    

    // To customize application configuration such as set high DPI settings or default font,
    // see https://aka.ms/applicationconfiguration.
    ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
