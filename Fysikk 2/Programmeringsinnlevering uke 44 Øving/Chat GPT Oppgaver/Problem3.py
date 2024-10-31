import numpy as np
import matplotlib.pyplot as plt

# Definerer konstanter
m = 50  # kg
g = 9.81  # m/s^2
v0 = 30  # m/s
k = 0.3

n = 10000
t = np.linspace(0, 500, n)  # 10 er her antall sekunder
dt = t[1] - t[0]

v = np.zeros(n)
v[0] = v0

# Euler metoden med akselerasjon pga drag
for i in range(0, n - 1):
    a = -k * v[i]**2 / m  # Akselerasjon pga drag
    v[i + 1] = v[i] + a * dt  # Oppdater fart
    
    # Stoppe hvis hastigheten når 0
    if v[i + 1] <= 0:
        v[i + 1] = 0  # Setter fart til 0
        break  # Stoppe simuleringen

# Justering av tid for plotting
t = t[:i + 2]  # Juster tid for plotting

plt.figure(1)
plt.plot(t, v[:i + 2])  # Tid, Fart
plt.grid()
plt.title("Fart")
plt.xlabel("$t$ / s")
plt.ylabel("$v$ / m/s")

plt.show()
