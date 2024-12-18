using Microsoft.EntityFrameworkCore;
using RatGameApi.Domain;

public class RatGameContext(DbContextOptions<RatGameContext> options) : DbContext(options)
{
    public DbSet<HighScore> HighScores { get; set; }

    public DbSet<Test> Tests { get; set; }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "travis" }
        );

        modelBuilder.Entity<HighScore>().HasData(
            new HighScore { Id = 1, Score = 52, Difficulty = GameDifficulty.Easy, UserId = 1 },
            new HighScore { Id = 2, Score = 29, Difficulty = GameDifficulty.Medium, UserId = 1 }
        );

        modelBuilder.Entity<Test>().HasData(
            new Test { Id = 1, Item1 = "cottage", Item2 = "swiss", Item3 = "cake", Solution = "cheese", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 2, Item1 = "cream", Item2 = "skate", Item3 = "water", Solution = "ice", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 3, Item1 = "loser", Item2 = "throat", Item3 = "spot", Solution = "sore", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 4, Item1 = "show", Item2 = "life", Item3 = "row", Solution = "boat", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 5, Item1 = "night", Item2 = "wrist", Item3 = "stop", Solution = "watch", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 6, Item1 = "duck", Item2 = "fold", Item3 = "dollar", Solution = "bill", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 7, Item1 = "rocking", Item2 = "wheel", Item3 = "high", Solution = "chair", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 8, Item1 = "dew", Item2 = "comb", Item3 = "bee", Solution = "honey", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 9, Item1 = "fountain", Item2 = "baking", Item3 = "pop", Solution = "soda", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 10, Item1 = "preserve", Item2 = "ranger", Item3 = "tropical", Solution = "forest", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 11, Item1 = "aid", Item2 = "rubber", Item3 = "wagon", Solution = "band", Difficulty = TestDifficulty.Easy },
            new Test { Id = 12, Item1 = "flake", Item2 = "mobile", Item3 = "cone", Solution = "snow", Difficulty = TestDifficulty.Easy },
            new Test { Id = 13, Item1 = "cracker", Item2 = "fly", Item3 = "fighter", Solution = "fire", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 14, Item1 = "safety", Item2 = "cushion", Item3 = "point", Solution = "pin", Difficulty = TestDifficulty.Easy },
            new Test { Id = 15, Item1 = "cane", Item2 = "daddy", Item3 = "plum", Solution = "sugar", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 16, Item1 = "dream", Item2 = "break", Item3 = "light", Solution = "day", Difficulty = TestDifficulty.Easy },
            new Test { Id = 17, Item1 = "fish", Item2 = "mine", Item3 = "rush", Solution = "gold", Difficulty = TestDifficulty.Easy },
            new Test { Id = 18, Item1 = "political", Item2 = "surprise", Item3 = "line", Solution = "party", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 19, Item1 = "measure", Item2 = "worm", Item3 = "video", Solution = "tape", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 20, Item1 = "high", Item2 = "district", Item3 = "house", Solution = "school/court", Difficulty = TestDifficulty.Easy },
            new Test { Id = 21, Item1 = "sense", Item2 = "courtesy", Item3 = "place", Solution = "common", Difficulty = TestDifficulty.Medium },
            new Test { Id = 22, Item1 = "worm", Item2 = "shelf", Item3 = "end", Solution = "book", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 23, Item1 = "piece", Item2 = "mind", Item3 = "dating", Solution = "game", Difficulty = TestDifficulty.Hard },
            new Test { Id = 24, Item1 = "flower", Item2 = "friend", Item3 = "scout", Solution = "girl", Difficulty = TestDifficulty.Medium },
            new Test { Id = 25, Item1 = "river", Item2 = "note", Item3 = "account", Solution = "bank", Difficulty = TestDifficulty.Easy },
            new Test { Id = 26, Item1 = "print", Item2 = "berry", Item3 = "bird", Solution = "blue", Difficulty = TestDifficulty.Easy },
            new Test { Id = 27, Item1 = "pie", Item2 = "luck", Item3 = "belly", Solution = "pot", Difficulty = TestDifficulty.Medium },
            new Test { Id = 28, Item1 = "date", Item2 = "alley", Item3 = "fold", Solution = "blind", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 29, Item1 = "opera", Item2 = "hand", Item3 = "dish", Solution = "soap", Difficulty = TestDifficulty.Medium },
            new Test { Id = 30, Item1 = "cadet", Item2 = "capsule", Item3 = "ship", Solution = "space", Difficulty = TestDifficulty.Easy },
            new Test { Id = 31, Item1 = "fur", Item2 = "rack", Item3 = "tail", Solution = "coat", Difficulty = TestDifficulty.Easy },
            new Test { Id = 32, Item1 = "stick", Item2 = "maker", Item3 = "point", Solution = "match", Difficulty = TestDifficulty.Hard },
            new Test { Id = 33, Item1 = "hound", Item2 = "pressure", Item3 = "shot", Solution = "blood", Difficulty = TestDifficulty.Easy },
            new Test { Id = 34, Item1 = "fox", Item2 = "man", Item3 = "peep", Solution = "hole", Difficulty = TestDifficulty.Medium },
            new Test { Id = 35, Item1 = "sleeping", Item2 = "bean", Item3 = "trash", Solution = "bag", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 36, Item1 = "dust", Item2 = "cereal", Item3 = "fish", Solution = "bowl", Difficulty = TestDifficulty.Hard },
            new Test { Id = 37, Item1 = "light", Item2 = "birthday", Item3 = "stick", Solution = "candle", Difficulty = TestDifficulty.Medium },
            new Test { Id = 38, Item1 = "food", Item2 = "forward", Item3 = "break", Solution = "fast", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 39, Item1 = "shine", Item2 = "beam", Item3 = "struck", Solution = "moon", Difficulty = TestDifficulty.Medium },
            new Test { Id = 40, Item1 = "peach", Item2 = "arm", Item3 = "tar", Solution = "pit", Difficulty = TestDifficulty.Medium },
            new Test { Id = 41, Item1 = "water", Item2 = "mine", Item3 = "shaker", Solution = "salt", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 42, Item1 = "palm", Item2 = "shoe", Item3 = "house", Solution = "tree", Difficulty = TestDifficulty.Medium },
            new Test { Id = 43, Item1 = "basket", Item2 = "eight", Item3 = "snow", Solution = "ball", Difficulty = TestDifficulty.Easy },
            new Test { Id = 44, Item1 = "wheel", Item2 = "hand", Item3 = "shopping", Solution = "cart", Difficulty = TestDifficulty.Medium },
            new Test { Id = 45, Item1 = "right", Item2 = "cat", Item3 = "carbon", Solution = "copy", Difficulty = TestDifficulty.Hard },
            new Test { Id = 46, Item1 = "home", Item2 = "sea", Item3 = "bed", Solution = "sick", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 47, Item1 = "nuclear", Item2 = "feud", Item3 = "album", Solution = "family", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 48, Item1 = "sandwich", Item2 = "house", Item3 = "golf", Solution = "club", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 49, Item1 = "cross", Item2 = "rain", Item3 = "tie", Solution = "bow", Difficulty = TestDifficulty.Hard },
            new Test { Id = 50, Item1 = "sage", Item2 = "paint", Item3 = "hair", Solution = "brush", Difficulty = TestDifficulty.Medium },
            new Test { Id = 51, Item1 = "french", Item2 = "car", Item3 = "shoe", Solution = "horn", Difficulty = TestDifficulty.Medium },
            new Test { Id = 52, Item1 = "boot", Item2 = "summer", Item3 = "ground", Solution = "camp", Difficulty = TestDifficulty.Medium },
            new Test { Id = 53, Item1 = "chamber", Item2 = "mask", Item3 = "natural", Solution = "gas", Difficulty = TestDifficulty.Hard },
            new Test { Id = 54, Item1 = "mill", Item2 = "tooth", Item3 = "dust", Solution = "saw", Difficulty = TestDifficulty.Medium },
            new Test { Id = 55, Item1 = "main", Item2 = "sweeper", Item3 = "light", Solution = "street", Difficulty = TestDifficulty.Medium },
            new Test { Id = 56, Item1 = "pike", Item2 = "coat", Item3 = "signal", Solution = "turn", Difficulty = TestDifficulty.Medium },
            new Test { Id = 57, Item1 = "office", Item2 = "mail", Item3 = "hat", Solution = "box", Difficulty = TestDifficulty.Hard },
            new Test { Id = 58, Item1 = "fly", Item2 = "clip", Item3 = "wall", Solution = "paper", Difficulty = TestDifficulty.Medium },
            new Test { Id = 59, Item1 = "age", Item2 = "mile", Item3 = "sand", Solution = "stone", Difficulty = TestDifficulty.Hard },
            new Test { Id = 60, Item1 = "catcher", Item2 = "food", Item3 = "hot", Solution = "dog", Difficulty = TestDifficulty.Hard },
            new Test { Id = 61, Item1 = "wagon", Item2 = "break", Item3 = "radio", Solution = "station", Difficulty = TestDifficulty.Medium },
            new Test { Id = 62, Item1 = "tank", Item2 = "hill", Item3 = "secret", Solution = "top", Difficulty = TestDifficulty.Hard },
            new Test { Id = 63, Item1 = "health", Item2 = "taker", Item3 = "less", Solution = "care", Difficulty = TestDifficulty.Hard },
            new Test { Id = 64, Item1 = "lift", Item2 = "card", Item3 = "mask", Solution = "face", Difficulty = TestDifficulty.Hard },
            new Test { Id = 65, Item1 = "dress", Item2 = "dial", Item3 = "flower", Solution = "sun", Difficulty = TestDifficulty.Medium },
            new Test { Id = 66, Item1 = "force", Item2 = "line", Item3 = "mail", Solution = "air", Difficulty = TestDifficulty.Hard },
            new Test { Id = 67, Item1 = "guy", Item2 = "rain", Item3 = "down", Solution = "fall", Difficulty = TestDifficulty.Hard },
            new Test { Id = 68, Item1 = "eight", Item2 = "skate", Item3 = "stick", Solution = "figure", Difficulty = TestDifficulty.Medium },
            new Test { Id = 69, Item1 = "down", Item2 = "question", Item3 = "check", Solution = "mark", Difficulty = TestDifficulty.Medium },
            new Test { Id = 70, Item1 = "animal", Item2 = "back", Item3 = "rat", Solution = "pack", Difficulty = TestDifficulty.Hard },
            new Test { Id = 71, Item1 = "officer", Item2 = "cash", Item3 = "larceny", Solution = "petty", Difficulty = TestDifficulty.Hard },
            new Test { Id = 72, Item1 = "pine", Item2 = "crab", Item3 = "sauce", Solution = "apple", Difficulty = TestDifficulty.Hard },
            new Test { Id = 73, Item1 = "house", Item2 = "thumb", Item3 = "pepper", Solution = "green", Difficulty = TestDifficulty.Hard },
            new Test { Id = 74, Item1 = "carpet", Item2 = "alert", Item3 = "ink", Solution = "red", Difficulty = TestDifficulty.Medium },
            new Test { Id = 75, Item1 = "master", Item2 = "toss", Item3 = "finger", Solution = "ring", Difficulty = TestDifficulty.Medium },
            new Test { Id = 76, Item1 = "hammer", Item2 = "gear", Item3 = "hunter", Solution = "head", Difficulty = TestDifficulty.Medium },
            new Test { Id = 77, Item1 = "knife", Item2 = "light", Item3 = "pal", Solution = "pen", Difficulty = TestDifficulty.Medium },
            new Test { Id = 78, Item1 = "foul", Item2 = "ground", Item3 = "mate", Solution = "play", Difficulty = TestDifficulty.Hard },
            new Test { Id = 79, Item1 = "change", Item2 = "circuit", Item3 = "cake", Solution = "short", Difficulty = TestDifficulty.Hard },
            new Test { Id = 80, Item1 = "way", Item2 = "board", Item3 = "sleep", Solution = "walk", Difficulty = TestDifficulty.Medium },
            new Test { Id = 81, Item1 = "blank", Item2 = "list", Item3 = "mate", Solution = "check", Difficulty = TestDifficulty.Medium },
            new Test { Id = 82, Item1 = "tail", Item2 = "water", Item3 = "flood", Solution = "gate", Difficulty = TestDifficulty.Hard },
            new Test { Id = 83, Item1 = "marshal", Item2 = "child", Item3 = "piano", Solution = "grand", Difficulty = TestDifficulty.Hard },
            new Test { Id = 84, Item1 = "cover", Item2 = "arm", Item3 = "wear", Solution = "under", Difficulty = TestDifficulty.Hard },
            new Test { Id = 85, Item1 = "rain", Item2 = "test", Item3 = "stomach", Solution = "acid", Difficulty = TestDifficulty.Hard },
            new Test { Id = 86, Item1 = "time", Item2 = "blown", Item3 = "nelson", Solution = "full", Difficulty = TestDifficulty.Hard },
            new Test { Id = 87, Item1 = "pile", Item2 = "market", Item3 = "room", Solution = "stock", Difficulty = TestDifficulty.Hard },
            new Test { Id = 88, Item1 = "mouse", Item2 = "bear", Item3 = "sand", Solution = "trap", Difficulty = TestDifficulty.Easy },
            new Test { Id = 89, Item1 = "cat", Item2 = "number", Item3 = "phone", Solution = "call", Difficulty = TestDifficulty.Medium },
            new Test { Id = 90, Item1 = "keg", Item2 = "puff", Item3 = "room", Solution = "powder", Difficulty = TestDifficulty.Medium },
            new Test { Id = 91, Item1 = "trip", Item2 = "house", Item3 = "goal", Solution = "field", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 92, Item1 = "fork", Item2 = "dark", Item3 = "man", Solution = "pitch", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 93, Item1 = "fence", Item2 = "card", Item3 = "master", Solution = "post", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 94, Item1 = "test", Item2 = "runner", Item3 = "map", Solution = "road", Difficulty = TestDifficulty.Hard },
            new Test { Id = 95, Item1 = "dive", Item2 = "light", Item3 = "rocket", Solution = "sky", Difficulty = TestDifficulty.Hard },
            new Test { Id = 96, Item1 = "man", Item2 = "glue", Item3 = "star", Solution = "super", Difficulty = TestDifficulty.Hard },
            new Test { Id = 97, Item1 = "tooth", Item2 = "potato", Item3 = "heart", Solution = "sweet", Difficulty = TestDifficulty.Hard },
            new Test { Id = 98, Item1 = "illness", Item2 = "bus", Item3 = "computer", Solution = "terminal", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 99, Item1 = "type", Item2 = "ghost", Item3 = "screen", Solution = "writer", Difficulty = TestDifficulty.Medium },
            new Test { Id = 100, Item1 = "mail", Item2 = "board", Item3 = "lung", Solution = "black", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 101, Item1 = "teeth", Item2 = "arrest", Item3 = "start", Solution = "false", Difficulty = TestDifficulty.Hard },
            new Test { Id = 102, Item1 = "iron", Item2 = "shovel", Item3 = "engine", Solution = "steam", Difficulty = TestDifficulty.Hard },
            new Test { Id = 103, Item1 = "wet", Item2 = "law", Item3 = "business", Solution = "suit", Difficulty = TestDifficulty.Medium },
            new Test { Id = 104, Item1 = "rope", Item2 = "truck", Item3 = "line", Solution = "tow", Difficulty = TestDifficulty.Hard },
            new Test { Id = 105, Item1 = "off", Item2 = "military", Item3 = "first", Solution = "base", Difficulty = TestDifficulty.Hard },
            new Test { Id = 106, Item1 = "spoon", Item2 = "cloth", Item3 = "card", Solution = "table", Difficulty = TestDifficulty.Hard },
            new Test { Id = 107, Item1 = "cut", Item2 = "cream", Item3 = "war", Solution = "cold", Difficulty = TestDifficulty.Hard },
            new Test { Id = 108, Item1 = "note", Item2 = "chain", Item3 = "master", Solution = "key", Difficulty = TestDifficulty.Hard },
            new Test { Id = 109, Item1 = "shock", Item2 = "shave", Item3 = "taste", Solution = "after", Difficulty = TestDifficulty.Hard },
            new Test { Id = 110, Item1 = "wise", Item2 = "work", Item3 = "tower", Solution = "clock", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 111, Item1 = "grass", Item2 = "king", Item3 = "meat", Solution = "crab", Difficulty = TestDifficulty.Hard },
            new Test { Id = 112, Item1 = "baby", Item2 = "spring", Item3 = "cap", Solution = "shower", Difficulty = TestDifficulty.Hard },
            new Test { Id = 113, Item1 = "break", Item2 = "bean", Item3 = "cake", Solution = "coffee", Difficulty = TestDifficulty.Hard },
            new Test { Id = 114, Item1 = "cry", Item2 = "front", Item3 = "ship", Solution = "battle", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 115, Item1 = "hold", Item2 = "print", Item3 = "stool", Solution = "foot", Difficulty = TestDifficulty.Hard },
            new Test { Id = 116, Item1 = "roll", Item2 = "bean", Item3 = "fish", Solution = "jelly", Difficulty = TestDifficulty.Hard },
            new Test { Id = 117, Item1 = "horse", Item2 = "human", Item3 = "drag", Solution = "race", Difficulty = TestDifficulty.Medium },
            new Test { Id = 118, Item1 = "oil", Item2 = "bar", Item3 = "tuna", Solution = "salad", Difficulty = TestDifficulty.Hard },
            new Test { Id = 119, Item1 = "bottom", Item2 = "curve", Item3 = "hop", Solution = "bell", Difficulty = TestDifficulty.Hard },
            new Test { Id = 120, Item1 = "tomato", Item2 = "bomb", Item3 = "picker", Solution = "cherry", Difficulty = TestDifficulty.Hard },
            new Test { Id = 121, Item1 = "pea", Item2 = "shell", Item3 = "chest", Solution = "nut", Difficulty = TestDifficulty.Hard },
            new Test { Id = 122, Item1 = "line", Item2 = "fruit", Item3 = "drunk", Solution = "punch", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 123, Item1 = "bump", Item2 = "egg", Item3 = "step", Solution = "goose", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 124, Item1 = "fight", Item2 = "control", Item3 = "machine", Solution = "gun", Difficulty = TestDifficulty.Hard },
            new Test { Id = 125, Item1 = "home", Item2 = "arm", Item3 = "room", Solution = "rest", Difficulty = TestDifficulty.Hard },
            new Test { Id = 126, Item1 = "child", Item2 = "scan", Item3 = "wash", Solution = "brain", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 127, Item1 = "nose", Item2 = "stone", Item3 = "bear", Solution = "brown", Difficulty = TestDifficulty.Hard },
            new Test { Id = 128, Item1 = "end", Item2 = "line", Item3 = "lock", Solution = "dead", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 129, Item1 = "control", Item2 = "place", Item3 = "rate", Solution = "birth", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 130, Item1 = "lounge", Item2 = "hour", Item3 = "napkin", Solution = "cocktail", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 131, Item1 = "artist", Item2 = "hatch", Item3 = "route", Solution = "escape", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 132, Item1 = "pet", Item2 = "bottom", Item3 = "garden", Solution = "rock", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 133, Item1 = "mate", Item2 = "shoes", Item3 = "total", Solution = "running", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 134, Item1 = "self", Item2 = "attorney", Item3 = "spending", Solution = "defense", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 135, Item1 = "board", Item2 = "blade", Item3 = "back", Solution = "switch", Difficulty = TestDifficulty.Hard },
            new Test { Id = 136, Item1 = "land", Item2 = "hand", Item3 = "house", Solution = "farm", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 137, Item1 = "hungry", Item2 = "order", Item3 = "belt", Solution = "money", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 138, Item1 = "forward", Item2 = "flush", Item3 = "razor", Solution = "straight", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 139, Item1 = "shadow", Item2 = "chart", Item3 = "drop", Solution = "eye", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 140, Item1 = "way", Item2 = "ground", Item3 = "weather", Solution = "fair", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 141, Item1 = "cast", Item2 = "side", Item3 = "jump", Solution = "broad", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 142, Item1 = "back", Item2 = "step", Item3 = "screen", Solution = "door", Difficulty = TestDifficulty.Hard },
            new Test { Id = 143, Item1 = "reading", Item2 = "service", Item3 = "stick", Solution = "lip", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 144, Item1 = "over", Item2 = "plant", Item3 = "horse", Solution = "power", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 145, Item1 = "falling", Item2 = "actor", Item3 = "dust", Solution = "star", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 146, Item1 = "broken", Item2 = "clear", Item3 = "eye", Solution = "glass", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 147, Item1 = "skunk", Item2 = "kings", Item3 = "boiled", Solution = "cabbage", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 148, Item1 = "widow", Item2 = "bite", Item3 = "monkey", Solution = "spider", Difficulty = TestDifficulty.Easy },
            new Test { Id = 149, Item1 = "bass", Item2 = "complex", Item3 = "sleep", Solution = "deep", Difficulty = TestDifficulty.Easy },
            new Test { Id = 150, Item1 = "coin", Item2 = "quick", Item3 = "spoon", Solution = "silver", Difficulty = TestDifficulty.Easy },
            new Test { Id = 151, Item1 = "gold", Item2 = "stool", Item3 = "tender", Solution = "bar", Difficulty = TestDifficulty.Easy },
            new Test { Id = 152, Item1 = "time", Item2 = "hair", Item3 = "stretch", Solution = "long", Difficulty = TestDifficulty.Easy },
            new Test { Id = 153, Item1 = "cracker", Item2 = "union", Item3 = "rabbit", Solution = "jack", Difficulty = TestDifficulty.Medium },
            new Test { Id = 154, Item1 = "bald", Item2 = "screech", Item3 = "emblem", Solution = "eagle", Difficulty = TestDifficulty.Medium },
            new Test { Id = 155, Item1 = "blood", Item2 = "music", Item3 = "cheese", Solution = "blue", Difficulty = TestDifficulty.Medium },
            new Test { Id = 156, Item1 = "manners", Item2 = "round", Item3 = "tennis", Solution = "table", Difficulty = TestDifficulty.Medium },
            new Test { Id = 157, Item1 = "off", Item2 = "trumpet", Item3 = "atomic", Solution = "blast", Difficulty = TestDifficulty.Medium },
            new Test { Id = 158, Item1 = "playing", Item2 = "credit", Item3 = "report", Solution = "card", Difficulty = TestDifficulty.Medium },
            new Test { Id = 159, Item1 = "rabbit", Item2 = "cloud", Item3 = "house", Solution = "white", Difficulty = TestDifficulty.Medium },
            new Test { Id = 160, Item1 = "room", Item2 = "blood", Item3 = "salts", Solution = "bath", Difficulty = TestDifficulty.Medium },
            new Test { Id = 161, Item1 = "salt", Item2 = "deep", Item3 = "foam", Solution = "sea", Difficulty = TestDifficulty.Medium },
            new Test { Id = 162, Item1 = "square", Item2 = "cardboard", Item3 = "open", Solution = "box", Difficulty = TestDifficulty.Medium },
            new Test { Id = 163, Item1 = "water", Item2 = "tobacco", Item3 = "stove", Solution = "pipe", Difficulty = TestDifficulty.Medium },
            new Test { Id = 164, Item1 = "ache", Item2 = "hunter", Item3 = "cabbage", Solution = "head", Difficulty = TestDifficulty.Medium },
            new Test { Id = 165, Item1 = "chamber", Item2 = "staff", Item3 = "box", Solution = "music", Difficulty = TestDifficulty.Medium },
            new Test { Id = 166, Item1 = "high", Item2 = "book", Item3 = "sour", Solution = "note", Difficulty = TestDifficulty.Medium },
            new Test { Id = 167, Item1 = "lick", Item2 = "sprinkle", Item3 = "mines", Solution = "salt", Difficulty = TestDifficulty.Medium },
            new Test { Id = 168, Item1 = "pure", Item2 = "blue", Item3 = "fall", Solution = "water", Difficulty = TestDifficulty.Medium },
            new Test { Id = 169, Item1 = "snack", Item2 = "line", Item3 = "birthday", Solution = "party", Difficulty = TestDifficulty.Medium },
            new Test { Id = 170, Item1 = "square", Item2 = "telephone", Item3 = "club", Solution = "book", Difficulty = TestDifficulty.Medium },
            new Test { Id = 171, Item1 = "surprise", Item2 = "wrap", Item3 = "care", Solution = "gift", Difficulty = TestDifficulty.Medium },
            new Test { Id = 172, Item1 = "ticket", Item2 = "shop", Item3 = "broker", Solution = "pawn", Difficulty = TestDifficulty.Medium },
            new Test { Id = 173, Item1 = "barrel", Item2 = "root", Item3 = "belly", Solution = "beer", Difficulty = TestDifficulty.Medium },
            new Test { Id = 174, Item1 = "blade", Item2 = "witted", Item3 = "weary", Solution = "dull", Difficulty = TestDifficulty.Medium },
            new Test { Id = 175, Item1 = "cherry", Item2 = "time", Item3 = "smell", Solution = "blossom", Difficulty = TestDifficulty.Medium },
            new Test { Id = 176, Item1 = "notch", Item2 = "flight", Item3 = "spin", Solution = "top", Difficulty = TestDifficulty.Medium },
            new Test { Id = 177, Item1 = "strap", Item2 = "pocket", Item3 = "time", Solution = "watch", Difficulty = TestDifficulty.Medium },
            new Test { Id = 178, Item1 = "walker", Item2 = "main", Item3 = "sweeper", Solution = "street", Difficulty = TestDifficulty.Medium },
            new Test { Id = 179, Item1 = "wicked", Item2 = "bustle", Item3 = "slicker", Solution = "city", Difficulty = TestDifficulty.Medium },
            new Test { Id = 180, Item1 = "chocolate", Item2 = "fortune", Item3 = "tin", Solution = "cookie", Difficulty = TestDifficulty.Hard },
            new Test { Id = 181, Item1 = "color", Item2 = "numbers", Item3 = "oil", Solution = "paint", Difficulty = TestDifficulty.Hard },
            new Test { Id = 182, Item1 = "mouse", Item2 = "sharp", Item3 = "blue", Solution = "cheese", Difficulty = TestDifficulty.Hard },
            new Test { Id = 183, Item1 = "sandwich", Item2 = "golf", Item3 = "foot", Solution = "club", Difficulty = TestDifficulty.Hard },
            new Test { Id = 184, Item1 = "silk", Item2 = "cream", Item3 = "even", Solution = "smooth", Difficulty = TestDifficulty.Hard },
            new Test { Id = 185, Item1 = "speak", Item2 = "money", Item3 = "street", Solution = "easy", Difficulty = TestDifficulty.Hard },
            new Test { Id = 186, Item1 = "big", Item2 = "leaf", Item3 = "shade", Solution = "tree", Difficulty = TestDifficulty.Hard },
            new Test { Id = 187, Item1 = "envy", Item2 = "golf", Item3 = "beans", Solution = "green", Difficulty = TestDifficulty.Hard },
            new Test { Id = 188, Item1 = "hall", Item2 = "car", Item3 = "swimming", Solution = "pool", Difficulty = TestDifficulty.Hard },
            new Test { Id = 189, Item1 = "ink", Item2 = "herring", Item3 = "neck", Solution = "red", Difficulty = TestDifficulty.Hard },
            new Test { Id = 190, Item1 = "measure", Item2 = "desk", Item3 = "scotch", Solution = "tape", Difficulty = TestDifficulty.Hard },
            new Test { Id = 191, Item1 = "strike", Item2 = "same", Item3 = "tennis", Solution = "match", Difficulty = TestDifficulty.Hard },
            new Test { Id = 192, Item1 = "athletes", Item2 = "web", Item3 = "rabbit", Solution = "foot", Difficulty = TestDifficulty.Hard },
            new Test { Id = 193, Item1 = "board", Item2 = "magic", Item3 = "death", Solution = "black", Difficulty = TestDifficulty.Hard },
            new Test { Id = 194, Item1 = "lapse", Item2 = "vivid", Item3 = "elephant", Solution = "memory", Difficulty = TestDifficulty.Hard },
            new Test { Id = 195, Item1 = "puss", Item2 = "tart", Item3 = "spoiled", Solution = "sour", Difficulty = TestDifficulty.Hard },
            new Test { Id = 196, Item1 = "rock", Item2 = "times", Item3 = "steel", Solution = "hard", Difficulty = TestDifficulty.Hard },
            new Test { Id = 197, Item1 = "stop", Item2 = "petty", Item3 = "sneak", Solution = "thief", Difficulty = TestDifficulty.Hard },
            new Test { Id = 198, Item1 = "thread", Item2 = "pine", Item3 = "pain", Solution = "needle", Difficulty = TestDifficulty.Hard },
            new Test { Id = 199, Item1 = "zone", Item2 = "still", Item3 = "noise", Solution = "quiet", Difficulty = TestDifficulty.Hard },
            new Test { Id = 200, Item1 = "cloth", Item2 = "sad", Item3 = "out", Solution = "sack", Difficulty = TestDifficulty.Hard },
            new Test { Id = 201, Item1 = "cotton", Item2 = "bathtub", Item3 = "tonic", Solution = "gin", Difficulty = TestDifficulty.Hard },
            new Test { Id = 202, Item1 = "foot", Item2 = "collection", Item3 = "out", Solution = "stamp", Difficulty = TestDifficulty.Hard },
            new Test { Id = 203, Item1 = "inch", Item2 = "deal", Item3 = "peg", Solution = "square", Difficulty = TestDifficulty.Hard },
            new Test { Id = 204, Item1 = "jump", Item2 = "kill", Item3 = "bliss", Solution = "joy", Difficulty = TestDifficulty.Hard },
            new Test { Id = 205, Item1 = "magic", Item2 = "plush", Item3 = "floor", Solution = "carpet", Difficulty = TestDifficulty.Hard },
            new Test { Id = 206, Item1 = "note", Item2 = "dive", Item3 = "chair", Solution = "high", Difficulty = TestDifficulty.Hard },
            new Test { Id = 207, Item1 = "stalk", Item2 = "trainer", Item3 = "king", Solution = "lion", Difficulty = TestDifficulty.Hard },
            new Test { Id = 208, Item1 = "bump", Item2 = "throat", Item3 = "sum", Solution = "lump", Difficulty = TestDifficulty.Hard },
            new Test { Id = 209, Item1 = "shopping", Item2 = "washer", Item3 = "picture", Solution = "window", Difficulty = TestDifficulty.Hard },
            new Test { Id = 210, Item1 = "blank", Item2 = "white", Item3 = "lines", Solution = "paper", Difficulty = TestDifficulty.Hard },
            new Test { Id = 211, Item1 = "stick", Item2 = "light", Item3 = "birthday", Solution = "candle", Difficulty = TestDifficulty.Hard },
            new Test { Id = 212, Item1 = "sore", Item2 = "shoulder", Item3 = "sweat", Solution = "cold", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 213, Item1 = "house", Item2 = "blanket", Item3 = "ball", Solution = "beach", Difficulty = TestDifficulty.Hard },
            new Test { Id = 214, Item1 = "trap", Item2 = "polar", Item3 = "claw", Solution = "bear", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 215, Item1 = "cinder", Item2 = "building", Item3 = "buster", Solution = "block", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 216, Item1 = "line", Item2 = "patrol", Item3 = "town", Solution = "border", Difficulty = TestDifficulty.Hard },
            new Test { Id = 217, Item1 = "thorn", Item2 = "whack", Item3 = "rose", Solution = "bush", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 218, Item1 = "garbage", Item2 = "beer", Item3 = "paint", Solution = "can", Difficulty = TestDifficulty.Easy },
            new Test { Id = 219, Item1 = "scan", Item2 = "nap", Item3 = "burglar", Solution = "cat", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 220, Item1 = "trap", Item2 = "back", Item3 = "screen", Solution = "door", Difficulty = TestDifficulty.Easy },
            new Test { Id = 221, Item1 = "through", Item2 = "disk", Item3 = "way", Solution = "drive", Difficulty = TestDifficulty.Hard },
            new Test { Id = 222, Item1 = "tax", Item2 = "real", Item3 = "fourth", Solution = "estate", Difficulty = TestDifficulty.Hard },
            new Test { Id = 223, Item1 = "life", Item2 = "color", Item3 = "coast", Solution = "guard", Difficulty = TestDifficulty.Hard },
            new Test { Id = 224, Item1 = "wave", Item2 = "lamp", Item3 = "dry", Solution = "heat", Difficulty = TestDifficulty.Hard },
            new Test { Id = 225, Item1 = "glass", Item2 = "rush", Item3 = "happy", Solution = "hour", Difficulty = TestDifficulty.Easy },
            new Test { Id = 226, Item1 = "waffle", Item2 = "lung", Item3 = "tire", Solution = "iron", Difficulty = TestDifficulty.Medium },
            new Test { Id = 227, Item1 = "poison", Item2 = "league", Item3 = "creeping", Solution = "ivy", Difficulty = TestDifficulty.Medium },
            new Test { Id = 228, Item1 = "pain", Item2 = "serial", Item3 = "whale", Solution = "killer", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 229, Item1 = "floor", Item2 = "shade", Item3 = "heat", Solution = "lamp", Difficulty = TestDifficulty.Easy },
            new Test { Id = 230, Item1 = "puppy", Item2 = "TRUE", Item3 = "letter", Solution = "love", Difficulty = TestDifficulty.Easy },
            new Test { Id = 231, Item1 = "bedroom", Item2 = "plan", Item3 = "brew", Solution = "master", Difficulty = TestDifficulty.Hard },
            new Test { Id = 232, Item1 = "mouth", Item2 = "bike", Item3 = "oil", Solution = "motor", Difficulty = TestDifficulty.Hard },
            new Test { Id = 233, Item1 = "polish", Item2 = "finger", Item3 = "down", Solution = "nail", Difficulty = TestDifficulty.Easy },
            new Test { Id = 234, Item1 = "sake", Item2 = "pet", Item3 = "nick", Solution = "name", Difficulty = TestDifficulty.Hard },
            new Test { Id = 235, Item1 = "computer", Item2 = "cable", Item3 = "broadcast", Solution = "network", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 236, Item1 = "skirts", Item2 = "take", Item3 = "put", Solution = "out", Difficulty = TestDifficulty.Medium },
            new Test { Id = 237, Item1 = "jury", Item2 = "door", Item3 = "side", Solution = "panel", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 238, Item1 = "due", Item2 = "life", Item3 = "tense", Solution = "past", Difficulty = TestDifficulty.Hard },
            new Test { Id = 239, Item1 = "tomato", Item2 = "cement", Item3 = "tooth", Solution = "paste", Difficulty = TestDifficulty.Hard },
            new Test { Id = 240, Item1 = "flag", Item2 = "vault", Item3 = "fishing", Solution = "pole", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 241, Item1 = "release", Item2 = "french", Item3 = "secretary", Solution = "press", Difficulty = TestDifficulty.Hard },
            new Test { Id = 242, Item1 = "dollar", Item2 = "stop", Item3 = "language", Solution = "sign", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 243, Item1 = "quick", Item2 = "spoon", Item3 = "screen", Solution = "silver", Difficulty = TestDifficulty.Medium },
            new Test { Id = 244, Item1 = "grand", Item2 = "door", Item3 = "bang", Solution = "slam", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 245, Item1 = "dash", Item2 = "happy", Item3 = "stick", Solution = "slap", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 246, Item1 = "ruby", Item2 = "glass", Item3 = "bunny", Solution = "slipper", Difficulty = TestDifficulty.Medium },
            new Test { Id = 247, Item1 = "demon", Item2 = "limit", Item3 = "way", Solution = "speed", Difficulty = TestDifficulty.Medium },
            new Test { Id = 248, Item1 = "gap", Item2 = "door", Item3 = "sign", Solution = "stop", Difficulty = TestDifficulty.Hard },
            new Test { Id = 249, Item1 = "food", Item2 = "front", Item3 = "drug", Solution = "store", Difficulty = TestDifficulty.Medium },
            new Test { Id = 250, Item1 = "set", Item2 = "program", Item3 = "cable", Solution = "television", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 251, Item1 = "chest", Item2 = "car", Item3 = "store", Solution = "toy", Difficulty = TestDifficulty.VeryHard },
            new Test { Id = 252, Item1 = "property", Item2 = "moral", Item3 = "price", Solution = "value", Difficulty = TestDifficulty.Hard },
            new Test { Id = 253, Item1 = "rag", Item2 = "milk", Item3 = "out", Solution = "weed", Difficulty = TestDifficulty.Hard },
            new Test { Id = 254, Item1 = "noise", Item2 = "collar", Item3 = "wash", Solution = "white", Difficulty = TestDifficulty.Medium },
            new Test { Id = 255, Item1 = "bay", Item2 = "picture", Item3 = "washer", Solution = "window", Difficulty = TestDifficulty.Medium },
            new Test { Id = 256, Item1 = "hard", Item2 = "drift", Item3 = "cutter", Solution = "wood", Difficulty = TestDifficulty.Easy },
            new Test { Id = 257, Item1 = "cottage", Item2 = "brick", Item3 = "cake", Solution = "cheese", Difficulty = TestDifficulty.VeryEasy },
            new Test { Id = 258, Item1 = "shelf", Item2 = "read", Item3 = "end", Solution = "book", Difficulty = TestDifficulty.Easy },
            new Test { Id = 259, Item1 = "sea", Item2 = "home", Item3 = "stomach", Solution = "sick", Difficulty = TestDifficulty.Easy },
            new Test { Id = 260, Item1 = "car", Item2 = "swimming", Item3 = "cue", Solution = "pool", Difficulty = TestDifficulty.Easy },
            new Test { Id = 261, Item1 = "cookies", Item2 = "sixteen", Item3 = "heart", Solution = "sweet", Difficulty = TestDifficulty.Easy },
            new Test { Id = 262, Item1 = "lounge", Item2 = "hour", Item3 = "drink", Solution = "cocktail", Difficulty = TestDifficulty.Easy },
            new Test { Id = 263, Item1 = "keel", Item2 = "show", Item3 = "row", Solution = "boat", Difficulty = TestDifficulty.Easy },
            new Test { Id = 264, Item1 = "desert", Item2 = "ice", Item3 = "spell", Solution = "dry", Difficulty = TestDifficulty.Hard },
            new Test { Id = 265, Item1 = "base", Item2 = "show", Item3 = "dance", Solution = "ball", Difficulty = TestDifficulty.Hard },
            new Test { Id = 266, Item1 = "soap", Item2 = "shoe", Item3 = "tissue", Solution = "box", Difficulty = TestDifficulty.Hard },
            new Test { Id = 267, Item1 = "hot", Item2 = "butterflies", Item3 = "pump", Solution = "stomach", Difficulty = TestDifficulty.Hard },
            new Test { Id = 268, Item1 = "head", Item2 = "street", Item3 = "dark", Solution = "light", Difficulty = TestDifficulty.Easy },
            new Test { Id = 269, Item1 = "room", Item2 = "saturday", Item3 = "salts", Solution = "bath", Difficulty = TestDifficulty.Hard },
            new Test { Id = 270, Item1 = "surprise", Item2 = "line", Item3 = "birthday", Solution = "party", Difficulty = TestDifficulty.Easy },
            new Test { Id = 271, Item1 = "red", Item2 = "go", Item3 = "car", Solution = "stop", Difficulty = TestDifficulty.Easy }
        );
    }
}
