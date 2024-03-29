import math

weight_matrix = [[math.inf, 4, 5, 7, 5],
                 [8, math.inf, 5, 6, 6],
                 [3, 5, math.inf, 9, 6],
                 [3, 5, 6, math.inf, 2],
                 [6, 2, 3, 8, math.inf]]

sum = 0
while len(weight_matrix) != 1:
    min_sum = 0 # сумма минимальных элементов строк и столбцов
    # сумма минимальных элементов строки
    for string in weight_matrix:
        min_weight = string[0]
        min_index = 0

        for weight in string:
            if weight < min_weight:
                min_weight = weight
                min_index = string.index(weight)
        # вычитание наименьшего значения
        for i in range(len(string)):
            string[i] -= min_weight

        min_sum += min_weight
    # сумма минимальных элементов столбца
    for i in range(len(weight_matrix)):
        min_weight = weight_matrix[0][0]
        min_index = 0
        for j in range(len(weight_matrix)):
            if weight_matrix[j][i] < min_weight:
                min_weight = weight_matrix[j][i]
                min_index = j
        # вычитание наименьшего значения
        for j in range(len(weight_matrix)):
            weight_matrix[j][i] -= min_weight
        
        min_sum += min_weight

    # нахождение нуля с макс степенью
    max_zero = 0
    index_i_zero = int
    index_j_zero = int
    for i in range(len(weight_matrix)):
        for j in range(len(weight_matrix)):
            if weight_matrix[i][j] == 0:
                min_string = math.inf
                min_column = math.inf
                for ii in weight_matrix[i][0:j] + weight_matrix[i][j+1:]:
                    min_string = min(min_string, ii)
                for g in range(len(weight_matrix)):
                    if g != i:
                        min_column = min(min_column, weight_matrix[g][j])

                if min_string + min_column > max_zero:
                    max_zero = min_string + min_column
                    index_i_zero = i
                    index_j_zero = j
    
    # удаление i строки и j столбца и изменение значения j i эл-та на inf
    weight_matrix[index_j_zero][index_i_zero] = math.inf
    weight_matrix.pop(index_i_zero)
    for i in range(len(weight_matrix)):
        weight_matrix[i].pop(index_j_zero)

    sum += min_sum
    
print(sum)
