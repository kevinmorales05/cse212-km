public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();


        // Test Cases

        // Test 1
        // Scenario: Add this values [Andres (Pri:2), Juan (Pri:3), Bernardo (Pri:6), Victor (Pri:1)]
        // Expected Result: [Andres (Pri:2), Juan (Pri:3), Victor (Pri:1)]
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Andres", 2);
        priorityQueue.Enqueue("Juan", 3);
        priorityQueue.Enqueue("Bernardo", 6);
        priorityQueue.Enqueue("Victor", 1);
        Console.WriteLine("High priority");
        Console.WriteLine("Before Dequeue");
        Console.WriteLine(priorityQueue);
        Console.WriteLine("------------------");
        Console.WriteLine("Dequeued element");
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine("------------------");
        Console.WriteLine("Actual Queue");
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();


        // Defect(s) Found: 

        Console.WriteLine("---------");
var priorityQueue2 = new PriorityQueue();
         // Test 2
        // Scenario: Add this values [Camila (Pri:1), Juan (Pri:3), Bernardino (Pri:6), Henry (Pri:9)]
        // Expected Result: [Camila (Pri:1), Juan (Pri:3), Bernardino (Pri:6)]
        Console.WriteLine("Test 2");
        priorityQueue2.Enqueue("Camila", 1);
        priorityQueue2.Enqueue("Juan", 3);
        priorityQueue2.Enqueue("Bernardino", 6);
        priorityQueue2.Enqueue("Henry", 9);
        Console.WriteLine("High priority");
        Console.WriteLine("Before Dequeue");
        Console.WriteLine(priorityQueue2);
        Console.WriteLine("------------------");
        Console.WriteLine("Dequeued element");
        Console.WriteLine(priorityQueue2.Dequeue());
        Console.WriteLine("------------------");
        Console.WriteLine("Actual Queue");
        Console.WriteLine(priorityQueue2);
        priorityQueue2.Dequeue();

var priorityQueue3 = new PriorityQueue();
        Console.WriteLine("---------");
        // Test 3
        // Scenario: Add this values [Andy (Pri:4), Juan Pablo (Pri:3), Veronica (Pri:6), Victoria (Pri:1), Victoria (Pri:6)]
        // Expected Result: [Andy (Pri:4), Juan Pablo (Pri:3), Victoria (Pri:1)]
        Console.WriteLine("Test 3");
        priorityQueue3.Enqueue("Andy", 4);
        priorityQueue3.Enqueue("Juan Pablo", 3);
        priorityQueue3.Enqueue("Veronica", 6);
        priorityQueue3.Enqueue("Victoria", 1);
         priorityQueue3.Enqueue("Victoria", 6);
        Console.WriteLine("High priority");
        Console.WriteLine("Before Dequeue");
        Console.WriteLine(priorityQueue3);
        Console.WriteLine("------------------");
        Console.WriteLine("Dequeued element");
        Console.WriteLine(priorityQueue3.Dequeue());
        Console.WriteLine("------------------");
        Console.WriteLine("Actual Queue");
        Console.WriteLine(priorityQueue3);
        priorityQueue3.Dequeue();

    }
}