
antall_ledd = int(input("Antall ledd? "))

sum = 0

for n in range(1, antall_ledd + 1):
    ledd = 580 + (n-1) * 30
    sum += ledd
    print(f"Ledd nr. {n}: {ledd}")

print(sum)