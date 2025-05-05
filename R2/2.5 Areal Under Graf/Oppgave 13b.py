from numpy import log

def f(x):
    return ((log(1+x)-log(x))/(1+x**2)) # Definere funksjon

x_min = float(input(f"Nedre grense: ")) 
x_max = float(input(f"Ovre grense: "))
n = int(input(f"Antall rektangler: "))

dx = (x_max - x_min)/n

x = x_min

areal = 0

for i in range(1, n):
    areal += dx * f(x)

    x += dx

print(round(areal, 2))