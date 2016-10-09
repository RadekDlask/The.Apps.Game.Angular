namespace The.Apps.Game.Core.Services.Results
{
    public class OperationResult<T>
    {
        public OperationResult(OperationResultType type, T model, string reason = null)
        {
            Result = type;
            Reason = reason;
            Model = model;
        }
        public OperationResultType Result { get; set; }
        public string Reason { get; set; }
        public T Model { get; set; }
    }
}
