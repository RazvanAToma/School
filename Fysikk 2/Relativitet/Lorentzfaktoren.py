import math

fart = float(input("Fart (m/s): "))
c = 3E8 # m/s

def Lorentz(v):
    return (1/(math.sqrt(1-(v/c)**2)))

print(Lorentz(fart))