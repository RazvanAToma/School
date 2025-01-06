from math import exp
from math import pi

def f(x):
    return exp(-x**2)

a = -200
b = 200
n = 1000000
dx = (b-a)/n
x = a + dx/2
sum = 0

for i in range(n):
    sum += f(x)*dx
    x += dx

print(sum**2)