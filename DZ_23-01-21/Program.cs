using System;

namespace DZ_23_01_21
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Задание № 1.2");
			// Задание 1.2
			// 1) Дано два числа A и B (A<B) выведите суму всех чисел, расположенных между
			// данными числами на экран.
			// 2) Дано два числа A и B (A<B) выведите все нечетные значения, расположенные
			// между данными числами.
			double A, B;
			System.Console.WriteLine("Введите число A:");
			double.TryParse(Console.ReadLine(), out A);
			System.Console.WriteLine("Введите число B:");
			double.TryParse(Console.ReadLine(), out B);

			int sumOfEvens = 0;
			string allOdds = "";
			for (int i = (int)(A); i <= B; i++)
			{
				sumOfEvens += i;
				if (i % 2 == 1)
				{
					allOdds += i.ToString() + " ";
				}
			}
			Console.WriteLine($"Сумма целых чисел равна {sumOfEvens}");
			Console.WriteLine($"Все нечётные значения от {A} до {B}:\n{allOdds}");
			Console.WriteLine();

			Console.WriteLine("Задание № 1.3");
			// Задание 1.3
			// Используя циклы и метод:
			// Console.Write("*"), Console.Write(" "), Console.Write("\n") (для перехода на новую
			// строку).
			// - Прямоугольник
			// - Прямоугольный треугольник
			// - Равносторонний треугольник
			// - Ромб
			int n = 7, m = 25; //Размеры фигур
			Console.WriteLine("Прямоугольник");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					if ((i == 0 || i == n - 1) || (j == 0 || j == m - 1))
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			}
			Console.Write("\n");
			Console.WriteLine("Прямоугольный треугольник");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i * (m / n) + 0.5; j++)
				{
					if ((i == 0 || i == n - 1) || (j == 0 || j == i * (m / n)))
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			}
			Console.Write("\n");
			Console.WriteLine("Равносторонний треугольник");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n * 2; j++)
				{
					if ((i == n - 1) || (j == n - i - 1 || j == i + n))
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			}
			Console.Write("\n");
			Console.WriteLine("Ромб треугольник");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n * 2; j++)
				{
					if (j == n - i - 1 || j == i + n)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n * 2; j++)
				{
					if (j == i || j == 2 * n - i - 1)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			}
			Console.WriteLine();

			Console.WriteLine("Задание № 1.4");
			// Задание 1.4
			// Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада
			// увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P <
			// 25). По данному P определить, через сколько месяцев размер вклада превысит 1100
			// руб., и вывести найденное количество месяцев K (целое число) и итоговый размер
			// вклада S (вещественное число).
			double P, sum = 1000, targetSum = 1100;
			int k = 0;
			System.Console.WriteLine("Введите вещественное число P");
			double.TryParse(Console.ReadLine(), out P);
			while (sum <= targetSum)
			{
				k++;
				sum += sum * P / 100.0;
			}
			Console.WriteLine($"Количество месяцев за которое размер вклада превысит 1100 руб: {k}. Итоговый размер {sum}");
			Console.WriteLine();

			Console.WriteLine("Задание № 2.2");
			// Задание 2.2
			// Создать массив размера N элементов, заполнить его произвольными целыми
			// значениями (размер массива задает пользователь).
			// Вывести на экран:
			// • Наибольшее значение массива;
			// • Наименьшее значение массива;
			// • Общую сумму всех элементов;
			// • Среднее арифметическое всех элементов;
			// • Вывести все нечетные значения;

			int arrSize, minVal = 0, maxVal = 0, sumOfArr = 0, averageVal;
			string oddsStr = "";
			Console.WriteLine("Введите размер массива ");
			int.TryParse(Console.ReadLine(), out arrSize);
			int[] arr = new int[arrSize];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = new Random().Next(0, 100);
				if (i == 0)
				{
					minVal = maxVal = arr[i];
				}
				else
				{
					maxVal = Math.Max(maxVal, arr[i]);
					minVal = Math.Min(minVal, arr[i]);
				}

				sumOfArr += arr[i];
				if (arr[i] % 2 == 1)
				{
					oddsStr += arr[i] + " ";
				}
			}
			foreach (var val in arr)
			{
				Console.Write(val + " ");
			}
			averageVal = sumOfArr / arr.Length;
			Console.WriteLine();
			Console.WriteLine($"Наибольшее значение массива: {maxVal}");
			Console.WriteLine($"Наименьшее значение массива: {minVal}");
			Console.WriteLine($"Сумма всех элементов массива: {sumOfArr}");
			Console.WriteLine($"Среднее арифметическое всех элементов: {averageVal}");
			Console.WriteLine($"Среднее арифметическое всех элементов: {oddsStr}");
			Console.WriteLine();

			Console.WriteLine("Задание № 2.3");
			// Задание 2.3
			// Создайте проект, который принимает в качестве аргумента массив целочисленных
			// элементов и возвращает инвертированный массив (элементы массива в обратном
			// порядке).
			// P.S. массив взят из предыдущего задания
			int temp;
			Console.WriteLine("Исходный массив:");
			foreach (var val in arr)
			{
				Console.Write(val + " ");
			}
			for (int i = 0; i < arr.Length / 2; i++)
			{

				temp = arr[i];
				arr[i] = arr[(arr.Length - 1) - i];
				arr[(arr.Length - 1) - i] = temp;
			}
			Console.WriteLine();
			Console.WriteLine("Инвертированный массив:");
			foreach (var val in arr)
			{
				Console.Write(val + " ");
			}
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Задание № 2.4");
			// Задание 2.4
			// Создать массив размера N элементов, заполнить его произвольными целыми
			// значениями (размер массива задает пользователь).
			// 1. Выведите на экран.
			// 2. Создайте целочисленную переменную count (задает пользователь), index
			// (задает пользователь).
			// 3. Создайте новый массив верните часть полученного в качестве аргумента
			// массива начиная с позиции, указанной в аргументе index, размерностью,
			// которая соответствует значению аргумента count.
			// 4. Если аргумент count содержит значение больше, чем количество элементов,
			// которые входят в выбираемую часть исходного массива (от указанного индекса
			// index, до индекса последнего элемента), то при формировании нового массива
			// размерностью в count, заполните единицами те элементы, которые не были
			// скопированы из исходного массива.
			Console.WriteLine("Введите размер массива ");
			int.TryParse(Console.ReadLine(), out arrSize);
			int[] array = new int[arrSize];
			Console.WriteLine("Элементы массива");
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new Random().Next(0, 100);
				Console.Write(array[i] + " ");
			}
			Console.WriteLine();
			int count, index;
			Console.WriteLine("Введите значение count ");
			int.TryParse(Console.ReadLine(), out count);
			Console.WriteLine("Введите значение index ");
			int.TryParse(Console.ReadLine(), out index);
			int[] newArray = new int[count];
			for (int i = 0; i < count; i++)
			{
				if (i+index < array.Length)
				{
					newArray[i] = array[index + i];
				}
				else
				{
					newArray[i] = 1;
				}
			}
			Console.WriteLine("Вырезанный массив массив:");
			foreach (var val in newArray)
			{
				Console.Write(val + " ");
			}
			Console.WriteLine();
		}
	}
}
