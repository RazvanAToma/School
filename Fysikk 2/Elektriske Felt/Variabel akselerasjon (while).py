import numpy as np
import matplotlib.pyplot as plt

#Definerer konstanter og startverdier:
q = 2 * 1.60E-19
Q = 79 * 1.60E-19
k = 8.99E9
m = 6.645E-27

r = 1E-10
v = 2.9E7
d = 1.1E-13
t = 0
dt = 1.0E-22

#Lager tomme lister for å ta vare på verdiene:
t_liste = []
r_liste = []
v_liste = []
a_liste = []


#Bruker en while-løkke til å beregne nye posisjoner med eulermetoden.
while v > 0:
    F_sum = -(k * q * Q)/(r**2) # Fyll ut her med formel for summen kreftene som virker
    a = F_sum / m # Newtons andre lov
    v = v + a*dt # Euler-metoden: antar konstant a
    r = r - v*dt # Euler-metoden: antar konstant v
    t = t + dt
    
    # Legger til nye verdier i listene:
    t_liste.append(t)
    r_liste.append(r)
    v_liste.append(v)
    a_liste.append(a)

#Lager posisjonsgrafen:
plt.figure(1)
plt.plot(t_liste, r_liste)
plt.grid()
plt.title("Posisjon")
plt.xlabel("$t$ / s")
plt.ylabel("$s$ / m")
plt.savefig("posisjon.png") # Lagrer graf, endre filnavn ved behov, fjern linja hvis du ikke trenger å lagre grafen

#Lager fartsgrafen:
plt.figure(2)
plt.plot(t_liste, v_liste)
plt.grid()
plt.title("Fart")
plt.xlabel("$t$ / s")
plt.ylabel("$v$ / (m/s)")
plt.savefig("fart.png") # Lagrer graf, endre filnavn ved behov

#Lager akselerasjonsgrafen:
plt.figure(3)
plt.plot(t_liste, a_liste)
plt.grid()
plt.title("Akselerasjon")
plt.xlabel("$t$ / s")
plt.ylabel("$a$ / (m/s$^2$)")
plt.savefig("akselerasjon.png") # Lagrer graf, endre filnavn ved behov

plt.show() # Viser alle grafene


print(f"Partikkelen snur etter {t_liste[-1]:.2e}, i en avstand på {r_liste[-1]:.2e}")