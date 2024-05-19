

Queue<int> intQueue = new(5);

try
{
    intQueue.Enqueue(10);
    intQueue.Enqueue(11);
    intQueue.Enqueue(12);
 
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Error while enqueueing: " + ex.Message);
}

Console.WriteLine("Count of elements in intQueue: " + intQueue.Count);

Queue<string> stringQueue = new(3);
    stringQueue.Enqueue("Gas");
    stringQueue.Enqueue("Diesel");
    stringQueue.Enqueue("Electricity");
Console.WriteLine("Count of elements in stringQueue: " + stringQueue.Count);



try
{
    Console.WriteLine("Dequeued elements:");
    Console.WriteLine(intQueue.Dequeue());
    Console.WriteLine(intQueue.Dequeue());

}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Error while dequeueing: " + ex.Message);
}

Console.WriteLine("Count of elements in intQueue after dequeueing: " + intQueue.Count);
