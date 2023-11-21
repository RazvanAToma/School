import numpy as np
import matplotlib.pyplot as plt

#Lager en liste t med 1000 tids-verdier fra 0 til 3 s. Lengden av hvert tidssteg kaller vi dt.
n = 1000
T = 3 #s
t = np.linspace(0, T, n)
dt = T/n

#Lager tomme lister for posisjon, fart og akselerasjon.
s = np.zeros(n)
v = np.zeros(n)
a = np.zeros(n)

#Definerer konstanter og startverdier.
m = 0.200 #kg
g = 9.81 #m/s^2
k = 0.01 #N/(m/s)^2
v[0] = 10 #m/s

#Bestemmer kreftene og regner ut akselerasjonen med Newtons 2. lov for hvert tidssteg. Antar konstant fart og akselerasjon i tidssteget, og bruker det ti å regne ut ny fart og ny posisjon.
for i in range(n-1):
  G = -m*g
  L = -k*v[i]*abs(v[i])
  F_sum = L + G
  a[i] = F_sum/m
  v[i+1] = v[i] + a[i]*dt
  s[i+1] = s[i] + v[i]*dt

#Lager posisjonsgrafen.
plt.figure(1)
plt.grid()
plt.title("Posisjon")
plt.xlabel("$t$ / s")
plt.ylabel("$s$ / m")
plt.plot(t, s, label='k = %.2f' %k)
plt.legend()

#Lager fartsgrafen.
plt.figure(2)
plt.grid()
plt.title("Fart")
plt.xlabel("$t$ / s")
plt.ylabel("$v$ / (m/s)")
plt.plot(t, v, label='k = %.2f' %k)
plt.legend()

#Lager akselerasjonsgrafen.
plt.figure(3)
plt.grid()
plt.title("Akselerasjon")
plt.xlabel("$t$ / s")
plt.ylabel("$a$ / (m/s$^2$)")
plt.plot(t[:-1], a[:-1], label='k = %.2f' %k)
plt.legend()

plt.show()
