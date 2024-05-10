using DesignPatterns.TemplateMEthod.Abstracts;
using DesignPatterns.TemplateMEthod.DataMiners;

class Program
{
    static void Main(string[] args)
    {
        // Setting up the data miner
        DataMiner dataMiner = new TextDataMiner();

        // Mining data
        dataMiner.Mine("Some text data");

        // Changing the data miner
        dataMiner = new ImageDataMiner();

        // Mining data
        dataMiner.Mine("Some image data");

        Console.ReadKey();
    }
}