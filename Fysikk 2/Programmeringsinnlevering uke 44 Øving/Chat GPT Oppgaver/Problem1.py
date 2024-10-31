import numpy as np
import matplotlib.pyplot as plt

# Definerer konstanter
m = 5       # kg
k = 0.2     # kg/m
g = 9.81    # m/s^2
F = m * g   # N

n = 10000
t = np.linspace(0, 20, n)   # 20 er her antall sekunder
dt = t[1] - t[0]

a = np.zeros(n)
v = np.zeros(n)
s = np.zeros(n)

a_uten = np.zeros(n)
v_uten = np.zeros(n)
s_uten = np.zeros(n)

# Euler metoden
for i in range (0, n-1):

    L = k*v[i]**2
    F_sum = F - L               # Tar gravitasjonskraften og trekker fra luftmotstanden.
    a[i] = F_sum / m            # Newtons 2. Lov, F_sum = m*a. Omformulerer og løser legger inn verdien for a i arrayen.
    v[i+1] = v[i] + a[i] * dt   # Tar fartsverdien fra arrayen, legger til arealet under akselerasjonsgrafen, og setter neste verdi i arrayen til svaret
    s[i+1] = s[i] + v[i] * dt   # Tar posisjonsverdien fra arrayen, plusser på arealet under fartsgrafen, og setter nestes verdi i arrayen til svaret

    F_sum_uten = F                              # Tar gravitasjonskraften og trekker fra luftmotstanden.
    a_uten[i] = F_sum_uten / m                  # Newtons 2. Lov, F_sum = m*a. Omformulerer og løser legger inn verdien for a i arrayen.
    v_uten[i+1] = v_uten[i] + a_uten[i] * dt    # Tar fartsverdien fra arrayen, legger til arealet under akselerasjonsgrafen, og setter neste verdi i arrayen til svaret
    s_uten[i+1] = s_uten[i] + v_uten[i] * dt    # Tar posisjonsverdien fra arrayen, plusser på arealet under fartsgrafen, og setter nestes verdi i arrayen til svaret


plt.figure(1)
plt.plot(t,s)   # Tid, Posisjon
plt.grid()
plt.title("Posisjon med luftmotstand")
plt.xlabel("$t$ / s")
plt.ylabel("$s$ / m")

plt.figure(2)
plt.plot(t, s_uten)   # Tid, Posisjon uten
plt.grid()
plt.title("Posisjon uten luftmotstand")
plt.xlabel("$t$ / s")
plt.ylabel("$s$ / m")

v_terminal = np.sqrt(F / k)
plt.figure(3)
plt.plot(t, v)   
plt.axhline(y=v_terminal, color='r', linestyle='--', label="Terminal Velocity")
plt.grid()
plt.title("Fart med luftmotstand")
plt.xlabel("$t$ / s")
plt.ylabel("$v$ / m/s")
plt.legend()

plt.figure(4)
plt.plot(t, v_uten)   # Tid, Fart uten
plt.grid()
plt.title("Fart uten luftmotstand")
plt.xlabel("$t$ / s")
plt.ylabel("$v$ / m/s")

plt.show()