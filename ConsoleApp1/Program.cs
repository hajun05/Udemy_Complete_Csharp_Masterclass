using System.Globalization;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    #region 섹션 11
    public delegate void TemperatureChangedHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        public int Temperature { get; }
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        //public event TemperatureChangedHandler OnTemperatureChanged;
        public EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        private int _temperature;
        public int Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                //if (_temperature > 30)
                //{
                //    RaiseTemperatureChangedEvent("Temperature is above threshold!");
                //}
                //else
                //{
                //    RaiseTemperatureChangedEvent("Temperature can be thresholded");
                //}
                OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }

    public class TemperatureAlert
    {
        public static void HandlerTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine("Alert: " + e.Temperature + " " + sender);
        }
    }
    #endregion

    internal class Program
    {
        #region 섹션4
        static double CalculateAverage(int[] temperatures)
        {
            double SumTemperatue = 0;

            foreach (int temperature in temperatures)
            {
                SumTemperatue += temperature;
            }

            return SumTemperatue / temperatures.Length;
        }

        static int CalculateMin(ref int[] temperatures)
        {
            int Min = int.MaxValue;

            foreach (int temperature in temperatures)
            {
                if (temperature < Min) 
                    Min = temperature;
            }

            return Min;
        }

        static int CalculateMax(ref int[] temperatures)
        {
            int Max = int.MinValue;

            foreach (int temperature in temperatures)
            {
                if (temperature > Max)
                    Max = temperature;
            }

            return Max;
        }

        static string MostCommonWeatherCondition(ref string[] conditions)
        {
            int mostCount = 0;
            string mostCommon = "";

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j].Equals(conditions[i]))
                    {
                        tempCount++;
                    }
                }
                if (tempCount > mostCount)
                {
                    mostCount = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
        }
        #endregion

        static void Main(string[] args)
        {
            #region 섹션4
            //Program program = new Program();

            //Console.WriteLine("Enter the numbetr of days to simulate:");
            //int days = int.Parse(Console.ReadLine());

            //int[] temperatures = new int[days];
            //string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            //string[] weatherConditions = new string[days];

            //Random rand = new Random();

            //for(int i = 0; i < days; i++)
            //{
            //    temperatures[i]= rand.Next(-10, 40);
            //    weatherConditions[i] = conditions[rand.Next(conditions.Length)];
            //}

            //Console.WriteLine($"Average Tempurature is : {CalculateAverage(temperatures) :F2}'C");
            //Console.WriteLine(($"Max Tempurature is : {CalculateMax(ref temperatures)}"));
            //Console.WriteLine(($"Min Tempurature is : {CalculateMin(ref temperatures)}"));
            //Console.WriteLine(($"Most Common Condition is : {MostCommonWeatherCondition(ref weatherConditions)}"));
            #endregion

            #region 섹션5
            //Car audi = new Car("A3", "Audi", false);
            //Car bmw = new Car("i7", "BMW", true);

            //Console.WriteLine("Please enter the Brand name");
            //audi.Brand = Console.ReadLine();

            //Console.WriteLine($"Brand is : {audi.Brand}");

            //audi.Drive();
            //bmw.Drive();

            //Customer myCustomer = new Customer();
            //myCustomer.SetDetails("Frank", "Mainstreet 2", "5551234567");
            // 연습 코드

            // QuizApp 미니 프로젝트
            //Question[] questions = new Question[]
            //{
            //    new Question("What is the capital of Germany?",
            //    new string[] {"Paris", "Berlin", "London", "Mardrid"},
            //    1
            //    ),
            //    new Question("What is 2 + 2?",
            //    new string[] {"3", "4", "5", "6"},
            //    1
            //    ),
            //    new Question("Who wrote 'Hamblet'?",
            //    new string[] {"Goethe", "Austen", "Shakepere", "Dickens"},
            //    2
            //    )
            //};

            //Quiz myQuiz = new Quiz(questions);
            //myQuiz.StartQuiz();

            #endregion

            #region 섹션6
            //List<int> nums = new List<int> { 1, 2, 5, 223, 543, 33, 23, 223 };

            //List<int> bignums = nums.FindAll(x => x > 100);


            #endregion

            #region 섹션11
            //TemperatureMonitor monitor = new TemperatureMonitor();
            //monitor.TemperatureChanged += TemperatureAlert.HandlerTemperatureChanged;

            //monitor.Temperature = 20;
            //monitor.Temperature = int.Parse(Console.ReadLine());
            #endregion

            #region 섹션12
            string pattern = @"\d{4,}";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12345, 339242, 211";

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("{0}", matches.Count);

            foreach (Match item in matches)
            {
                GroupCollection group = item.Groups;
                Console.WriteLine($"{group[0].Value} {group[0].Index}");
            }

            //string input = "2023-12-31";
            //Regex regex = new Regex(@"(\d{4})-(\d{2})-(\d{2})"); // 날짜 패턴
            //Match match = regex.Match(input);

            //if (match.Success)
            //{
            //    Console.WriteLine($"전체 매치: {match.Groups[0].Value}");
            //    Console.WriteLine($"년도: {match.Groups[1].Value}");
            //    Console.WriteLine($"월: {match.Groups[2].Value}");
            //    Console.WriteLine($"일: {match.Groups[3].Value}");
            //}
            #endregion
            Console.ReadKey();
        }

    }

    #region 섹션9
    //public interface ILogger
    //{
    //    void Log(string message);
    //}

    //public class FileLogger : ILogger
    //{
    //    public void Log(string message)
    //    {
    //        File.AppendAllText("log.txt", message + "\n");
    //    }
    //}

    //public class DatabaseLogger : ILogger
    //{
    //    public void Log(string message)
    //    {
    //        Console.WriteLine($"Logging to database: {message}");
    //        // 실제 데이터베이스 로직은 생략 (콘솔 출력으로 대체)
    //    }
    //}

    //public class Application
    //{
    //    private readonly ILogger _logger;

    //    public Application(ILogger logger)
    //    {
    //        _logger = logger;
    //    }

    //    public void DoWork()
    //    {
    //        _logger.Log("Work started");
    //        // 작업 수행 로직
    //        _logger.Log("Work done");
    //    }
    //}
    #endregion
}
