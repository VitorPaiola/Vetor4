using System.Globalization;

int N = int.Parse(Console.ReadLine());

double[] nums = new double[N];

string[] vet = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++) {
    nums[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
}

double soma = 0.0;
for (int i = 0; i < N; i++) {
    soma += nums[i];
}

double media = soma / N;
Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

for (int i = 0; i < N; i++) {
    if (nums[i] < media) {
        Console.WriteLine(nums[i].ToString("F1", CultureInfo.InvariantCulture));
    }
}