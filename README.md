# CLast

Данный проект создан как учебный и завершаюший основному блок

# Задание

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Примеры

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

# Описание работы консольного приложения

Приложение принимает строку от пользователя, разделение на отдельные элементы происходит через "пробел".
Если введена пустая строка, то основной метод main закроется, предварительно выведя сообщение "Вы не ввели даннные!!!".

После ввода корректной строки, она разделяется на массив строк. Элементы массива проверяются на количесво символов в строке и доваляются в резульрующий массив.

Максимальное количесво символов, определяется переменной lineLimiter(int). Значение по умолчанию, исходя из задачи, 3.

## Метод ConverStringToArray

Данный метод отвечает за понвертацию строки в массив строк.
Принимет на вход строку, выводит массив строк.

## Метод ArrayWhithElemLessThenLimiter

Данный метод отвечает за создание массива строк, который состоит из срок длинной не более значения параметра метода **maxElemLenhgt**.

Для определения длинны массива, который будет возвращаться, используется метод **CountArrayElemesWithLengthLessThanLimiter**.

## Метод CountArrayElemesWithLengthLessThanLimiter

Данный метод отвечает за пересчет количества элементов массива строк, которые имеют длинну не более значения параметра метода **maxElemLenhgt**.

## Метод PrintArray

Данный метьод отвечает за вывод в консоль массива.
Метод создает строку из элементов массива.
Если строка не пустая, то последняя запятая удаляется.
```C#
if (arrLine != "")
    {
        arrLine = arrLine.Remove(arrLine.Length - 1);
    }
```
