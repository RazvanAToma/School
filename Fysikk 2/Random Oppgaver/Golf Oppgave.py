from math import sqrt

m = 0.046

def regn(m):
    dt = 0.01
    v = 0
    s = 0
    t = 0
    k = 0.00044
    g = 9.81

    vT = round(sqrt((m * g)/k))

    while v < vT:
        t += dt
        F = m*g - k*v**2
        a = F/m
        v = v + a*dt
        s = s + v*dt

    return s


print(regn(m * 2) - regn(m))
