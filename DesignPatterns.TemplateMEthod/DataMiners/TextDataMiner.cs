using DesignPatterns.TemplateMEthod.Abstracts;

namespace DesignPatterns.TemplateMEthod.DataMiners;

public class TextDataMiner : DataMiner
{
    protected override void LoadData(string data)
    {
        Console.WriteLine($"Loading text data: {data}");
    }

    protected override void AnalyzeData()
    {
        Console.WriteLine("Analyzing text data...");
    }

    protected override void PresentResults()
    {
        Console.WriteLine("Presenting text data mining results...");
    }
}