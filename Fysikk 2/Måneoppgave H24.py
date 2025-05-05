r = 1738E3 + 9E5 # m
v = 1.44E3 # m/s
t = 0   # s
dt = 0.001
gamma = 6.67E-11
M = 7.35E22

while r > 1738E3:
    a = gamma * M / r**2
    v += a * dt
    r -= v * dt
    t += dt

print(t)