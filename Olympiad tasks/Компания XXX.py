f = open('D:/Company_XXX.txt')

persons = []  # список сотрудников

string = f.readline().split('\n')[0]
while string != 'END':
    persons.append(string)
    string = f.readline().split('\n')[0]

chief = f.readline().split('\n')[0]

for i in range(len(persons)):
    if chief in persons[i] and len(persons[i]) > len(chief):
        chief = persons[i]
        break

subordinates = [chief]
for sub in subordinates:
    for i in range(len(persons)//2):
        if persons[i * 2] in sub or sub in persons[i * 2]:
            subordinates.append(persons[i * 2 + 1])
            if len(sub) < len(persons[i * 2]):
                subordinates[subordinates.index(sub)] = persons[i * 2]
subordinates.pop(0)
subordinates.sort()


for sub in subordinates:
    if len(sub) == 4:
        print(sub + ' Unknown Name')
    else:
        print(sub)
