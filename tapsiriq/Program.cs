//int num = 21;
//int sum = 0;
//int rem;
//while (num>0)
//{
//    rem = num % 10;
//    sum += rem;
//    num /= 10;

//}   
//if (sum %2 == 0)
//{
//    System.Console.WriteLine($"eded cutdur {sum}");
//}
//else
//{
//    System.Console.WriteLine($"eded tekdir {sum}");
//}

int num = 123;
int rem;
int min = num%10;

while (num > 0)
{
    rem = num % 10;
    
    if (rem < min)
    {
        min = rem;
    }
    num = num / 10;
}
System.Console.WriteLine(min);

//int sum = 0;
//int dv = 13;
//for (int n=100; n>0; n--)
//{
//    if (n%dv ==0)
//    {
//        System.Console.WriteLine(n);
//        sum +=n;
//    }
//}
//System.Console.WriteLine(sum);