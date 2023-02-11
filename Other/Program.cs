using Other.Problems;
using System;

namespace Other
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightDivider.Solve();

            var r1 = Threecolts.CountUniqueUrls(new[] { "https://example.com", "https://example.com/" });
            var r2 = Threecolts.CountUniqueUrls(new[] { "https://example.com", "http://example.com" });
            var r3 = Threecolts.CountUniqueUrls(new[] { "https://example.com?", "https://example.com" });
            var r4 = Threecolts.CountUniqueUrls(new[] { "https://example.com?a=1&b=2", "https://example.com?b=2&a=1" });
            var r5 = Threecolts.CountUniqueUrls(new[] { "http://example.com/foo%2a", "http://example.com/foo%2A" });
            var r6 = Threecolts.CountUniqueUrls(new[] { "HTTP://User@Example.COM/Foo", "http://User@example.com/Foo" });
            var r7 = Threecolts.CountUniqueUrls(new[] { "http://example.com/%7Efoo", "http://example.com/~foo" });
            var r8 = Threecolts.CountUniqueUrls(new[] { "http://example.com/foo/./bar/baz/../qux", "http://example.com/foo/bar/qux" });
            var r9 = Threecolts.CountUniqueUrls(new[] { "http://www.example.com/", "http://example.com/" });
            var r10 = Threecolts.CountUniqueUrls(new[] { "http://example.com/foo//bar.html", "http://example.com/foo/bar.html" });

            var t1 = Threecolts.CountUniqueUrlsPerTopLevelDomain(new[] { "https://example.com", "https://subdomain.example.com" });
            var t2 = Threecolts.CountUniqueUrlsPerTopLevelDomain(new[] { "https://test.example.com", "https://test.test.com" });

            Console.ReadLine();
        }
    }
}
