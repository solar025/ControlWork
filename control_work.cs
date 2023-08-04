// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

﻿Console.WriteLine("Введите количество элементов массива: ");
int s  = int.Parse(Console.ReadLine());

string[] array1 = new string[s];

for (int i = 0; i < s; i++){
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
	array1[i] = result;  
}

int count = 0;
int maxsize = 3;

for (int i = 0; i < array1.Length; i++){
	if(array1[i].Length <= maxsize){
		count++;
	}   
}