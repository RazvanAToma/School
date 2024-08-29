
antall_ledd = int(input("Antall ledd? "))

sum = 0

for n in range(1, antall_ledd + 1):
    sum += 3*n - 2

print(f"Summen av {antall_ledd} ledd er {sum}")