namespace SimpleContactManager.Api;

internal static class ScmApi
{
    public sealed record Thing
    {
        public required string Left { get; init; }
        public required string Right { get; init; }
    }

    private static List<Thing> allTheThings = new ();

    public static IEnumerable<Thing> GetThings() =>
        allTheThings;

    public static void CreateThing(Thing thing) =>
        allTheThings.Add(thing);

    public static void DeleteThing(Thing thing) =>
        allTheThings.Remove(thing);
}
