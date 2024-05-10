using DesignPatterns.TemplateMEthod.Abstracts;

namespace DesignPatterns.TemplateMEthod.DataMiners;

public class ImageDataMiner : DataMiner
{
    protected override void LoadData(string data)
    {
        Console.WriteLine($"Loading image data: {data}");
    }

    protected override void AnalyzeData()
    {
        Console.WriteLine("Analyzing image data...");
    }

    protected override void PresentResults()
    {
        Console.WriteLine("Presenting image data mining results...");
    }
}
