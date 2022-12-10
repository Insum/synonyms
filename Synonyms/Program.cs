using GroupDocs.Search;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Type a word for which you want to find a synonym for:");
        string query = Console.ReadLine();

        string[] synonyms = new GroupDocs.Search.Index().Dictionaries.SynonymDictionary.GetSynonyms(query);


        if (synonyms.Length > 0)
        {
            Console.WriteLine("\"List of synonyms for '" + query + "':\"");
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < synonyms.Length; i++)
            {
                Console.WriteLine("- " + synonyms[i]);
            }
            Console.WriteLine("-----------------------------------------");
        }
        else
        {
            Console.WriteLine("Unfortunaly we can't find any synonymes for, " + query + ".");
        }
    }
}