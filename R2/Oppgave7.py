
def f(x):
    return 0.0006*x**4 - 0.07*x**3 + 2.2*x**2 - 8.2*x + 22    # Definere funksjon

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