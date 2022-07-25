using System.Collections;

// See https://aka.ms/new-console-template for more information
// Array numbers = new Array(5);
// numbers.insert(1);
// numbers.insert(15);
// numbers.insert(16);
// numbers.insert(17);
// numbers.insert(18);
// numbers.removeAt(3);
// Console.WriteLine($"the index is: {numbers.indexOf(15)}");
// Console.WriteLine($"the max is: {numbers.max()}");
// Array other = new Array(3);
// other.bulkInsert(15, 16, 17);
// Console.WriteLine($"the intersected items are:");
// numbers.intersect(other).print();
// Console.WriteLine("---------------------------");
// numbers.print();
// Console.WriteLine("Reversed:");
// Array reversed = numbers.reverse();
// reversed.insertAt(5, 5);
// reversed.print();

// LinkedList numbers = new LinkedList();
// numbers.addFirst(22);
// numbers.addFirst(25);
// numbers.addFirst(27);
// numbers.addFirst(33);
// numbers.addFirst(44);
// numbers.removeLast();
// Console.WriteLine(numbers.indexOf(22));
// Console.WriteLine(numbers.contains(22));
// Console.WriteLine(numbers.size());
// numbers.reverse();
// Console.WriteLine(string.Join("-", numbers.toArray()));
// Console.WriteLine(numbers.printMiddle());
// Console.WriteLine(numbers.hasLoop());

// StringReverserWithStack stack = new StringReverserWithStack();
// Console.WriteLine(stack.reverse("Tjokkenroll"));

// ExpressionWithStack expression = new ExpressionWithStack();
// Console.WriteLine(expression.isBalanced("(1+2)"));

// Stack stack = new Stack();
// stack.push(10);
// stack.push(20);
// stack.push(30);
// stack.pop();
// stack.pop();
// Console.WriteLine(stack.peek());
//stack.print();

// TwoStacks stack = new TwoStacks(10);
// stack.push1(11);
// stack.push1(12);
// stack.push1(13);
// stack.push2(22);
// stack.push2(23);
// stack.push2(24);
// Console.WriteLine(stack.pop1());
// Console.WriteLine(stack.pop2());

// MinStack stack = new MinStack();
// stack.push(1);
// stack.push(11);
// stack.push(12);
// stack.push(10);
// stack.push(17);
// stack.pop();
// Console.WriteLine(stack.min());

// Queue<int> queue = new Queue<int>();
// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);

// QueueReverser reverser = new QueueReverser();
// reverser.reverse(queue);
// reverser.print(queue);

// ArrayQueue queue = new ArrayQueue(5);
// queue.enqueue(5);
// queue.enqueue(10);
// queue.enqueue(15);
// var front = queue.dequeue();
// queue.enqueue(20);
// queue.enqueue(25);
// queue.enqueue(30);
// Console.WriteLine(front);
// Console.WriteLine(queue);

// QueueWithTwoStacks queue = new QueueWithTwoStacks();
// queue.enqueue(10);
// queue.enqueue(20);
// queue.enqueue(30);

// queue.dequeue();
// queue.dequeue();
// var item = queue.dequeue();
// Console.WriteLine(item);

// PriorityQueue queue = new PriorityQueue(5);
// queue.add(5);
// queue.add(3);
// queue.add(1);
// queue.add(4);
// queue.add(6);
// queue.add(8);
// queue.add(1);
// Console.WriteLine(queue.ToString());

// while (!queue.isEmpty())
//     Console.WriteLine(queue.remove());

// Queue<int> queue = new Queue<int>(5);
// queue.Enqueue(5);
// queue.Enqueue(3);
// queue.Enqueue(1);
// queue.Enqueue(4);
// queue.Enqueue(6);
// queue.Enqueue(8);
// queue.Enqueue(1);

// QueueReverser reverser = new QueueReverser();
// reverser.reverseByKth(queue, 6);
// reverser.print(queue);

// LinkedListQueue queue = new LinkedListQueue();
// queue.enqueue(2);
// queue.enqueue(5);
// queue.enqueue(7);
// queue.dequeue();
// Console.WriteLine(queue.toString());

// StackWithTwoQueues queue = new StackWithTwoQueues();
// queue.push(5);
// queue.push(9);
// queue.push(6);
// queue.push(1);
// queue.pop();
// Console.WriteLine(queue.ToString());

// CharFinder finder = new CharFinder();
// Console.WriteLine(finder.findFirstNonRepeatingChar("a green valley"));

// CharFinder finder = new CharFinder();
// Console.WriteLine(finder.findFirstRepeatingChar("green valley"));

// Dictionary dictionary = new Dictionary();
// dictionary.put(6, "A");
// dictionary.put(8, "B");
// dictionary.put(11, "C");
// dictionary.put(8, "A+");
// dictionary.remove(6);
// Console.WriteLine(dictionary.get(8));

// DictionaryExercises dictionary = new DictionaryExercises();
// Console.WriteLine(dictionary.FindMostFrequent(new int[] { 1, 2, 2, 3, 3, 3, 4 }));
// Console.WriteLine(dictionary.CountPairsWithDiff(new int[] { 1, 7, 5, 9, 2, 12, 3 }, 2));
// Console.WriteLine(string.Join("-", dictionary.twoSum(new int[] { 2, 7, 11, 15 }, 9)));

// HashMap hashMap = new HashMap();
// hashMap.Put(8, "B");
// hashMap.Put(6, "A");
// hashMap.Put(11, "C");
// hashMap.Put(8, "A+");
// hashMap.Remove(6);
// Console.WriteLine(hashMap.ToString());
// Console.WriteLine(hashMap.ToString());

// Tree tree = new Tree();
// tree.Insert(7);
// tree.Insert(4);
// tree.Insert(9);
// tree.Insert(1);
// tree.Insert(6);
// tree.Insert(8);
// tree.Insert(10);
// Console.WriteLine("Done");
// Console.WriteLine(tree.find(6));
// Console.WriteLine(tree.find(11));

Tree tree = new Tree();
tree.Insert(7);
tree.Insert(4);
tree.Insert(9);
tree.Insert(1);
tree.Insert(6);
tree.Insert(8);
tree.Insert(10);
// tree.TraversePreOrder();
// tree.TraverseInOrder();
// tree.TraversePostOrder();
// Console.WriteLine("Height: " + tree.Height());
// Console.WriteLine("Min: " + tree.Min());

Tree tree2 = new Tree();
tree2.Insert(7);
tree2.Insert(4);
tree2.Insert(9);
tree2.Insert(1);
tree2.Insert(6);
tree2.Insert(8);
// tree2.Insert(10);
Console.WriteLine(tree2.Equals(tree));