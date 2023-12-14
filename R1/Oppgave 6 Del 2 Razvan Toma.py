
def f(x): # Funksjon
    return x**2 - 3*x + 5

x = 0 # x defineres
dx = 0.1 # dx defineres

while x < 3: # Så lenge x er mindre enn 3 så kjører koden under:
    print(f"x = {x:.1f} og f'({x:.1f}) er tilnærmet lik {(f(x+dx)-f(x))/dx:.2f}") # Regner ut f'(x) ved bruk av definisjonen
    x += dx # Øker x med dx (0.1)

'''
Dette programmet har en funksjon x^2-3x+5
Programmet bruker en while løkke for å regne ut f'(x) ved bruk av definisjonen så lenge x er mindre enn 3
Programmet printer først ut x-verdien den bruker, og så hva f'(x) er tilnærmet lik. 
'''