import numpy as np
import matplotlib.pyplot as plt

# Definerer konstanter
m = 50      # kg
h = 4000    # m
k = 0.75    # kg/m
g = 9.81    # m/s^2
F = m * g   # N

n = 10000
t = np.linspace(0, 10, n)   # 10 er her antall sekunder
dt = t[1] - t[0]

a = np.zeros(n)
v = np.zeros(n)
s = np.zeros(n)

for i in range (0, n-1):
    F_sum = F - k*v[i]**2       # F_sum = G - L (m * a = mg - kv^2)
    a[i] = F_sum / m            # "Løser" for a
    v[i+1] = v[i] + a[i] * dt   # Tar forrige fartsverdi, og plusser på arealet under akselerasjonsgrafen
    s[i+1] = s[i] + v[i] * dt   # Tar forrige posisjonsverdi, og plusser på arealet under fartsgrafen


plt.figure(1)
plt.plot(t,s)   # Tid, Posisjon
plt.grid()
plt.title("Posisjon")
plt.xlabel("$t$ / s")
plt.ylabel("$s$ / m")

plt.figure(2)
plt.plot(t,v)   # Tid, Fart
plt.grid()
plt.title("Fart")
plt.xlabel("$t$ / s")
plt.ylabel("$v$ / m/s")

plt.figure(3)
plt.plot(t,a)   # Tid, Akselerasjon
plt.grid()
plt.title("Akselerasjon")
plt.xlabel("$t$ / s")
plt.ylabel("$a$ / m/s^2")


plt.show()
