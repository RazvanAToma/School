
int aarstall = 2025;

// 1
int a = aarstall % 19;

// 2
int b = aarstall / 100;
int c = aarstall % 100;

// 3
int d = b / 4;
int e = b % 4;

// 4
int f = (b + 8) / 25;

// 5
int g = (b - f + 1) / 3;

// 6
int h = (19 * a + b - d - g + 15) % 30;

// 7
int i = c / 4;
int k = c % 4;

// 8
int l = (32 + 2 * e + 2 * i - h - k) % 7;

// 9
int m = (a + 11 * h + 22 * l) / 451;

// 10
int n = (h + l - 7 * m + 114) / 31;
int p = (h + l - 7 * m + 114) % 31;
p += 1;

Console.WriteLine($"n: {n}, p: {p}");