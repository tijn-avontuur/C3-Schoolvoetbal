using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace C3_Schoolvoetbal_Backend.Data;

public class Bet {
    public int Id { get; set; }

    public IdentityUser User { get; set; }

    public Match Match { get; set; }

    [Precision(8, 2)]
    public decimal Amount { get; set; }

    [MaxLength(255)]
    public string Status { get; set; } = "pending";

    public Bet(IdentityUser user, Match match, decimal amount) {
        User = user;
        Match = match;
        Amount = amount;
    }

    public Bet() {}
}
