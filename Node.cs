namespace DoubleLinkedList;

public class Node
{
    public double Data; 
  
    public Node Next { get; set; } 
  
    public Node Prev { get; set; }

    public Node(double element)
    {
        Data = element;
        Prev = Next = null;      
    }
}