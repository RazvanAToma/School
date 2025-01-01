from math import sqrt
 
def f(x):
  return x**2-2*x
 
a = float(input("Nedre grense?"))
b = float(input("Øvre grense?"))
n = int(input("Antall rektangler?"))
 
delta_x = (b-a)/n
sum = 0
 
for i in range(1, n+1):
  sum += f(a+(i-1)*delta_x)*delta_x
 
print(f"{n} rektangler gir tilnærmingsverdien {sum:.3f}. med Venstremetoden")


sum = 0
 
for i in range(1, n+1):
  sum += f(a+(i)*delta_x)*delta_x
 
print(f"{n} rektangler gir tilnærmingsverdien {sum:.3f}. med Høyremetoden")


sum = 0
 
for i in range(1, n+1):
  sum += f(a+(i-1/2)*delta_x)*delta_x
 
print(f"{n} rektangler gir tilnærmingsverdien {sum:.3f}. med Midtmetoden")