using TeamSite.Web.Models;

namespace TeamSite.Web.Data;

/// <summary>
/// Everything your team's site says. To change the site, edit this file.
/// Images go in wwwroot/images/.
/// </summary>
public static class TeamInfo
{
    public static readonly Team Team = new()
    {
        Name = "Team Name",
        ShortName = "Team",
        Program = "FTC",
        Number = 0,
        Tagline = "One sentence about what your team is about.",
        Logo = "/images/pv-logo.png",
        AccentColor = "#8b5cf6",
        Story =
        [
            "Write a few sentences about your team here: when it started, what you build, and what you're proud of.",
        ],
    };

    // The menu at the top of every page. Add a line when you add a page.
    public static readonly List<(string Label, string Href)> Nav =
    [
        ("Home", "/"),
    ];

    public const string PvSite = "https://www.firstpvrobotics.com";
}
