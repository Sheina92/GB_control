# Итоговая контрольная работа по основному блоку

## Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*
+ [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
+ [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
+ [“Russia”, “Denmark”, “Kazan”] → []

## Описание решения
+ Создаем два массива: первоначальный и новый, 
+ Создаем цикл, который который будет перебирать элементы первоначального массива.
+ Внутри цикла проверяем длинну текущей строки. Если длинна меньше или равна 3 символам, то добавляем строку в новый массив.
+ После завершения цикла выводим новый массив строк на экран.
![Блок-схема](Screenshot_11.png)
