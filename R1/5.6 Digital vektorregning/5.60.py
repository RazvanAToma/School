from numpy import array

x_u = float(input("X-koorinaten til u:"))
y_u = float(input("Y-koorinaten til u:"))

x_v = float(input("X-koorinaten til v:"))
y_v = float(input("Y-koorinaten til v:"))

u = array([x_u, y_u])
v = array([x_v, y_v])

print("u + v =", u + v)
print("u - v =", u - v)
print("3u + 2v =", 3*u + 2*v)