public class Queue<T>
{
    private T[] elements;
    private int front;
    private int rear;
    private int capacity;

    public Queue(int capacity)
    {
        this.capacity = capacity;
        elements = new T[capacity];
        front = 0;
        rear = -1;
    }

    public void Enqueue(T item)
    {
        if (rear == capacity - 1)
        {
            throw new InvalidOperationException("Queue is full");
        }
        elements[++rear] = item;
    }

    public T Dequeue()
    {
        if (front > rear)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        T item = elements[front++];
        return item;
    }

    public int Count
    {
        get { return rear - front + 1; }
    }

}
