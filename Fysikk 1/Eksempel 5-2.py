import numpy as np
import matplotlib.pyplot as plt

#Henter dataene fra fila.
data = np.loadtxt("C:/Users/razva/OneDrive - Viken fylkeskommune/Backup/Dokumenter/GitHub/School/Fysikk 1/kollisjon-vegg.txt")
t = data[:,0]
v = data[:,1]

#Definerer massen og regner ut bevegelsesmengden.
m = 0.7703 #kg
p = m * v

#Lager bevegelsesmengde-grafen.
plt.figure(1)
plt.plot(t,p,"ko-")
plt.grid()
plt.title("Bevegelsesmengde")
plt.xlabel("$t$ / s")
plt.ylabel("$p$ / (kg m/s)")
#plt.show()

#Regner ut gjennomsnittsverdien før og etter støtet.
p_før = np.mean(p[0:15])
p_etter = np.mean(p[-17:])

#Lager lister til å tegne grafen med.
p_før_liste = np.zeros(15) + p_før
p_etter_liste = np.zeros(17) + p_etter

#Legger inn gjennomsnittsverdiene i grafen.
plt.figure(1)
plt.plot(t[0:15], p_før_liste, "r")
plt.plot(t[-17:], p_etter_liste, "g")
plt.show()