# *Задача:* 

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание алгоритма решения:
Чтобы создать первоначальный массив пользователь вводит элементы массива через запятую.Принимая эти данные формируется массив myArray (с использованием метода GetArray). Затем вызывается метод OutArray, где входными данными является массив myArray, но чтобы сформировать новый массив, мы должны знать его размер (вызываем метод CountLessThan). Метод OutArray формирует новый массив согласно условиям задачи. Внутри цикла выполняется проверка условия (длина элемента массива <=3 ). Если элемент подходит под данное условие, то мы добавляем его в новый массив, используя при этом дополнительный счетчик.

## Блок-схема алгоритма:
Графическое представление метода OutArray находиться в папке Schemа.

##  Решение задачи на C#:
Программа, решающая поставленную задачу, находиться в папке TestTask. 


