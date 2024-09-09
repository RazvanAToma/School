
# Definerer fartsfunksjonen v(t) = 2t
def v(t):
    return 2 * t

# Definerer konstanter
t = 0       # Tid
s = 0       # Posisjon
dt = 0.01    # Tidsintervall / delta t

while t < 4:
    s += v(t)*dt    # Legger til arealet av fartsgrafen, som gir delta s, og plusser den paa s slik at vi faar en posisjon til slutt
    t += dt         # Legger til delta t til tid saa vi vet hvor mange sekunder det har gaatt

print(s)


