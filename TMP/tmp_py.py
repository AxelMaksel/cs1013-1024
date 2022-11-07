# a = 17
# b = 10
# print(a/b)
# print(a//b)
# print(a % b)
# print(a**b)

# if (a//b) > 0:
#     print(">0")

# print(f"000 {a} {b}")


# import numpy as np

# a = np.array([185,175,170,169,171,172,175,157,170,172,167,173,168,167,166,

#               167,169,172,177,178,165,161,179,159,164,178,172,170,173,171])
# m = np.median(a)
# print(m)


from scipy import stats
import numpy as np

a = np.array([1, 5, 2, 7, 1, 9, 3, 8, 5, 9])
print('# как искать медиану')
m = stats.mode(a)
print(m)
# как искать моду
m = np.median(a)
print(m)
# как искать среднее значение
m = np.mean(a)
print(m)
q = 0
for i in a:
    q += ((m-i)**2)
print((q/(len(a)-1))**0.5)
