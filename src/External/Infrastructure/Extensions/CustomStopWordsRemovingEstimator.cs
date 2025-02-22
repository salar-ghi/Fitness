using Microsoft.ML.Data;
using Microsoft.ML;

namespace Infrastructure.Extensions;

public class CustomStopWordsRemovingEstimator : IEstimator<ITransformer>
{
    private readonly MLContext _mlContext;
    private readonly string _inputColumn;
    private readonly string[] _stopWords;

    public CustomStopWordsRemovingEstimator(MLContext mlContext, string inputColumn, string[] stopWords)
    {
        _mlContext = mlContext;
        _inputColumn = inputColumn;
        _stopWords = stopWords;
    }

    public ITransformer Fit(IDataView input)
    {
        return new CustomStopWordsRemovingTransformer(_mlContext, _inputColumn, _stopWords);
    }

    public SchemaShape GetOutputSchema(SchemaShape inputSchema)
    {
        var outputColumns = new SchemaShape.Column[]
        {
            new SchemaShape.Column()
        };

        return new SchemaShape(outputColumns);
    }
}

public class CustomStopWordsRemovingTransformer : ITransformer
{
    private readonly MLContext _mlContext;
    private readonly string _inputColumn;
    private readonly string[] _stopWords;

    public CustomStopWordsRemovingTransformer(MLContext mlContext, string inputColumn, string[] stopWords)
    {
        _mlContext = mlContext;
        _inputColumn = inputColumn;
        _stopWords = stopWords;
    }

    public IDataView Transform(IDataView input)
    {
        return _mlContext.Transforms.CustomMapping<TextData, ProcessedTextData>(
            (inputRow, outputRow) =>
            {
                var tokens = inputRow.Text.Split(' ');
                outputRow.Tokens = tokens.Where(t => !_stopWords.Contains(t.ToLower())).ToArray();
            },
            contractName: null).Fit(input).Transform(input);
    }

    // Implement the Save method
    public void Save(ModelSaveContext ctx)
    {
        // If your transformer has no state to save, leave this method empty.
        // Otherwise, save the state (e.g., stop words) to the context.
        //ctx.CheckAtModel();
        //ctx.Writer.Write(_inputColumn);
        //ctx.Writer.Write(_stopWords.Length);
        //foreach (var word in _stopWords)
        //{
        //    ctx.Writer.Write(word);
        //}
        throw new NotSupportedException("Row-to-row mapping is not supported by this transformer.");
    }

    public DataViewSchema GetOutputSchema(DataViewSchema inputSchema)
    {
        // Create a schema builder
        var schemaBuilder = new DataViewSchema.Builder();

        // Add the output column to the schema
        schemaBuilder.AddColumn(_inputColumn, new VectorDataViewType(TextDataViewType.Instance));

        // Build and return the schema
        return schemaBuilder.ToSchema();
    }

    public IRowToRowMapper GetRowToRowMapper(DataViewSchema inputSchema)
    {
        throw new NotSupportedException("Row-to-row mapping is not supported by this transformer.");
    }

    // Implement the IsRowToRowMapper property
    public bool IsRowToRowMapper => false;

}

public class ProcessedTextData
{
    public string[] Tokens { get; set; }
}


