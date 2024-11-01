# importerer bilbliteker
import numpy as np
import matplotlib.pyplot as plt

# Definerer konstanter:
m = 0.050                   # kg
g = 9.81                    # m/s^2
k = 0.02                    # luftmotstandskoeffisient
v0 = 40                     # m/s
x0 = 0                      # m
y0 = 0.01                   # m
alfa = 30                   # grader
dt = 0.001                  # sekunder
w = 0                       # m/s vindhastighet
alfa = np.radians(alfa)     # radianer, konverterer vinkel til radianer


def test():
    # Arrays for å lagre data:
    X = []
    Y = []


    # Dekomponerer startfarten:
    vx = v0*np.cos(alfa)    # m/s i x retning
    vy = v0*np.sin(alfa)    # m/s i y retning

    # Startposisjon:
    x = x0
    y = y0

    while y > 0: # Golfballen lander når y = 0
        # Hvis vindhastighet er 0 så er det ingen vindmotstand
        if w > 0:
            Lx = k * abs((vx + w)) * (vx + w)
        else:
            Lx = k*np.abs(vx)*vx

        Fx = -Lx # Regner ut kreftene i x retning, i dette tilfellet bare luftmotstand og vindmotstand
        Fy = -m*g-k*np.abs(vy)*vy  # Regner ut kreftene i y retning, i dette tilfellet bare negativ gravitasjonskraft og luftmotstand

        ax = Fx/m                   # Bruker Newtons andre lov til å regne akselerasjon i x retning
        ay = Fy/m                   # Bruker Newtons andre lov til å regne akselerasjon i y retning

        vx += ax*dt                 # Fart i x retning ved å ta "areal under akselerasjons-graf"
        vy += ay*dt                 # Fart i y retning ved å ta "areal under akselerasjons-graf"
        x += vx*dt                  # Posisjon i x retning ved å ta "areal under farts-graf"
        y += vy*dt                  # Posisjon i y retning ved å ta "areal under farts-graf"

        X.append(x)                 # Legger til x-posisjon i lista med x-verdier
        Y.append(y)                 # Legger til y-posisjon i lista med y-verdier

    plt.figure(1)

    # Switch for legend
    match w:
        case 0:
            plt.plot(X, Y, label="Med luftmutstand, uten vind")
        case 1:
            plt.plot(X, Y, label="Med luftmutstand, 1 m/s motvind")
        case 2:
            plt.plot(X, Y, label="Med luftmutstand, 2 m/s motvind")
        case 3:
            plt.plot(X, Y, label="Med luftmutstand, 3 m/s motvind")
        case 4:
            plt.plot(X, Y, label="Med luftmutstand, 4 m/s motvind")
        case 5:
            plt.plot(X, Y, label="Med luftmutstand, 5 m/s motvind")

while w != 6:
    test()
    w += 1

# Tegne graf
plt.title("Posisjon")
plt.xlabel("$x$ / m")
plt.ylabel("$y$ / m")
plt.legend(loc="upper right")
plt.grid()
plt.show()