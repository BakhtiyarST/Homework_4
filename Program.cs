namespace Lesson4
{
	internal class Program
	{
		public static void Task1()
		{
			// list items with no duplicates as in the original list
			List<int> ints = new List<int>() { 0, 1, 1, -1, 101, 102, 101, 11, 1111, 11 };
			List<int> ints2 = new List<int>();

			foreach (var item in ints)
			{
				if (!ints2.Any(i => i == item))
					ints2.Add(item);
			}
			foreach(int item in ints2)
				Console.WriteLine(item);
		}

		public static void Task2()
		{
			// list items according to their frequency in the original list in an ascending order
			List<int> ints = new List<int>() { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };
			Dictionary<int,int> dict = new Dictionary<int,int>();

			foreach(int i in ints)
			{
				if (dict.ContainsKey(i))
					dict[i]++;
				else
					dict.Add(i, 0);
			}

			PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
			foreach(var item in dict)
				pq.Enqueue(item.Key,item.Value);

			while(pq.Count > 0)
				Console.WriteLine(pq.Dequeue());
		}

		public static void Task3()
		{
			// list items according to their frequency in the original list in a descending order
			List<int> ints = new List<int>() { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };
			Dictionary<int, int> dict = new Dictionary<int, int>();

			foreach (int i in ints)
			{
				if (dict.ContainsKey(i))
					dict[i]++;
				else
					dict.Add(i, 0);
			}

			PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
			foreach (var item in dict)
				pq.Enqueue(item.Key, item.Value * -1);

			while (pq.Count > 0)
				Console.WriteLine(pq.Dequeue());
		}

		public static void Task4()
		{
			List<User> users = new List<User>();

			users.Add(new User() { FirstName = "Aibek", LastName = "Kaiyrbekov", Age = 45 });
			users.Add(new User() { FirstName = "Berik", LastName = "Aryngaziyev", Age = 46 });
			users.Add(new User() { FirstName = "Madiyar", LastName = "Ospanov", Age = 47 });
			users.Add(new User() { FirstName = "Kanat", LastName = "Kaiyrbekov", Age = 45 });
			users.Add(new User() { FirstName = "Tanatar", LastName = "Sklyar", Age = 44 });
			users.Add(new User() { FirstName = "Berik", LastName = "Talaspayev", Age = 46 });
			users.Add(new User() { FirstName = "Berik", LastName = "Orhanov", Age = 43 });

			var firstName = users.GroupBy(u => u.FirstName).OrderByDescending(g => g.Count()).First().Key;
      Console.WriteLine(firstName);

			var age = users.GroupBy(u => u.Age).OrderByDescending(g => g.Count()).First().Key;
			Console.WriteLine(age);
			
			var lastName = users.GroupBy(u => u.LastName).OrderByDescending(g => g.Count()).First().Key;
			Console.WriteLine(lastName);

		}

		public static void Task5()
		{
			List<string> strList=new List<string>();

			strList.Add("Vlad");
			strList.Add("Gabil");
			strList.Add("Aleksei");
			strList.Add("Aleksandr");
			strList.Add("Dariya");

			string str = "al";
			var result = strList.Where(s => s.ToUpper().Contains(str.ToUpper())).Select(n => n.ToUpper());
      Console.WriteLine(string.Join(" ",result));

		}

		public static void HomeWork()
		{
			bool flagFound = false;
			int targetValue, tmpValue;
			int[] arr = { 1, 2, 3, 4, 5, 6, 10, 11, 15, 16, 17, 20, 4, 4, 3, 2, 5, 1, 45};

			Console.WriteLine("Enter the target value");
			string? str = Console.ReadLine();
			targetValue=int.Parse(str);

			for (int i=0;i<arr.Length; i++)
			{
				if (flagFound)
					break;
				tmpValue= targetValue - arr[i];
				var s = new HashSet<int>();
				foreach(var item in arr)
				{
					var x = tmpValue - item;
					if (s.Contains(x))
					{
						Console.WriteLine($"Value1: {arr[i]} + Value2: {x} + Value3: {item}");
						flagFound = true;
						break;
					}
					else
						s.Add(item);
				}
			}
			if (!flagFound)
				Console.WriteLine("No solution.");
		}

		static void Main(string[] args)
		{
			// Task1();
			// Task2();
			// Task3();
			// Task4();
			// Task5();
			HomeWork();

		}
	}
}
