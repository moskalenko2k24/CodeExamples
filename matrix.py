import random

def create_matrix(n, m):
    # wrong way: rows will be same
    # return [[0] * m] * n
    return [[0] * m for _ in range(n)]

def print_matrix(matrix):
    for row in matrix:
        for col in row:
            print('%2d ' % col, end='')
        print()

def fill_random(matrix):
    n = len(matrix)
    m = len(matrix[0])
    for i in range(n):
        for j in range(m):
            matrix[i][j] = random.randint(0, 99)

a = create_matrix(3, 4)
fill_random(a)
a[0][0] = 1
print_matrix(a)
