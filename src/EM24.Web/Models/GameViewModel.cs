using EM24.Core.Models;

namespace EM24.Web.Models;

public class GameViewModel
{
    public int Id { get; set; }
    public string RightTeam { get; set; }
    public string LeftTeam { get; set; }
    public Result? Result { get; set; }
}