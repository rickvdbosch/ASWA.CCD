namespace ASWA.CCD.Common.Models;

public class SessionModel
{
    public string Id { get; set; }
    public string Start { get; set; }
    public string End { get; set; }
    public int Duration { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Speaker { get; set; }
    public string Room { get; set; }
    public bool IsPast { get; set; }
    public bool IsActive { get; set; }
}
