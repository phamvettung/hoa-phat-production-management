namespace DBRepositoriesExtension
{
    public class ModelData
    {
        public int Id { get; set; }

        public string ModelCode { get; set; } = null!;

        public DateTime Date { get; set; }

        public short ExpectedOutput { get; set; }

        public short ActualOutput { get; set; }
    }
}
