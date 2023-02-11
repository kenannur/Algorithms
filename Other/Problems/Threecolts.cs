using System;
using System.Collections.Generic;
using System.Linq;

namespace Other.Problems;

public static class Threecolts
{
    public static int CountUniqueUrls(string[] urls)
    {
        return urls
            .Where(x => !string.IsNullOrWhiteSpace(x) && Uri.IsWellFormedUriString(x, UriKind.Absolute))
            .Select(x => new Uri(x.ToLower()))
            .GroupBy(x => new
            {
                x.Scheme,
                Host = x.Host.Replace("www.", ""),
                AbsolutePath = x.AbsolutePath.Replace("//", "/")
            }).Count();
    }


    public static Dictionary<string, int> CountUniqueUrlsPerTopLevelDomain(string[] urls)
    {
        return urls
            .Where(x => !string.IsNullOrWhiteSpace(x) && Uri.IsWellFormedUriString(x, UriKind.Absolute))
            .Select(x => new Uri(x.ToLower()))
            .GroupBy(x =>
            {
                var normalizedHost = x.Host.Replace("www.", "");
                var topLevelDomainParts = normalizedHost.Split('.').TakeLast(2);
                var topLevelDomain = string.Join('.', topLevelDomainParts);
                return topLevelDomain;
            }).ToDictionary(x => x.Key, y => y.Count());
    }
}

