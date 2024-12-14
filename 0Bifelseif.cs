//WAP in C# that prints the number from 1 to N. However, for multiples of 3, print "Fizz" instead of the number,
//and for multiples of 5, print "Buzz". For numbers that multiples of 3 and 5, print "FizzBuzz"

using System;
Console.WriteLine("Enter Your Number:");
int input = Convert.ToInt32(Console.ReadLine());

for ( int i = 1; i <= input; i++ ){

    if ( (i % 3 == 0) && (i % 5 == 0)){
        Console.WriteLine("FizzBuzz");
    }
    else if( i % 3 == 0){
        Console.WriteLine("Fizz");
    }else if ( i % 5 == 0){
        Console.WriteLine("Buzz");
    }
    else
        Console.WriteLine (i);
    
}