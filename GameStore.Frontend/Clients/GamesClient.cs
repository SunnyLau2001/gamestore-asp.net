using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games =
    [
        new() {
            Id = 1,
            Name = "Street Fighter VI",
            Genre = "Fighting",
            Price = 39.59M,
            ReleaseDate = new DateOnly(2023, 6, 2)
        },
        new() {
            Id = 2,
            Name = "Final Fantasy 14",
            Genre = "Roleplaying",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2010, 9, 30)
        },
                new() {
            Id = 3,
            Name = "FIFA 23",
            Genre = "sport",
            Price = 69.99M,
            ReleaseDate = new DateOnly(2023, 6, 2)
        }
    ];

    public GameSummary[] GetGames() => [.. games];

}
