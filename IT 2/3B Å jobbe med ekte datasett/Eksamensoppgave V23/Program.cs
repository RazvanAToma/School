
using CsvHelper;
using System.Globalization;

var reader = new StreamReader("googleplaystore.csv");
var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

var GooglePlaystoreAppList = csv.GetRecords<GooglePlaystoreApp>().ToList();

int top1 = 0;
int top2 = 0;
int top3 = 0;

string topOne = "";
string topTwo = "";
string topThree = "";

List<string> cats = new List<string>();

foreach (GooglePlaystoreApp app in GooglePlaystoreAppList)
{
    cats.Add(app.Category);
}

Dictionary<string, int> catCount = new Dictionary<string, int>();

foreach (string cat in cats)
{
    if (catCount.ContainsKey(cat))
    {
        catCount[cat] += 1;
    }
    else
    {
        catCount[cat] = 1;
    }
}

foreach (KeyValuePair<string, int> pair in catCount)
{
    if (pair.Value > top1)
    {
        top3 = top2;
        topThree = topTwo;

        top2 = top1;
        topTwo = topOne;

        top1 = pair.Value;
        topOne = pair.Key;
    }
    else if (pair.Value > top2)
    {
        top3 = top2;
        topThree = topTwo;

        top2 = pair.Value;
        topTwo = pair.Key;
    }
    else if (pair.Value > top3)
    {
        top3 = pair.Value;
        topThree = pair.Key;
    }
}

Console.WriteLine($"1: {topOne} with {top1} apps");
Console.WriteLine($"2: {topTwo} with {top2} apps");
Console.WriteLine($"3: {topThree} with {top3} apps");

int DownloadStrToInt(GooglePlaystoreApp app)
{
    string appDownloadsStr = app.Installs;

    appDownloadsStr = appDownloadsStr.Replace("+", "");
    appDownloadsStr = appDownloadsStr.Replace(",", "");

    int appDownloadsInt = 0;

    if (appDownloadsStr != "Free")
    {
        appDownloadsInt = int.Parse(appDownloadsStr);
    }

    return appDownloadsInt;
}

void TopDownloadAverage()
{
    List<int> downloadsOne = new List<int>();
    List<int> downloadsTwo = new List<int>();
    List<int> downloadsThree = new List<int>();

    foreach (GooglePlaystoreApp app in GooglePlaystoreAppList)
    {
        if (app.Category == topOne)
        {
            downloadsOne.Add(DownloadStrToInt(app));
        }
        else if (app.Category == topTwo)
        {
            downloadsTwo.Add(DownloadStrToInt(app));
        }
        else if (app.Category == topThree)
        {
            downloadsThree.Add(DownloadStrToInt(app));
        }
    }

    Console.WriteLine(Math.Round(downloadsOne.Average()));
    Console.WriteLine(Math.Round(downloadsTwo.Average()));
    Console.WriteLine(Math.Round(downloadsThree.Average()));
}

TopDownloadAverage();


void TopRatingAverage()
{
    List<double> ratingsOne = new List<double>();
    List<double> ratingsTwo = new List<double>();
    List<double> ratingsThree = new List<double>();

    foreach (GooglePlaystoreApp app in GooglePlaystoreAppList)
    {
        if (!double.IsNaN(app.Rating))
        {
            if (app.Category == topOne)
            {
                ratingsOne.Add(app.Rating);
            }
            else if (app.Category == topTwo)
            {
                ratingsTwo.Add(app.Rating);
            }
            else if (app.Category == topThree)
            {
                ratingsThree.Add(app.Rating);
            }
        }
    }

    Console.WriteLine(ratingsOne.Average());
    Console.WriteLine(ratingsTwo.Average());
    Console.WriteLine(ratingsThree.Average());
}

TopRatingAverage();