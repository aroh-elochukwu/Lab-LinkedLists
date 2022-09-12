IntLinkedList intList = new IntLinkedList();

intList.head = new IntNode(5);
IntNode second = new IntNode(0);
IntNode third = new IntNode(8);

intList.head.next = second;
second.next = third;

intList.printList();


StringLinkedList stringList = new StringLinkedList();

stringList.head = new StringNode("Apple");
StringNode secondString = new StringNode("Guava");
StringNode thirdString = new StringNode("Paw-Paw");

stringList.head.next = secondString;
secondString.next = thirdString;

stringList.printList();

public class IntLinkedList
{
    public IntNode head;

    public IntLinkedList()
    {
        head = null;
            
    }

    public void printList()
    {
        IntNode n = head;
        while (n != null)
        {
            Console.Write(n.value + " ");
            n = n.next;
        }

    }
}

public class IntNode
{
    public int value;
    public IntNode next;
    public IntNode(int input)
    {
        value = input;
        next = null;
    }
}

public class StringLinkedList
{
    public StringNode head;
    
    public void printList()
    {
        StringNode n = head;
        while (n != null)
        {
            Console.Write(n.value + " ");
            n = n.next;
        }

    }
}

public class StringNode
{
    public string value;
    public StringNode next;
    public StringNode(string input)
    {
        value = input;
        next = null;
    }  

}



