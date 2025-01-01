from math import e

def f(x):
    return -x**2 + 6*x - 4

a = float(input("Nedre integrasjonsgrense: "))
b = float(input("Ovre integrasjonsgrense: "))
n = int(input("Antall trapeser: "))

delta_x = (b-a)/n

totalt_areal = 1/2 * f(a) * delta_x

for i in range(2, n + 1):
    x_i = a + (i - 1) * delta_x
    totalt_areal += f(x_i)*delta_x

totalt_areal += 1/2 * f(b) * delta_x

print(f"{n} trapeser gir tilnærmingsverdien {totalt_areal:.3f}")