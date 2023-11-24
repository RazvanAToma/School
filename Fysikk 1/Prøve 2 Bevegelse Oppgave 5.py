import numpy as np
import matplotlib.pyplot as plt

#Lager en liste t med 1000 tids-verdier fra 0 til 8 s. Lengden av hvert tidssteg kaller vi dt.
n = 1000
T = 8 #s
t = np.linspace(0, T, n)
dt = T/n

#Lager tomme lister for posisjon, fart og akselerasjon.
s = np.zeros(n)
v = np.zeros(n)
a = np.zeros(n)

#Definerer konstanter og startverdier.
k = 0.02 # Luftmotstandskoeffisient
m = 0.230 # Vekt i kg
g = 9.81 # m/s^2

for i in range(n-1):
  G = -m*g
  L = -k*v[i]*abs(v[i])
  F_sum = L + G
  a[i] = F_sum/m
  v[i+1] = v[i] + a[i]*dt
  s[i+1] = s[i] + v[i]*dt

#Lager fartsgrafen.
plt.figure(2)
plt.grid()
plt.title("Fart")
plt.xlabel("$t$ / s")
plt.ylabel("$v$ / (m/s)")
plt.plot(t, v, label='k = %.2f' %k)
plt.legend()

plt.show()