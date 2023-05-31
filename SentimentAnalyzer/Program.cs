namespace SentimentAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence to evaluate: ");
            // Get sentence from user
            var sampleData = new SentimentAnalysisModel.ModelInput();
            sampleData.Review = Console.ReadLine();

            // Load model and analyze sentiment
            var result = SentimentAnalysisModel.Predict(sampleData);

            // Display results to user           
            Console.WriteLine($"The sentiment of your sentence is: {result.PredictedLabel}");

            Console.Write("Positive: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(result.Score[0].ToString("p"));
            Console.ResetColor();
            
            Console.WriteLine();

            Console.Write("Negative: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(result.Score[1].ToString("p"));
            Console.ResetColor();

        }
    }
}