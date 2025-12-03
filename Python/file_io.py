fin = open("input.txt","r")
fout = open("output.txt","w")
n = int(fin.readline())
a = []
for i in range(n):
    a.append(list(map(int, fin.readline().split())))
for i in range(n): a[i][i] = 0
for i in range(n):
    for j in range(n): print(a[i][j], end=" ", file=fout)
    print(file=fout)
fin.close()
fout.close()