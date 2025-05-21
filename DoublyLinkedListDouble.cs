using System.Collections;

namespace DoubleLinkedList
    {
        public class DoublyLinkedListDouble : IEnumerable
        {
            private Node tail = null;
            private Node head = null;

            public DoublyLinkedListDouble()
            {
                tail = null;
                head = null;
            }

            public bool IsEmpty()
            {
                return head == null;
            }

            public double? FindMaxValue()
            {
                if (IsEmpty()) return null;

                Node current = head;
                double max = current.Data;

                while (current != null)
                {
                    if (current.Data > max)
                    {
                        max = current.Data;
                    }
                    current = current.Next;
                }

                return max;
            }

            public double? FindMeanValue()
            {
                if (IsEmpty())
                {
                    return null;
                }

                Node current = head;
                int count = 0;
                double sum = 0.0;

                while (current != null)
                {
                    sum += current.Data;
                    count++;
                    current = current.Next;
                }

                if (count == 0)
                {
                    return null;
                }
                return sum / count;
            }

            public void AddElementToStart(double value)
            {
                var newElement = new Node(value);

                if (IsEmpty())
                {
                    head = tail = newElement;
                }
                else
                {
                    newElement.Next = head;
                    head.Prev = newElement;
                    head = newElement;
                }
            }

            public double? FindFirstPositiveElement()
            {
                var current = head;
                while (current != null)
                {
                    if (current.Data > 0.0)
                    {
                        return current.Data;
                    }
                    current = current.Next;
                }

                return null;
            }

            public int FindNumberElementsBiggerMeanValue()
            {
                double? meanValue = FindMeanValue();
                if (meanValue == null)
                {
                    return 0;
                }

                int count = 0;
                var current = head;

                while (current != null)
                {
                    if (current.Data > meanValue)
                    {
                        count++;
                    }
                    current = current.Next;
                }

                return count;
            }

            public List<double> GetElementsBiggerMeanValue()
            {
                var result = new List<double>();
                double? meanValue = FindMeanValue();
                
                if (meanValue == null)
                {
                    return result;
                }

                var current = head;
                while (current != null)
                {
                    if (current.Data > meanValue)
                    {
                        result.Add(current.Data);
                    }
                    current = current.Next;
                }

                return result;
            }

            public void RemoveBeforeMaxValue()
            {
                if (IsEmpty())
                {
                    return;
                }

                Node current = head;
                Node maxNode = head;

                while (current != null)
                {
                    if (current.Data > maxNode.Data)
                    {
                        maxNode = current;
                    }
                    current = current.Next;
                }

                if (maxNode == head) return;

                current = head;
                while (current != maxNode)
                {
                    Node next = current.Next;
                    current.Prev = null;
                    current.Next = null;
                    current = next;
                }

                head = maxNode;
                head.Prev = null;

                if (head.Next == null)
                {
                    tail = head;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                Node current = head;
                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }

            public static void PrintList(DoublyLinkedListDouble list, string prompt)
            {
                Console.Write($"{prompt}: ");
                foreach (double item in list)
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine();
            }
        }
    }
