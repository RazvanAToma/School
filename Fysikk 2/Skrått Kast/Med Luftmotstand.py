import matplotlib.pyplot as plt
import numpy as np

# startinformasjon:
m = 0.200 # kg
g = 9.81 # m/s^2
k = 0.02 # luftmotstandskoeffisient
v0 = 15 # m/s
x0 = 0 # m
y0 = 5 # m
alfa = 30 # grader
dt = 0.01 # sekunder

alfa = np.radians(alfa) # konverterer vinkel til radianer

# tomme arrays til å lagre data:
X = []
Y = []
Vx = []
Vy = []

# dekomponere startfarten:
vx = v0*np.cos(alfa)
vy = v0*np.sin(alfa)

# legg inn startposisjonen:
x = x0
y = y0


while y > 0: # lander når y = 0
    Fx = -k*np.abs(vx)*vx
    Fy = -g-k*np.abs(vy)*vy

    ax = Fx/m
    ay = Fy/m

    vx = vx + ax*dt
    vy = vy + ay*dt
    x = x + vx*dt
    y = y + vy*dt

    X.append(x)
    Y.append(y)
    Vx.append(vx)
    Vy.append(vy)
    
plt.grid()
plt.title("Posisjon")
plt.xlabel("$x$ / m")
plt.ylabel("$y$ / m")
plt.plot(X, Y)
plt.show()
