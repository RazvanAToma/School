m = 0.25
M = 2.0
g = 9.81
l = 0.20
B = 0.30
R = 0.040

v = 1.87
s = 0
t = 0
dt = 0.0001

while s < 0.2:
    a_G_l = (M * g)/(m+M)
    a_F_m = ((B**2*l**2*v)/(R))/(m+M)
    a = a_G_l - a_F_m
    v += a * dt
    s += v * dt
    t += dt

print(f"{t:.2f} sekunder")