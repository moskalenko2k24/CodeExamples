from math import sqrt 

def find_first_div(num):
    for i in range(2, int(sqrt(num)) + 1):
        if num % i == 0: return i
    return num

num = int(input())
while num != 1:
    div = find_first_div(num)
    num = num // div
    if num > 1: print(div, "*", end="", sep="")
    else: print(div)