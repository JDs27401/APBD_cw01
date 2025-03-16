// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//this is the 1st change to the project
//this is the 2nd change to the project
//this is the 3rd and last change to the project

double getAvg(int[] ints) {
    int sum = 0;
    foreach (int i in ints) {
        sum += i;
    }
    double avg = sum / ints.Length;
    Console.WriteLine(avg);
    return avg;
}

int[] arr = {1, 2, 3,};

Console.WriteLine(getAvg(arr));