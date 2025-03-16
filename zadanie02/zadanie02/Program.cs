// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//this is the 1st change to the project
//this is the 2nd change to the project
//this is the 3rd and last change to the project

int getMax(int[] ints) {
    int max = int.MinValue;
    foreach (int i in ints) {
        if (i > max) max = i; 
    }
    return max;
}

int[] arr = {1, 2, 4, 3,};
Console.WriteLine(getMax(arr));