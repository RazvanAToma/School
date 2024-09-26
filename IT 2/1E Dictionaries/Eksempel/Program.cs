

Dictionary<Dictionary<string, string>, Dictionary<int, char>> babyNameData = new Dictionary<Dictionary<string, string>, Dictionary<int, char>>
{
    {
      new Dictionary<string, string>
      {
          { "name", "Jacob" }
      },

      new Dictionary<int, char>
      {
          { 1, 'm' }
      }
    },
    {
      new Dictionary<string, string>
      {
          { "name", "Isabella" }
      },

      new Dictionary<int, char>
      {
          { 1, 'f' }
      }
    },

    {
      new Dictionary<string, string>
      {
          { "name", "Ethan" }
      },

      new Dictionary<int, char>
      {
          { 2, 'm' }
      }
    },
    {
      new Dictionary<string, string>
      {
          { "name", "Sophia" }
      },

      new Dictionary<int, char>
      {
          { 2, 'f' }
      }
    }
};

foreach(KeyValuePair<Dictionary<string, string>, Dictionary<int, char>> info in babyNameData)
{
    foreach(KeyValuePair<string, string> info2 in info.Key)
    {
        Console.WriteLine($"Name: {info2.Value}");
    }

    foreach(KeyValuePair<int, char> info3 in info.Value)
    {
        Console.WriteLine($"Gender: {info3.Value}");
        Console.WriteLine($"Rank: {info3.Key}");
    }

    Console.WriteLine("");
}