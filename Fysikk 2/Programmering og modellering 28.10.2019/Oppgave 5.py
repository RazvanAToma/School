from math import *

vectorLength = 5
angle = 30

def xComponent(l, v):
    return round(l * cos(v * (pi / 180)), 2)

def yComponent(l, v):
    return round(l * sin(v * (pi / 180)), 2)


print(f"x: {xComponent(vectorLength, angle)} y: {yComponent(vectorLength, angle)}")