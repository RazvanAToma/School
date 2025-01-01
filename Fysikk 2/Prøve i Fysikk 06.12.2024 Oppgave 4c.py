import numpy as np

t = 0                     # starttid
dt = 0.01                 # tidssteg
g = 9.81                  # gravitasjonskonstanten
k = 30                    # friksjonskonstanten
m = 75                    # massen til personen i kg
s = 0                     # startposisjon
v = 0                     # startfart
vinkel = np.radians(30)   # 30 grader, omgjort til radianer
G_x = m*g * np.sin(vinkel)


while s < 20:             # løkke som kjører til posisjonen passerer 20 m
	F_r = k * v
	F_sum = G_x - F_r

	a = F_sum / m
	v += a * dt
	s += v * dt
	t += dt
  
print(f"{round(v, 2)} m/s, {round(t, 2)} s")