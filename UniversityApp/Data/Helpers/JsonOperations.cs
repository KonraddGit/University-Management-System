using Newtonsoft.Json;
using System.Collections.Generic;
using UniversityApp.Data.Models;

namespace UniversityApp.Data.Helpers
{
    public static class JsonOperations
    {
        public static string ToJson<T>(this IEnumerable<T> collection)
        {
            var schedule = JsonConvert.SerializeObject(
                new
                {
                    schedule = collection
                });

            return schedule.RemoveSlash();
        }

        public static string ToJson(this GenerateFileHelper collection)
        {
            var schedule = JsonConvert.SerializeObject(
                new
                {
                    schedule = collection
                });

            return schedule.RemoveSlash();
        }

        private static string RemoveSlash(this string schedule)
            => schedule.Replace("\'", " ");

        private static string RemoveNotWanted(this string schedule)
            => schedule[11..^(-1)];
    }
}