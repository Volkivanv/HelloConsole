
//int[] inArray = new int[N]
int maximum(int[] inArray){
    int n = inArray.Length;
    int max = inArray[0];
    for(int i = 1; i < n; i++){
        if (inArray[i] > max){
            max = inArray[i];
        }
    }
    return max;
}

Console.WriteLine("Input length of array");
int N = int.Parse(Console.ReadLine());

int[] Numbers = new int[N];

for(int i = 0; i < N; i++){
    Numbers[i] = new Random().Next(0,30);
}
for(int i = 0; i < N; i++){
    Console.Write(Numbers[i]+" ");
}
Console.WriteLine("");
Console.WriteLine(maximum(Numbers));

