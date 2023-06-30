using System.Text.RegularExpressions;
using Newtonsoft.Json.Serialization;

public enum ContainerStatus
{
    Processing,
    MarkedForInspection,
    UnderReview,
    Approved = 9,
    ApprovedAfterInspection
}

public class Container
{
    public string Code { get; }
    public string Manifest { get; }
    public string[] Categories { get; }
    public string Origin { get; }
    public double Weight { get; }
    public double ActualWeight { get; }
    public ContainerStatus Status { get; set; }

    [Newtonsoft.Json.JsonConstructor]
    public Container(string code, string manifest, string[] categories, string origin, string weight, string actual_weight)
    {
        Code = code;
        Manifest = manifest;
        Categories = categories;
        Origin = origin;
        Weight = Math.Round(Double.Parse(Regex.Replace(weight, "[^0-9]", "")) * 0.45359237, 2);
        ActualWeight = Math.Round(Double.Parse(Regex.Replace(actual_weight, "[^0-9]", "")) * 0.45359237, 2);
        Status = ContainerStatus.Processing;
    }

    public override string ToString()
    {
        return $"Container(Code:'{Code}', Manifest:'{Manifest}', Categories:'{String.Join(',', Categories)}', Origin:'{Origin}', Status:'{Status}', Weight:'{Weight}', ActualWeight:'{ActualWeight}')";
    }
}