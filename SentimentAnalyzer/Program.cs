namespace SentimentAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence to evaluate: ");
            //Load sample data
            var sampleData = new SentimentAnalysisModel.ModelInput();
            sampleData.Review = Console.ReadLine();

            //Load model and predict output
            var result = SentimentAnalysisModel.Predict(sampleData);

            Console.WriteLine($"The sentiment of your sentence is: {result.PredictedLabel}");

        }
    }
}