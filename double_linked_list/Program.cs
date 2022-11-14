﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        public int noMhs;
        public int name;
        public Node next;
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            if (START == null || nim<= START.noMhs) 
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowd");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.prev = null;
                START = newNode;
                return;
                {

                }
            }
            Node previous, current;
            for (current=previous = START;
                current ! = null && nim >= current.noMhs
                previous = curretnt, current = current.next) 
            {
                if (nim == current.noMhs) 
                {
                    Console.WriteLine("\nDuplicate roll number not allowed");
                    return;
                }
                newNode.next = current;
                newNode.prev =previous;
                if(current == null)
                {
                    newNode.prev = null;
                    newNode.next = newNode;
                    return;
                }
                current.prev = newNode;
                previous.next = newNode;
            }
            public bool search(int rollNo, ref Node previous,ref Node current)
            {
                for (previous = currnt = START; current != null &&
                    rollNo != current.noMhs; previous = current,
                    current = current.next)
                    return (current != null);
            }
            public bool dellNode(int rollNo)
            {
                Node previous, current;
                previous = current = null;
                if (search(rollNo, ref previous, ref current) == false)
                    return false;
                if(current.next != null)
                {
                    previous.next = null;
                    return true;
                }
                if (current == START)
                {
                    START = START.next;
                    if (START != null)
                        START.prev = null;
                    return true;
                }
                previous.next = current.next;
                current.next.prev = previous;
                return true;
            }
            public bool ListEmpty()
            {
                if (START == null)
                    return true;
                else
                    return false;
            }
            public void ascending()
            {
                if (ListEmpty())
                    Console.WriteLine("\nList is Empty");
                else
                {
                    Console.WriteLine("\nRecord on the acending order of" + "roll number are:\n");
                    Node currentNode;
                    for (corrntNode = START; currentNode !=null; currentNode = currentNode.next)
                    while(currentNode != null)
                    {
                            Console.Write(currentNode.noMhs + "");
                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
