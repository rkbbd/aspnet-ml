// See https://aka.ms/new-console-template for more information
using MyMLApp;
// Add input data
bool continueCheck = true;
while (continueCheck)
{
    Console.WriteLine("Write review :");
    string myReview = Console.ReadLine();
    var sampleData = new SentimentModel.ModelInput()
    {
        Col0 = myReview
    };

    // Load model and predict output of sample data
    var result = SentimentModel.Predict(sampleData);

    // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
    string sentiment = result.Prediction == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Sentiment: {sentiment}\n");
    Console.WriteLine("Type c for exists....");
    continueCheck = Console.ReadLine() == "c"? false: true;
}

