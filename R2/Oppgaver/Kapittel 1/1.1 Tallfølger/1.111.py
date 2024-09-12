
verdier = [4]
print(verdier[0])

n = 1
total_sum = 4

while n < 8:
    ny_verdi = 3*verdier[-1]-2
    total_sum += ny_verdi

    verdier.append(ny_verdi)
    n += 1

    print(ny_verdi)

print(total_sum)