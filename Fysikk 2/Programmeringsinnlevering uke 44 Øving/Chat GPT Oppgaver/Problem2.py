import math
import numpy as np
import matplotlib.pyplot as plt

# Definerer konstanter
m = 50                                       # kg
g = 9.81                                     # m/s^2
friksjon = 0.08
vinkel = 25                                  # grader
vinkel = math.radians(vinkel)
F_gravitasjon = m * g * math.sin(vinkel)     # N
F_friksjon = friksjon * m * g * math.cos(vinkel) # N

n = 10000
t = np.linspace(0, 10, n)   # 10 er her antall sekunder
dt = t[1] - t[0]

a = np.zeros(n)
v = np.zeros(n)
s = np.zeros(n)

# Euler metoden
for i in range (0, n-1):
    F_x = F_gravitasjon - F_friksjon
    a[i] = F_x / m              # Newtons 2. Lov, F_x = m*a. Omformulerer og løser legger inn verdien for a i arrayen.
    v[i+1] = v[i] + a[i] * dt   # Tar fartsverdien fra arrayen, legger til arealet under akselerasjonsgrafen, og setter neste verdi i arrayen til svaret
    s[i+1] = s[i] + v[i] * dt   # Tar posisjonsverdien fra arrayen, plusser på arealet under fartsgrafen, og setter nestes verdi i arrayen til svaret


plt.figure(1)
plt.plot(t, -s)   # Tid, Posisjon
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
a[-1] = a[-2]
plt.plot(t,a)   # Tid, Akselerasjon
plt.grid()
plt.title("Akselerasjon")
plt.xlabel("$t$ / s")
plt.ylabel("$a$ / m/s^2")

plt.show()