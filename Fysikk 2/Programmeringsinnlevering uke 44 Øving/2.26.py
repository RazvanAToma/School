
import numpy as np

m = 800     # kg
g = 9.81    # m/s^2
G = m*g     # N
vinkel = 70 # Grader
maksgrense = 4000; # N

S = G/(2*np.sin(np.radians(vinkel)))

if S > maksgrense:
    print("Stroppene tåler ikke vekten")
else:
    print(f"Snordraget er {round(S, 2)} N.")