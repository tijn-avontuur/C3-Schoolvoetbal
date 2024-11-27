using System.ComponentModel.DataAnnotations;

namespace C3_Schoolvoetbal_Backend.Data;

public class Team(string name) {
    public int Id { get; set; }

    [MaxLength(255)]
    public string Name { get; set; } = name;
}
