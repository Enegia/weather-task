namespace Weather.Data;

public class StationData
{
    public long Id { get; set; }
    public string Name { get; set; }
        = null!;
    public string City { get; set; }
        = null!;
    public int ConstructionYear { get; set; }
}