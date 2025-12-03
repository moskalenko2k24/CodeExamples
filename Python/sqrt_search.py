x=int(input())
l = 0.0
r = float(x)
while r - l > 0.00000001:
    m = (l + r) / 2
    if m * m > x: r = m
    else: l = m
print(r)
