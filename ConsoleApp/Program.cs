// See https://aka.ms/new-console-template for more information
using Algos;
using Algos.Amazon;
using Algos.Citadel;
using Algos.JPMorgan;
using Algos.TRowePrice;
using System.Collections.Frozen;

Console.WriteLine("Hello, World!");
//string filePath = "C:\\Users\\lenpe\\source\\repos\\Algos\\ConsoleApp\\bin\\Debug\\net8.0\\gleif.csv";

//using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
//using (var reader = new StreamReader(fileStream))
//{
//    string line;
//    while ((line = reader.ReadLine()) != null)
//    {
//        var values = line.Split(',');

//        // Process each line here
//        foreach (var val in values)
//        {

//            Console.WriteLine(val);
//        }
//        // Example: process the first column
//    }
//}
//DecodeStringSolution.DecodeString_v3("3[a]2[bc]"); 
//DecodeStringSolution.DecodeString_v3("3[a2[c]]");
//var numberOfWays =DecodeStringSolution.NumDecodings_v2("12235");
//var numberOfWays = DecodeStringSolution.NumDecodings_v2("19235");
//var maxLength = LongestSubstrWithoutRepeatingCharsSolution.LengthOfLongestSubstring_v2("auubca");

//var s =LongestPalindromicSubstrSolution.LongestPalindrome_v1("cbbd"); //  babac ["eat","tea","tan","ate","nat","bat"]
//var strs = new string[] { "ac", "ca", "aac", "aacc", "acc" }; //"","" "eat", "tea", "tan", "ate", "nat", "bat" 
//var s = GroupAnagramsSolution.GroupAnagrams_v2(strs);

//var sum =MaximumSubarraySolution.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

//var isValid = IsAnagramSolution.IsAnagram("anagram", "nagaram");
//var s = FizzBuzzSolution.FizzBuzz(15);
//var s = MergeIntervalsSolution.Merge(new int[][] { [1, 3], [2, 6], [8, 10], [15, 18] });

//var t = MinimumAbsoluteDifferenceSolution.MinimumAbsDifference(new int[] { 3, 8, -10, 23, 19, -4, -14, 27 }); //{ 40, 11, 26, 27, -20 }
//var b = CheckAlmostEquivalentSolution.CheckAlmostEquivalent("aaaa", "bccb");

//var str = ReverseStringSolution_v2.ReverseStringStack("hello");

//var count = StringCompression_v2.Compress_v2(new[] {'a','a', 'a', 'b', 'b', 'a', 'a'});
//var t = MaximumUnitsSolution.MaximumUnits(new int[][] { [1, 3], [5, 5], [2, 5], [4, 2], [4, 1], [3, 1], [2, 2], [1, 3], [2, 5], [3, 2] }, 35);

//var s = SuggestedProductsSolutions.SuggestedProducts(new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse");
//var t = SortByBitsSolution.SortByBits(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
//var b = FindLeastNumOfUniqueIntsSolution.FindLeastNumOfUniqueInts(new[] { 4, 3, 1, 1, 3, 3, 2 },3);

//var b = DeleteAndEarnSolution.DeleteAndEarn(new[] { 2, 2, 3, 3, 3, 4 });
//var s = MaxProfitSolution.MaxProfit(new[] { 7, 6, 4, 3, 1 });
//var t = HappyNumberSolution.HappyNumber(1111111);
//var s = RobotBounded.IsRobotBounded("GGLLGG");
//var s = TargetSum.CombinationSum(new int[2] { 2, 1 }, 3);
//var maxUnits = SlowestKeySolution.SlowestKey(new int[]{ 9, 29, 49, 50 }, "cbcd");
//var maxAverage = MaxAverageRatio.MaxAverageRatioProblem(new int[][] { [1, 2], [3, 5], [2, 2] }, 2);
//var reviews = FiveStarReviews.FiveStarReviewsProblem(new int[][] { [4, 4], [1, 2], [3, 6] }, 77);

var primes = SplitStringIntoPrimes.SplitPrimes("31173");