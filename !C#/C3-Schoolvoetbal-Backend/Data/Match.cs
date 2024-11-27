using System.ComponentModel.DataAnnotations;

namespace C3_Schoolvoetbal_Backend.Data;

public class Match {
    public int Id { get; set; }

    public Team Team1 { get; set; }

    public Team Team2 { get; set; }

    [MaxLength(255)]
    public string? Result { get; set; }

    public Match(Team team1, Team team2) {
        Team1 = team1;
        Team2 = team2;
    }

    public Match() {}
}
