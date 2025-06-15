import matplotlib.pyplot as plt
import numpy as np

# startinformasjon:
m = 0.200 # kg
g = 9.81 # m/s^2
v0 = 30 # m/s
x0 = 0 # m
y0 = 0.01 # m
alfa = 30 # grader
dt = 0.01 # sekunder

alfa = np.radians(alfa) # konverterer vinkel til radianer

# tomme arrays til å lagre data:
X = []
Y = []
Vx = [] # hvis du ikke trenger farten trenger du ikke
Vy = [] # disse to linjene

# dekomponere startfarten:
vx = v0*np.cos(alfa)
vy = v0*np.sin(alfa)

# legg inn startposisjonen:
x = x0
y = y0


while y > 0: # lander når y = 0
    ay = -g
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
