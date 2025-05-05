from math import sqrt

q = 1.60E-19
m = 1.6726E-27
B = 0.045
U = 500
v = 0

N = 6
for i in range(N):
    v = sqrt(v**2 + 2*q*U/m)


r = (m * v)/(q * B)

print(r)