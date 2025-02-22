using Microsoft.ML;
using Microsoft.ML.Data;

namespace Infrastructure.Extensions;

public class TextTokenizer
{
    private readonly MLContext mLContext;

    public TextTokenizer()
    {
        mLContext = new MLContext();
    }


    public List<string> TokenizeText(string text, string[] customStopWords)
    {
        // Step 1: Load the text data into an IDataView
        var data = mLContext.Data.LoadFromEnumerable(new List<TextData> { new TextData { Text = text} });

        // Step 2: Define the text processing pipeline
        var pipeline = mLContext.Transforms.Text.TokenizeIntoWords("Tokens", "Text")
            .Append(mLContext.Transforms.Text.RemoveDefaultStopWords("Tokens", "Tokens"))
            .Append(new CustomStopWordsRemovingEstimator(mLContext, "Tokens", customStopWords));

        // Step 3: Fit the pipeline to the data
        var model = pipeline.Fit(data);

        // Step 4: Transform the data and extract tokens
        var transformedData = model.Transform(data);
        var tokens = transformedData.GetColumn<string[]>("Tokens").FirstOrDefault();

        return tokens?.ToList();
    }
}