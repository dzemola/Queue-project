
class Que
{
    private Node _head; // Ref to the head of the list
    private Node _tail; // Ref to the tail of the list
    private int _length = 0; //Ref list length count


    public override string ToString()
    {
        Node temp = new Node();
        temp = this._head;
        string info = "";

        for (int i = 0; i <= _length; i++)
        {


            if (temp != null)
            {
                info = temp.Data.ToString() + (", ") + (info);
                temp = temp.Next;
            }
        }

        return "This list contains: " + info;
    }

    public void inQue(object newData)
    {
        if (_head == null)
        {
            _head = new Node(); //Create new node at head
            _tail = _head; //Have tail ref head
            _tail.Data = newData; //Set data for tail

        }
        //Fill list with Nodes
        else
        {
            Node newNode = new Node(); //Create new node
            newNode.Data = newData; //Set new node's data
            _tail.Next = newNode; //Add the node to the end of the list
            _tail = newNode; //Make new node the new tail of the list
            _length++; //Add list length count
        }

    }

    public object deQue()
    {
        object returnData = null;
        Node currentNode = _head;

        if (currentNode == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        else
        {
            returnData = _head.Data;
            _head.Data = null;

            if (currentNode != null && currentNode.Next != _head)
            {
                
                currentNode = currentNode.Next;
            }

            _head = currentNode;
            _length -= 1;

            
        }
        return returnData;
    }

    public object Peek()
    {

        return _head.Data;
    }

    public void Clear()
    {
        _head = null;
        _tail = null;
    }

    public bool IsEmpty()
    {
        bool empty = true;

        if (_head == null && _tail == null)
        {
            empty = true;
        }
        else
        {
            empty = false;
        }

        return empty;
    }

    public void PrintList()
    {
        Node temp = new Node();
        temp = this._head;
        if (temp != null)
        {
            Console.Write("The list contains: ");
            while (temp != null)
            {
                Console.Write(temp.Data + ", ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The list is empty.");
        }
    }

}

