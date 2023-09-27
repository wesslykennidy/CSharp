﻿/*
1. Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
2. When the current value is divisible by 3, print the term Fizz next to the number.
3. When the current value is divisible by 5, print the term Buzz next to the number.
4. When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

*/
for (int i = 0; i < 101; i++)
{
    if (i%3 == 0){
        Console.WriteLine($"{i} - Fizz");
    }else if (i%5 == 0){
        Console.WriteLine($"{i} - Buzz");
    }else if ((i%3==0) && (i%5==0)){
        Console.WriteLine($"{i} - FizzBuzz");
    }else{
        Console.WriteLine(i);
    }
    
}

/* Result:
0 - Fizz
1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
11
12 - Fizz
13
14
15 - Fizz
16
17
18 - Fizz
19
20 - Buzz
21 - Fizz
22
23
24 - Fizz
25 - Buzz
26
27 - Fizz
28
29
30 - Fizz
31
32
33 - Fizz
34
35 - Buzz
36 - Fizz
37
38
39 - Fizz
40 - Buzz
41
42 - Fizz
43
44
45 - Fizz
46
47
48 - Fizz
49
50 - Buzz
51 - Fizz
52
53
54 - Fizz
55 - Buzz
56
57 - Fizz
58
59
60 - Fizz
61
62
63 - Fizz
64
65 - Buzz
66 - Fizz
67
68
69 - Fizz
70 - Buzz
71
72 - Fizz
73
74
75 - Fizz
76
77
78 - Fizz
79
80 - Buzz
81 - Fizz
82
83
84 - Fizz
85 - Buzz
86
87 - Fizz
88
89
90 - Fizz
91
92
93 - Fizz
94
95 - Buzz
96 - Fizz
97
98
99 - Fizz
100 - Buzz
*/