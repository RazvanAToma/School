
a1 = float(input("Skriv inn ledd 1: "))
a2 = float(input("Skriv inn ledd 2: "))
a3 = float(input("Skriv inn ledd 3: "))

if a2 - a1 == a3 - a2:
    print(f"Følgen er aritmetisk, og differansen er d={a2 - a1}")
    user_input = int(input("Hvilken ledd ønsker du å regne ut? "))

    print(f"Ledd nummer {user_input} er {a1 + (user_input - 1) * (a2-a1)}")
elif a2/a1 == a3/a2:
    print(f"Følgen er geometrisk, og k = {a2/a1}")
else:
    print("Følgen er verken aritmetisk eller geometrisk")

