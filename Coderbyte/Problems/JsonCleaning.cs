using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Coderbyte.Problems
{
	public static class JsonCleaning
	{
		public static void Solve()
		{
            var request = WebRequest.Create("https://coderbyte.com/api/challenges/json/json-cleaning");
            var response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var jsonString = reader.ReadToEnd();
                string filtered = CleanJson(jsonString);
                Console.WriteLine(filtered);
            }
        }

        private static string CleanJson(string jsonString)
        {
            string originalEmptyValues = "(\"\"|\"[-]\")";
            string emptyPlaceholder = "#empty#";
            string emptyKeyValues = "(\"[a-zA-Z]+\":#empty#,|,\"[a-zA-Z]+\":#empty#)";
            string emptyArrayValues = "(#empty#,|,#empty#)";
            string result = Regex.Replace(jsonString, originalEmptyValues, emptyPlaceholder);
            result = result.Replace("\"N\\/A\"", "#empty#");
            result = Regex.Replace(result, emptyKeyValues, "");
            result = Regex.Replace(result, emptyArrayValues, "");
            return result;
        }
    }
}

