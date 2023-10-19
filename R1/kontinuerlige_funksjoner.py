from math import floor

svar = input("Oppgi et tall a:")
a = float(svar)

if floor(a) == a:
    print("Tallet", svar, "er et helt tall.")
    if floor(a/2) == a/2:
        print("Tallet", svar, "er et partall.")
    else:
        print(f"Tallet {svar} er et oddetall.")
else:
    print("Tallet er ikke et helt tall.")
