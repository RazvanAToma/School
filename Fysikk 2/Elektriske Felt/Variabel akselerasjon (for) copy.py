import numpy as np
import matplotlib.pyplot as plt

#Definer konstanter som trengs her, oppgi enhet i kommentar:
m = #kg


#Lager en liste t med n tidsverdier. Lengden av hvert tidssteg kaller vi dt.
tid_start = 0 #s
tid_slutt = # Fyll ut sluttid i sekunder
n = 1000 # Endre antall tidssteg til ditt behov
t = np.linspace(tid_start,tid_slutt,n)
dt = t[1] - t[0]

#Lager arrays for å ta vare på verdiene.
s = np.zeros(n)
v = np.zeros(n)
a = np.zeros(n)

#Definerer startverdier for v og s.
s[0] = 0 #m
v[0] = 0 #m/s

#Bruker en for-løkke til å beregne nye posisjoner med eulermetoden.
for i in range(0,n-1):
    F_sum= # Fyll ut her med formel for summen kreftene som virker
    a[i] = F_sum / m # Newtons andre lov
    v[i+1] = v[i] + a[i]*dt # Euler-metoden: antar konstant a
    s[i+1] = s[i] + v[i]*dt # Euler-metoden: antar konstant v


#Lager posisjonsgrafen.
plt.figure(1)
plt.plot(t,s)
plt.grid()
plt.title("Posisjon")
plt.xlabel("$t$ / s")
plt.ylabel("$s$ / m")
plt.savefig("posisjon.png") # Lagrer graf, endre filnavn ved behov

#Lager fartsgrafen.
plt.figure(2)
plt.plot(t,v)
plt.grid()
plt.title("Fart")
plt.xlabel("$t$ / s")
plt.ylabel("$v$ / (m/s)")
plt.savefig("fart.png") # Lagrer graf, endre filnavn ved behov

#Lager akselerasjonsgrafen.
plt.figure(3)
plt.plot(t[0:n-1],a[0:n-1])
plt.grid()
plt.title("Akselerasjon")
plt.xlabel("$t$ / s")
plt.ylabel("$a$ / (m/s$^2$)")
plt.savefig("akselerasjon.png") # Lagrer graf, endre filnavn ved behov

plt.show()
