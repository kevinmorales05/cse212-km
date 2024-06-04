public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // 1. Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        //2. Insert to the right ony if the value is greater
        else if (value > Data)
        {
            //3.  Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // 4. If value is equal to Data, do nothing because no duplicates allowed
    }

    public bool Contains(int value)
    {
        // 1. If the value is the current node's data, return true
        if (value == Data)
        {
            return true;
        }
        // 2. If the value is less than the current node's data, search the left subtree
        else if (value < Data && Left != null)
        {
            return Left.Contains(value);
        }
        //3.  If the value is greater than the current node's data, search the right subtree
        else if (value > Data && Right != null)
        {

            return Right.Contains(value);
        }
        //4.  If the value is not found and there are no more nodes to search, return false
        return false;
    }

    public int GetHeight()
    {
        // 1. If the node is null, the height is 0
        if (this == null)
        {
            return 0;
        }
        else
        {
            //2. Calculate the height of the left and right subtrees recursively
            int leftHeight = Left?.GetHeight() ?? 0;
            int rightHeight = Right?.GetHeight() ?? 0;

            // 3. Return the maximum height of the left and right subtrees plus 1 for the current node
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}