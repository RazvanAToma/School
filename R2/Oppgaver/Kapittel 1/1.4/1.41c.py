import math

a_1 = 100
d = -2
n = 0
sum = 0

while n <= 50 / abs(d):
    n += 1
    sum += a_1 + (n - 1) * d

print(sum)

