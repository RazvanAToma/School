U = 1.0
B = 1.5
R = 0.5
m = 0.010
L = 0.10

v = 0
s = 0
t = 0
dt = 0.00001


while v <= 1.0:
    a = (U*B*L-v*B*B*L*L) / (R*m)
    v += a * dt
    s += v * dt
    t += dt


print(f"Etter {round(t, 3)} sekunder har stangen beveget seg {round(s, 3)} meter")