lst = [3, 4, 1, 5, 6]
print(lst) # [3, 4, 1, 5, 6]
lst.insert(0, -1)
print(lst) # [-1, 3, 4, 1, 5, 6]
lst.pop(len(lst) - 2)
print(lst) # [-1, 3, 4, 1, 6]
lst.sort(key=lambda x:-x)
print(lst) # [6, 4, 3, 1, -1]
for i in range(5): lst.append(i)
print(lst) # [6, 4, 3, 1, -1, 0, 1, 2, 3, 4]
lst.clear()
print(lst) # []