
select = input("Vil du omregne fra m/s til kph? (Y/N)").upper()

if select == "Y":
    def to_kph(speed_ms):
        factor = 3.6
        speed_kph = speed_ms * factor
        return speed_kph
    
    ms = float(input("Hvor mange meter pr sekund vil du omgjøre?\n"))

    print(f"{ms} meter per sekund er {to_kph(ms)} kilometer i timen")

elif select == "N":
    def to_ms(speed_kph):
        factor = 3.6
        speed_ms = speed_kph / factor
        return speed_ms

    kph = float(input("Hvor mange kilometer i timen vil du omgjøre?\n"))

    print(f"{kph} kilometer i timen er {to_ms(kph)} meter pr sekund")

