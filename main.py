def menu():
    while True:
        print('Меню:')
        print('1 - перевести градусы Цельсия в градусы Фаренгейта')
        print('2 - перевести градусы Фаренгейта в градусы Цельсия')
        print('3 - выход из программы')
        x = input('Ваш выбор: ')
        if x == '1' or x == '2' or x == '3':
            return x
        else:
            print('Введите 1, 2 или 3')

def onC2F_chose():
    while True:
        try:
            c = float(input('Введите градусы Цельсия: '))
            break
        except ValueError:
            print('Вы ввели не число!')
    f = round(c * 9 / 5 + 32, 1)
    print(f'это {f} градусов Фаренгейта')

def onF2C_chose():
    while True:
        try:
            f = float(input('Введите градусы Фаренгейта: '))
            break
        except ValueError:
            print('Вы ввели не число!')
    c = round((f - 32) * 5 /9, 1)
    print(f'это {c} градусов Цельсия')

while True:
    chose = menu()
    if chose == '3':
        exit()
    elif chose == '1':
        onC2F_chose()
    elif chose == '2':
        onF2C_chose()

