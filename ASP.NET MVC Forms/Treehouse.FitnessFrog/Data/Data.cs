using Treehouse.FitnessFrog.Models;

namespace Treehouse.FitnessFrog.Data;

public static class Data
{
    public static List<Activity> Activities { get; set ;} = null!;
    public static List<Entry> Entries { get; set; } = null!;

    static Data()
    {
        InitData();
    }

    private static void InitData()
    {
        var activities = new List<Activity>()
        {
            new(Activity.ActivityType.Basketball),
            new(Activity.ActivityType.Biking),
            new(Activity.ActivityType.Hiking),
            new(Activity.ActivityType.Kayaking),
            new(Activity.ActivityType.PokemonGo, "Pokemon Go"),
            new(Activity.ActivityType.Running),
            new(Activity.ActivityType.Skiing),
            new(Activity.ActivityType.Swimming),
            new(Activity.ActivityType.Walking),
            new(Activity.ActivityType.WeightLifting, "Weight Lifting")
        };

        var entries = new List<Entry>()
        {
            new(1, 2016, 7, 8, Activity.ActivityType.Biking, 10.0),
            new(2, 2016, 7, 9, Activity.ActivityType.Biking, 12.2),
            new(3, 2016, 7, 10, Activity.ActivityType.Hiking, 123.0),
            new(4, 2016, 7, 12, Activity.ActivityType.Biking, 10.0),
            new(5, 2016, 7, 13, Activity.ActivityType.Walking, 32.2),
            new(6, 2016, 7, 13, Activity.ActivityType.Biking, 13.3),
            new(7, 2016, 7, 14, Activity.ActivityType.Biking, 10.0),
            new(8, 2016, 7, 15, Activity.ActivityType.Walking, 28.6),
            new(9, 2016, 7, 16, Activity.ActivityType.Biking, 12.7),
            new(10, 2016, 7, 16, Activity.ActivityType.PokemonGo, 23.4)
        };

        Activities = activities;
        Entries = entries;
    }
}