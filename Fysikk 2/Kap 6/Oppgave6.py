import numpy as np
import matplotlib.pyplot as plt

m1 = 0.0020
k = 8.99E9
r = 0.50
q = 1.6E-8
v0 = -0.10

dt = 0.015
n = 1001

s = np.zeros(n)
v = np.zeros(n)
a = np.zeros(n)
t = np.zeros(n)

s[0] = r
v[0] = v0
t[0] = 0

for i in range(n-1):
    F = k*q*q / (s[i]**2)
    a[i] = F/m1
    v[i+1] = v[i] + a[i]*dt
    s[i+1] = s[i] + v[i]*dt
    t[i+1] = t[i] + dt
    
plt.plot(t, v)
plt.ylabel("Fart (m/s)")
plt.xlabel("Tid (s)")
plt.show()


