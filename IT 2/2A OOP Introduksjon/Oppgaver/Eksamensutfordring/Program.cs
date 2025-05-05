

using Eksamensutfordring;

Battery battery1 = new Battery("No. 1", 5000f, 5000f);

Console.WriteLine($"Remaining capacity: {battery1.ShowCharge()} mAh");

battery1.Use(2500f); // mAh;
battery1.Charge(2000f);

Console.WriteLine($"Remaining capacity: {battery1.ShowCharge()} mAh");

battery1.Use(-2500f); // mAh;
battery1.Charge(2000f);