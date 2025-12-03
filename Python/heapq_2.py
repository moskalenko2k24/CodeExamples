import heapq
lst = [6 ,4, -5, -12, 3, 4, 5, 100]
q = []
for i in lst: q.append((-i, i)) # -i is priority
for i in lst: print(i, end=" ") # 6 4 -5 -12 3 4 5 100
print()
heapq.heapify(q) # transofrm list into heap
for i in range(len(q)):
    print(heapq.heappop(q)[1], end=" ") # 100 6 5 4 4 3 -5 -12
