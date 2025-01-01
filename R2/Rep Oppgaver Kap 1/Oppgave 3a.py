
antall_ledd = int(input("Antall ledd? "))

for n in range(1, antall_ledd + 1):
    ledd = 580 + (n-1) * 30
    print(f"Ledd nr. {n}: {ledd}")

