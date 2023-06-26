using System.Text.RegularExpressions;

public class Container
{
    public string Code { get; }
    public string Manifest { get; }
    public string[] Categories { get; }
    public string Origin { get; }
    public double Weight { get; }
    // {
    //     get
    //     {
    //         return Math.Round(Weight * 0.45359237, 2);
    //     }
    // }
    public int Status { get; set; }

    public Container(string code, string manifest, string[] categories, string origin, string weight, int status)
    {
        Code = code;
        Manifest = manifest;
        Categories = categories;
        Origin = origin;
        Weight = Math.Round(Double.Parse(Regex.Replace(weight, "[^0-9.]", "")) * 0.45359237, 2);
        Status = status;
    }

    public override string ToString()
    {
        return $"Container(Code:'{Code}', Manifest:'{Manifest}', Categories:'{String.Join(',', Categories)}', Origin:'{Origin}', Status:'{Status}', Weight:'{Weight}')";
    }
}