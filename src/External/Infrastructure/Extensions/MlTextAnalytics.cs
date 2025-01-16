using Microsoft.ML;

namespace Infrastructure.Extensions;

public class MlTextAnalytics
{


}

public class TextData
{
    public string Text { get; set; }
}

public class TextPrediction
{
    public string[] Sentences { get; set; }
}

public class TextProcessor
{
    private readonly MLContext _mlContext;

    public TextProcessor()
    {
        _mlContext = new MLContext();
    }

    public string[] SplitTextIntoSentences(string text)
    {
        var data = _mlContext.Data.LoadFromEnumerable(new List<TextData> { new TextData { Text = text } });

        var pipeline = _mlContext.Transforms.Text.NormalizeText("Text")
            .Append(_mlContext.Transforms.Text.TokenizeIntoWords("Tokens", "Text"))
            .Append(_mlContext.Transforms.Text.ProduceNgrams("Ngrams", "Tokens"))
            .Append(_mlContext.Transforms.Text.LatentDirichletAllocation("Features", "Ngrams"));

        var model = pipeline.Fit(data);
        var predictionEngine = _mlContext.Model.CreatePredictionEngine<TextData, TextPrediction>(model);

        var prediction = predictionEngine.Predict(new TextData { Text = text });
        return prediction.Sentences;
    }
}