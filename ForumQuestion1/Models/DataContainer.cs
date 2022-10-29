namespace ForumQuestion1.Models;

internal class DataContainer
{
    public string TrackingCode { get; set; }
    public string CompanyName { get; set; }
    public override string ToString() => $"{TrackingCode} - {CompanyName}";
}