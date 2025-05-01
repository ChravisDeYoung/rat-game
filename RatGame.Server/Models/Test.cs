namespace RatGame.Server.Models;

public class Test
{
    public int Id { get; set; }

    public required string Hint1 { get; set; }

    public required string Hint2 { get; set; }

    public required string Hint3 { get; set; }

    public required string Answer { get; set; }

    public required TestDifficulty Difficulty { get; set; }
}