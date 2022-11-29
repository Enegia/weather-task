namespace Weather.Model.Entities;

public class Station
{
    public long Id { get; set; }

    public string Name { get; set; }
        = null!;

    public string City { get; set; }
        = null!;

    public int ConstructionYear { get; set; }
}