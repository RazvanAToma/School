import numpy as np
import matplotlib.pyplot as plt

data = np.loadtxt("C:/Users/razva/OneDrive - Viken fylkeskommune/Backup/Dokumenter/GitHub/School/Fysikk 1/pendel.txt")

utslag = data[:,1]
tid = data[:,0]

plt.plot(tid, utslag)
plt.ylabel("Utslag")
plt.xlabel("Tid")
plt.grid(1)
plt.title("Pendel")
plt.show()