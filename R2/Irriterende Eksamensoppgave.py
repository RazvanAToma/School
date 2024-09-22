
a_1 = 100
d = 10
k = 1.05

sum_1 = 0.1
sum_2 = 0

n = 0

while sum_2 < sum_1:
    n += 1
    sum_1 += a_1 + (n-1) * d
    sum_2 += a_1 * k**(n-1)

print(n)