#reb = [[2,'A','B'],[2,'A','C'],[2,'B','C'],[2,'B','E'],[2,'D','G'],[5,'C','E'],[5,'D','F'],[7,'A','E'],[9,'E','G'],[9,'B','D'],[10,'E','D'],[16,'D','H'],[17,'F','H'],[17,'G','H']]
#reb = [[14, '1', '5'],[14, '3', '5'],[14, '7', '8'],[15, '1', '2'],[15, '2', '5'],[16, '2', '4'],[18, '5', '9'],[18, '8', '9'],[19, '2', '3'],[20, '4', '8'],[23, '1', '4'],[23, '4', '7'],[24, '5', '6'],[25, '4', '5'],[26, '3', '6'],[27, '5', '8'],]

reb = []
inp = input()
while inp != '':
    reb.append(inp.split())
    inp = input()

for i in range(len(reb)-1):
    for j in range(i, len(reb)):
        if int(reb[i][0]) > int(reb[j][0]):
            c = reb[j]
            reb[j] = reb[i]
            reb[i] = c


versh_isp = []
s = 0
while reb:
    versh1 = None
    versh2 = None
    for i in range(len(versh_isp)):
        if reb[0][1] in versh_isp[i]:
            versh1 = i
        if reb[0][2] in versh_isp[i]:
            versh2 = i
    if  versh1 == None and versh2 != None:
        versh_isp[versh2] += reb[0][1]
        s += int(reb[0][0])
    elif versh2 == None and versh1 != None:
        versh_isp[versh1] += reb[0][2]
        s += int(reb[0][0])
    elif versh1 == None and versh2 == None:
        versh_isp.append(reb[0][1] + reb[0][2])
        s += int(reb[0][0])
    elif versh1 != None and versh2 != None and versh1 != versh2:
        versh_isp[versh1] += versh_isp[versh2]
        s += int(reb[0][0])
        versh_isp.pop(versh2)
    reb.pop(0)

print(s)
