// fibonacci recursion
static int fib(int n){

    if (n < 0)
    {
        return 0;
    }

    else if ((n == 0) || (n == 1))
    {
        return n;
    }

    else
    {
        return fib(n-1) + fib(n-2);
    }
}

static void fiboEvenSum(int number){

    // Initializes values needed.
    int term = 0;

    // Create an integer to hold the final answer.
    int answer = 0;

    // Loop while the final term is not the maximum specified.
    for (int i = 0; term < number; i++)
    {
        // Assign values from the recursion into a variable.
        term = fib(i);

        // Just making sure to not include last term if it is over the maximum value.
        if (term > number)
        {
            break;
        }

        // Check if the term is even.
        if (term % 2 == 0)
        {
            // Add all even terms into the answer variable.
            answer += term;
        }
    }

    // Print out answer into the console.
    Console.WriteLine(answer);
}

fiboEvenSum(10); 