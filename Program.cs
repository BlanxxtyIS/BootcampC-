double[] temperature = new double[10]; //Фиксированный размер

Random random = new Random();

for (int i = 0; i < temperature.Length; i++) {
    temperature[i] = random.NextDouble() * 40;
    Console.WriteLine(temperature[i]);
}


List<double> names = []; //Обертка над массивом. Динамический массив.
names.Add(9);
names.Add(9);
names.Add(9);
names.Add(9);
for (int i = 0; i < names.Count; i++) {
    Console.WriteLine(names[i]);
}
Console.WriteLine(System.Math.Abs(10));