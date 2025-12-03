lst = [4, 1, 2, 3, 14, -100, 23, 100]
lst.sort()
print(lst) # [-100, 1, 2, 3, 4, 14, 23, 100]
lst.sort(key=lambda x:-x)
print(lst) # [100, 23, 14, 4, 3, 2, 1, -100]