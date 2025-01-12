static void multiplesOf3Or5(int number) {
    
    // Create an integer to hold the final answer.
    int answer = 0;
    
    // Iterate all numbers from 0 to the specified value.
    for (int i = 1; i < number; i++) 
    {
        // Check if the value is fully divisible (no remainders) with 3 or 5.
        if ((i % 3 == 0) || (i % 5 == 0))
        {
            // Add all values.
            answer += i;
        }
    }

    // Print out answer into the console.
    Console.WriteLine(answer);
}

multiplesOf3Or5(1000);