using System.Runtime.CompilerServices;

public class PriorityQueue {
    private Queue<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue irregardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority) {
        var newNode = new PriorityItem(value, priority);
        _queue.Enqueue(newNode);
    }

    public PriorityItem Dequeue() {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            Console.WriteLine("The queue is empty.");
            return null;
        }

        // Find the index of the item with the highest priority to remove
        List<int> indexList = new();
        foreach (PriorityItem item in _queue){
            
            indexList.Add(item.Priority);

        }
        //Console.WriteLine(indexList);
         // Inicializar maxNumber con el primer elemento de la lista
        int maxNumber = indexList[0];

        // Recorrer la lista para encontrar el número mayor
        foreach (int number in indexList)
        {
            if (number <= maxNumber)
            {
                continue;
            }
            maxNumber = number;
        }

        var itemDequeue = new PriorityItem("kev", 0);
        List<PriorityItem> newQueu = new List<PriorityItem>();
        foreach (var element in _queue){
            
            if(element.Priority == maxNumber){
               itemDequeue = element;
            }
            else {
                 newQueu.Add(element);
            }   

        }
        Queue<PriorityItem> newQ = new();
        foreach(PriorityItem item in newQueu){
            newQ.Enqueue(item);
        }
       _queue = newQ;
        // Remove and return the item with the highest priority
        //var value = _queue[highPriorityIndex].Value;
        return itemDequeue;
    }

    public override string ToString() {
        return $"[{string.Join(", ", _queue)}]";
    }
}

public class PriorityItem {
    public string Value { get; set; }
    public int Priority { get; set; }

    public PriorityItem(string value, int priority) {
        Value = value;
        Priority = priority;
    }
    public PriorityItem() {
        Value = "";
        Priority = 0;
    }

    public override string ToString() {
        return $"{Value} (Pri:{Priority})";
    }
}