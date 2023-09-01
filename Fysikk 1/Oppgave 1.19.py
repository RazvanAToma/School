import numpy as np
import matplotlib.pyplot as plt

data = np.loadtxt("C:/Users/razva/OneDrive - Viken fylkeskommune/Backup/Dokumenter/GitHub/School/Fysikk 1/babymasser.txt")

antall = 0

# Antall babyer som ble veid
print(np.size(data))

# Største massen
print(np.max(data))

# Minste massen
print(np.min(data))

# Gjennomsnittsmassen
print(np.mean(data))

# Avvik
print((np.max(data)-np.min(data))/2)


plt.hist(data, 100)
plt.show()