namespace SimpleContactManager.Api;

internal static class ScmApi
{
    public record Thing
    {
        public required string Left { get; init; }
        public required string Right { get; init; }
    }

    public static IEnumerable<Thing> GetThings()
    {
        yield return new () { Left = "da left", Right = "da right" };
        yield return new () { Left = "mo left", Right = "mo right" };
        yield return new () { Left = "even mo left!!", Right = "even mo right!!" };
        yield return new () { Left = "required stuff here", Right = "required stuff here too" };
    }
}
