using Microsoft.AspNetCore.Mvc;
using RatGame.Server.Models;

namespace RatGame.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly List<Test> _tests = new()
    {
        new Test
        {
            Id = 1,
            Hint1 = "Hint 1",
            Hint2 = "Hint 2",
            Hint3 = "Hint 3",
            Answer = "Answer",
            Difficulty = TestDifficulty.VeryEasy
        }
    };

    [HttpGet("{id}")]
    public IActionResult GetTest(int id)
    {
        var test = _tests.FirstOrDefault(t => t.Id == id);

        if (test == null)
        {
            return NotFound();
        }

        return Ok(TestResponse.FromModel(test));
    }

    [HttpGet]
    public IActionResult GetTestsByDifficulty(TestDifficulty? difficulty)
    {
        var tests = _tests.AsQueryable();

        if (difficulty.HasValue)
        {
            tests = tests.Where(t => t.Difficulty == difficulty.Value);
        }

        var response = tests.Select(t => TestResponse.FromModel(t));

        return Ok(response);
    }

    [HttpPost("validate")]
    public IActionResult ValidateAnswer(ValidateAnswerRequest request)
    {
        var test = _tests.FirstOrDefault(t => t.Id == request.TestId);

        if (test == null)
        {
            return NotFound();
        }

        bool isCorrect = test.Answer.Equals(request.Answer, StringComparison.OrdinalIgnoreCase);

        return Ok(new ValidateAnswerResponse(isCorrect));
    }
}

public record TestResponse(string Hint1, string Hint2, string Hint3, TestDifficulty Difficulty)
{
    public static TestResponse FromModel(Test test) => new TestResponse(test.Hint1, test.Hint2, test.Hint3, test.Difficulty);
}

public record TestsResponse(List<TestResponse> Tests);

public record ValidateAnswerRequest(int TestId, string Answer);

public record ValidateAnswerResponse(bool IsCorrect);