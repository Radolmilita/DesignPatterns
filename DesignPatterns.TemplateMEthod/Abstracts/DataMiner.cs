namespace DesignPatterns.TemplateMEthod.Abstracts;

public abstract class DataMiner
{
    // Template method
    public void Mine(string data)
    {
        LoadData(data);
        AnalyzeData();
        PresentResults();
    }

    protected abstract void LoadData(string data);
    protected abstract void AnalyzeData();
    protected abstract void PresentResults();
}