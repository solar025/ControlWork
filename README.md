Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-|”] → [“2”, “:-|”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Пояснение решения:
1.	Создание команды для ручного ввода количества элементов массива s (size).
2.	Далее заполняется массив с клавиатуры.
3.	Создаем массив array1 размером s (size).
4.	Задаем переменную i (индекс элемента).
5.	Вводим переменную count (счетчик элементов, которые подойдут под наше условие).
6.	Задаём переменную maxsize. По условию maxsize = 3. Сюда войдут элементы с размером не более трёх символов. 
7.	Вводим элементы массива начиная с первого array1[0], до тех пор, пока индекс [i] меньше длины массива size, прибавляя по одному.
8.	Каждый элемент массива проверяем по условию: длинна элемента array1[i] <= maxsize. Если условие соблюдено, увеличиваем count на один. Если нет - переходим к проверке следующего элемента массива array1[i+1].
9.	Заполняем новый массив array2 в пределах цикла. Для этого повторно проводим проверку каждого элемента массива, чтобы длина элемента array1[i] была <= maxsize. Если условие соблюдено, элементу array2[j] присваиваем соответствующее значение элемента array1[i]. Записываем его в массив array2. Если нет, переходим к проверке следующего элемента array1[i+1].
10.	Выводим полученный массив array2 на экран.
