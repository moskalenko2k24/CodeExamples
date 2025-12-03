import heapq

lst = [6, 4, -5, -12, 3, 4, 5, 100]
for i in lst: print(i, end=" ") # 6 4 -5 -12 3 4 5 100
print()
heapq.heapify(lst) # transofrm list into heap
for i in range(len(lst)):
    print(heapq.heappop(lst), end=" ") # -12 -5 3 4 4 5 6 100
