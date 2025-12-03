#Demonstration of set
a = set()
for i in range(4): a.add(i + 1) 
b = set()
for i in range(3, 7): b.add(i)
print("a:", a) # {1, 2, 3, 4}
print("b:", b) # {3, 4, 5, 6}
print("a - b:", a - b) # {1, 2}
print("a | b", a | b)  # {1, 2, 3, 4, 5, 6}
print("a & b:", a & b) # {3, 4}
print("a ^ b:", a ^ b) # {1, 2, 5, 6}
a -= {2, 3}
print("a - {2, 3}:", a) # {1, 4}