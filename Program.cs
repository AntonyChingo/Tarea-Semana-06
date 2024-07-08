/* 1.Función que calcule el número de elementos de una lista:
La idea de este algoritmo es bastante sencilla, lo que tendremos q hacer para ver la longitud de
una lista es simplemente recorrer la lista hasta el final e ir contando el número de saltos. El principal motivo por el que deberíamos implementar es que nos es que nos permite aprender y comprender permite aprender y comprender
el manejo de los nodos*/
using System;

class Node /*Esta clase representa un nodo en la lista enlazada. Cada nodo tiene un campo Data para almacenar el valor y un campo Next para apuntar al siguiente nodo*/
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public void Add(int data) /*Metodo que añade un nuevo nodo al final de la lista*/
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void PrintList() /*Metodo que imprime todos los elementos de la lista.*/
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public int CountElements() /*Este metodo recorre la lista desde el principio hasta el final, contando el número de nodos lo que nos permite devolver el número total de elementos en la lista.*/
    {
        int count = 0;
        Node current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args) /*Este metodo de la clase Program crea una lista enlazada, agrega elementos, imprime la lista original, invierte la lista y luego imprime la lista invertida.*/
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        Console.WriteLine("Lista:");
        list.PrintList();

        Console.WriteLine("Número de elementos en la lista:");
        Console.WriteLine(list.CountElements());
    }
}

/* 2.Invertir una lista Invertir una lista enlazada: enlazada:
Implementar un método dentro de la Implementar un método dentro de la lista enlazada q lista enlazada que permita invertir los datos ue permita invertir los datos
almacenados en una lista enlazada, es decir que almacenados en una lista enlazada, es decir que el primer elemento pase a ser el último y el primer elemento pase a ser el último y el
último pase a ser el primero, que el segundo sea el penúltimo y el penúltimo pase a ser el
segundo y así segundo y así sucesivamente.*/
using System;

class Node /*Esta clase representa un nodo en la lista enlazada. Cada nodo tiene un campo Data para almacenar el valor y un campo Next para apuntar al siguiente nodo*/
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public void Add(int data) /*Este metodo añade un nuevo nodo al final de la lista*/
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void PrintList() /*Este metodo imprime los elementos de la lista*/
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void Reverse() /*Este metodo invierte la lista enlazada usando los tres punteros prev, current y next, para recorrer y reordenar los nodos.*/
    {
        Node prev = null;
        Node current = head;
        Node next = null;
        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        head = prev;
    }
}

class Program
{
    static void Main(string[] args) /*Este metodo crea una lista enlazada, agrega elementos, imprime la lista original, invierte la lista y luego imprime la lista invertida.*/
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        Console.WriteLine("Lista original:");
        list.PrintList();

        list.Reverse();

        Console.WriteLine("Lista invertida:");
        list.PrintList();
    }
}
