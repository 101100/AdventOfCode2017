using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace AdventOfCode2017
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var dayString = args.Length >= 1
                ? args[0]
                : ReadDay();

            if (!byte.TryParse(dayString, out var day))
            {
                Console.WriteLine($"I've never heard of day '{dayString}', sorry.");
                return;
            }

            if (day == 1)
            {
                const string input =
                    "68376334795224855827459835293967497295464175589881588256882344699473595413912688278647235862566123233983921662578792917453912795352746426512649965615919588512125567186837411371179875287621488759761429629174886972298349197722423458299323141529413191327622485249495864168181327197661454464926326248274999448373741839963155646828842752761293142356422964355349521987483211496361289666375779728345952231649453711684539164893151811849653331845998998597991146881361717234517911759893792348815818755262456378627116779495435596139617246571678531183335956244163871445674244765586446362529159854137535962117184875192273872222899887357292312978286182636232921252574738118347521187637829623831872437381979223955675634257889137823684924127338433248519515211796732599314921611399736571277222546332369461136277417419794865524123989722492356536832313937597437717873787593849468836733642529378547151146397532997237439387663769334722979172954835154486382983716698212694357398153392926255272961384626131829678171219569288685597141132355322788254163923888378155573948753185423158997877718687642446457446643422536541238979761725496426292359382168535641216124211741896552562128941824172241913873537828976172738276983915232241451589421911121567228899853934667954786256223614621554618294467191255153395256524786159758429643756586457639177183891162214163549688595416893383194995824534247841414247526268212761954913719452114876764745799982792594753759626334319631191917894368116738893548797661111899664138398354818931135486984944719992393148681724116616741428937687985152658296679845474766477741553632712968679175356452987459761126437216758171182395219393289199148996813762849991484678429793578629331215796996751484375784895561682156658579887518746862371751372692472765217374791324656745291574784495299477362964676351148183676897122366838656342745944945275263617729359831466565694983217252594237828187612857523344265418227883219383138893873384775659548637662867572687198263688597865118173921615178165442133987362382721444844952715592955744739873677838847693982379696776";

                Console.WriteLine($"Part 1: {Day1Part1(input)}");
                Console.WriteLine($"Part 2: {Day1Part2(input)}");
            }
            else if (day == 2)
            {
                const string input = @"409	194	207	470	178	454	235	333	511	103	474	293	525	372	408	428
4321	2786	6683	3921	265	262	6206	2207	5712	214	6750	2742	777	5297	3764	167
3536	2675	1298	1069	175	145	706	2614	4067	4377	146	134	1930	3850	213	4151
2169	1050	3705	2424	614	3253	222	3287	3340	2637	61	216	2894	247	3905	214
99	797	80	683	789	92	736	318	103	153	749	631	626	367	110	805
2922	1764	178	3420	3246	3456	73	2668	3518	1524	273	2237	228	1826	182	2312
2304	2058	286	2258	1607	2492	2479	164	171	663	62	144	1195	116	2172	1839
114	170	82	50	158	111	165	164	106	70	178	87	182	101	86	168
121	110	51	122	92	146	13	53	34	112	44	160	56	93	82	98
4682	642	397	5208	136	4766	180	1673	1263	4757	4680	141	4430	1098	188	1451
158	712	1382	170	550	913	191	163	459	1197	1488	1337	900	1182	1018	337
4232	236	3835	3847	3881	4180	4204	4030	220	1268	251	4739	246	3798	1885	3244
169	1928	3305	167	194	3080	2164	192	3073	1848	426	2270	3572	3456	217	3269
140	1005	2063	3048	3742	3361	117	93	2695	1529	120	3480	3061	150	3383	190
489	732	57	75	61	797	266	593	324	475	733	737	113	68	267	141
3858	202	1141	3458	2507	239	199	4400	3713	3980	4170	227	3968	1688	4352	4168";
                
                Console.WriteLine($"Part 1: {Day2Part1(input)}");
                Console.WriteLine($"Part 2: {Day2Part2(input)}");
            }
            else if (day == 3)
            {
                var input = GetIntInput(args) ?? 312051;
                
                Console.WriteLine($"Part 1: {Day3Part1(input)}");
                Console.WriteLine($"Part 2: {Day3Part2(input)}");
            }
            else
            {
                Console.WriteLine($"I've never heard of day '{day}', sorry.");
            }
        }

        private static string ReadDay()
        {
            Console.Write("Run what day: ");
            return Console.ReadLine();
        }

        private static int? GetIntInput(string[] args)
        {
            return args.Length >= 2
                ? int.Parse(args[1])
                : default(int?);
        }

        private static int Day1Part1(string input)
        {
            return input
                .StartWith(input.Last())
                .PairWise()
                .Aggregate(0, (sum, t) => t.Item1 == t.Item2 ? sum + (t.Item1 - '0') : sum);
        }

        private static int Day1Part2(string input)
        {
            var halfLength = input.Length / 2;
            
            return 2 * input.Take(halfLength)
                .Zip(input.Skip(halfLength), Tuple.Create)
                .Aggregate(0, (sum, t) => t.Item1 == t.Item2 ? sum + (t.Item1 - '0') : sum);
        }

        private static int Day2Part1(string input)
        {
            return input
                .Split("\r\n")
                .Select(row => row
                    .Split("\t")
                    .Select(int.Parse)
                    .ToArray())
                .Select(row => row.Aggregate(0, Math.Max) - row.Aggregate(int.MaxValue, Math.Min))
                .Aggregate(0, (a, b) => a + b);
        }

        private static int Day2Part2(string input)
        {
            return input
                .Split("\r\n")
                .Select(row => row
                    .Split("\t")
                    .Select(int.Parse)
                    .ToArray())
                .Select(row => row
                    .AllPairs()
                    .Where(t => t.Item1 > t.Item2 ? t.Item1 % t.Item2 == 0 : t.Item2 % t.Item1 == 0)
                    .Select(t => t.Item1 > t.Item2 ? t.Item1 / t.Item2 : t.Item2 / t.Item1)
                    .First())
                .Debug()
                .Aggregate(0, (a, b) => a + b);
        }

        private static int Day3Part1(int input)
        {
            if (input == 1)
            {
                return 0;
            }
            
            var ring = (((int) Math.Sqrt(input - 1)) + 1) / 2;

            var offset = ((ring - 1) * 2 + 1) * ((ring - 1) * 2 + 1) + 1;
            var sideLength = ring * 2;
            var middleIndex = ring - 1;

            var circularIndex = input - offset;
            
            return ring + Math.Abs((circularIndex % sideLength) - middleIndex);
        }

        private static int Day3Part2(int input)
        {
            return EnumerableExtensions
                .Generate(new [] { 1 }.ToImmutableList(), _ => true, last =>
                {
                    var nextPoint = Day3ToPoint(last.Count + 1);
                    var nextValue = Day3GetNeighbours(nextPoint)
                        .Select(Day3FromPoint)
                        .Select(v => last.Count > v - 1 ? last[v - 1] : 0)
                        .Aggregate(0, (a, b) => a + b);
    
                    return last.Add(nextValue);
                })
                .Skip(1)
                .Select(l => l.Last())
                .SkipWhile(value => value < input)
                .First();
        }

        private static IEnumerable<Tuple<int, int>> Day3GetNeighbours(Tuple<int, int> point)
        {
            yield return Tuple.Create(point.Item1 + 1, point.Item2 + 1);
            yield return Tuple.Create(point.Item1 + 1, point.Item2);
            yield return Tuple.Create(point.Item1 + 1, point.Item2 - 1);
            yield return Tuple.Create(point.Item1, point.Item2 + 1);
            yield return Tuple.Create(point.Item1, point.Item2 - 1);
            yield return Tuple.Create(point.Item1 - 1, point.Item2 + 1);
            yield return Tuple.Create(point.Item1 - 1, point.Item2);
            yield return Tuple.Create(point.Item1 - 1, point.Item2 - 1);
        }

        private static Tuple<int, int> Day3ToPoint(int input)
        {
            if (input == 1)
            {
                return Tuple.Create(0, 0);
            }
            
            var ring = (((int) Math.Sqrt(input - 1)) + 1) / 2;

            var offset = ((ring - 1) * 2 + 1) * ((ring - 1) * 2 + 1) + 1;
            var sideLength = ring * 2;
            var middleIndex = ring - 1;

            var circularIndex = input - offset;

            var sideIndex = (circularIndex % sideLength) - middleIndex;

            var quadrant = circularIndex / sideLength;
            var x = quadrant == 0 ? ring
                : quadrant == 1 ? -sideIndex
                : quadrant == 2 ? -ring
                : sideIndex;
            var y = quadrant == 0 ? sideIndex
                : quadrant == 1 ? ring
                : quadrant == 2 ? -sideIndex
                : -ring;
            
            return Tuple.Create(x, y);
        }

        private static int Day3FromPoint(Tuple<int, int> point)
        {
            var x = point.Item1;
            var y = point.Item2;
            
            if (x == 0 && y == 0)
            {
                return 1;
            }
            
            var ring = Math.Max(Math.Abs(x), Math.Abs(y));
            var sideLength = ring * 2;
            var middleIndex = ring - 1;

            var quadrant = x == ring && y < ring ? 0
                : y == ring && x > -ring ? 1
                : x == -ring && y > -ring ? 2
                : 3;

            var sideIndex = quadrant == 0 ? y + middleIndex
                : quadrant == 1 ? middleIndex - x
                : quadrant == 2 ? middleIndex - y
                : x + middleIndex;
            var circularIndex = sideIndex + sideLength * quadrant;

            if (circularIndex < 0)
            {
                circularIndex = circularIndex + sideLength * 4;
            }
            
            var offset = ((ring - 1) * 2 + 1) * ((ring - 1) * 2 + 1) + 1;

            return circularIndex + offset;
        }

    }
}
