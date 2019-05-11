int[] num = {1,1,2}

foreach (var n in num) {
Console.WriteLine(n);
}

for(int i =0; i < arr.length; i++) {
arr{i] = i+1;
}

int sum = 0;

forEach(var n in arr) {
sum += n;
}

int[,] chessBoard = new int[8,8] // multi dimensional array

int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} };

// 3 rows, 2 columns
// row = first element of array [a,b]
// column = 2nd element [a,b]

// [2,0] = 4 => 3rd row, 0th column index
// [1,1] = 6 => 2nd row, 1th column index

// print everything => k = row, j = column
for (int k = 0; k < 3; k++) {
  for (int j = 0; j < 2; j++) {
    Console.Write(someNums[k, j]+" ");
  }
  Console.WriteLine();
}

// [] = one dimensional array
// [,] = two dimensional
// [,,] = three dimensional and so on

// Array properties

// array.Length = length of the array
// array.Rank = dimensions (one dimensional, two, more)

// Array methods

// arr.Max() => largest value in array
// arr.Min() => smallest value
// arr.Sum() => sum of all elements in array