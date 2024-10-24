import numpy as np
import matplotlib.pyplot as plt

# Definerer konstanter
m = 0.200   # kg
g = 9.81    # m/s^2
k = 0.01    # N/(m/s)^2

# Lager en liste t med n tidsverdier fra 0 til 1.5s. Lengden av hvert tidssted kaller vi dt.
n = 1000
T = 1.5     # s
t = np.linspace(0, T, n)
dt = t[1] - t[0]

# Lager tomme lister for x- og y-posisjon med og uten luftmotstand.
x = np.zeros(n)
y = np.zeros(n)

x_uten = np.zeros(n)
y_uten = np.zeros(n)

# Definerer startposisjon og startfat.
# Med luftmotsatnd
s = np.array([0, 1.5])      # m
v = np.array([7.7, 6.4])    # m/s
y[0] = s[1]

# Uten luftmotstand
s_uten = np.array([0, 1.5])      # m
v_uten = np.array([7.7, 6.4])    # m/s
y_uten[0] = s_uten[1]


# Bruker en for-loop som beregner nye posisjoner.

for i in range(1, n):
    # Definerer kreftene
    G = np.array([0, -m*g])
    L = -k*v*abs(v)/m

    # Med luftmotstand
    a = (G + L) / m
    v += a*dt
    s += v*dt
    x[i] = s[0]
    y[i] = s[1]

    # Uten luftmotstand
    a_uten = G / m
    v_uten += a_uten*dt
    s_uten += v_uten*dt
    x_uten[i] = s_uten[0]
    y_uten[i] = s_uten[1]

# Tegner grafene.
plt.figure(1)
plt.plot(x, y, label="Med Luftmotstand")
plt.plot(x_uten, y_uten, label="Uten luftmotstand")
plt.title("Posisjon")
plt.xlabel("$x$ / m")
plt.ylabel("$y$ / m")
plt.grid()
plt.legend()
plt.show()