import numpy as np
import matplotlib.pyplot as plt

#Definerer konstanter.
m = 0.40 #kg
R = 2.0E-3 #ohm
B = 1.5 #T
l = 0.08 #m
#Definerer en liste med n tidsverdier fra 0 til T. Tidssteget kaller vi dt.
n = 1000
T = 0.20 #s
t = np.linspace(0,T,n)
dt = t[1]-t[0]

#Lager lister for å lagre verdier.
s = np.zeros(n)
v = np.zeros(n)
a = np.zeros(n)

#Definerer startverdi for farten.
v[0] = 3.0 #m/s


#Definerer en funksjon for kraften som avhenger av posisjonen og farten til lederen.
def F(s,v):
  #Før magnetfeltet.
  if s < 0.07:
    return 0
  #På vei inn i magnetfeltet.
  elif s < 0.15:
    return -B**2*l**2*v/R
  #Hele lederen er i magnetfeltet.
  elif s < 0.27:
    return 0
  #På vei ut av magnetfeltet.
  elif s < 0.35:
    return -B**2*l**2*v/R
  #Etter magnetfeltet.
  else:
    return 0

#Beregner farten med eulermetoden. Akselerasjonen finner vi med Newtons 2. lov for hvert lille tidssteg.
for i in range(n-1):
  a[i] = F(s[i],v[i])/m
  v[i+1] = v[i] + a[i]*dt
  s[i+1] = s[i] + v[i]*dt

#Lager akselerasjonsgrafen.
plt.figure(1)
plt.plot(t,a)
plt.xlabel("$t$/s")
plt.ylabel("$a$/(m/s$^2$)")
plt.title("Akselerasjon")
plt.grid()

#Tegner fartsgrafen.
plt.figure(2)
plt.plot(t,v)
plt.xlabel("$t$/s")
plt.ylabel("$v$/(m/s)")
plt.grid()
plt.title("Fart")
plt.show()
