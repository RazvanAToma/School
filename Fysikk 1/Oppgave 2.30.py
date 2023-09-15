s0 = float(input("Skriv inn startposijon i m: "))

v0 = float(input("Skriv inn startfart i m/s: "))

v = float(input("Skriv inn sluttfart i m/s: "))

t = float(input("Skriv inn tid i s: "))

a = (v-v0)/t

print(f"Akselerasjonen er {a} m/s^2")

s = 1/2*a*t*t+v0*t+s0

print(f"Posisjonen er {s} m")