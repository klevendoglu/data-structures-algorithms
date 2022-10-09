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

// Tree tree = new Tree();
// tree.Insert(7);
// tree.Insert(4);
// tree.Insert(9);
// tree.Insert(1);
// tree.Insert(6);
// tree.Insert(8);
// tree.Insert(10);
// tree.Insert(11);
// tree.Insert(12);
// tree.Insert(13);
// tree.Insert(14);
// tree.Insert(15);
// tree.TraversePreOrder();
// tree.TraverseInOrder();
// tree.TraversePostOrder();
//tree.TraverseLevelOrder();
//Console.WriteLine("Height: " + tree.Height());
// Console.WriteLine("Min: " + tree.Min());
// Console.WriteLine("Max: " + tree.Max());
// Console.WriteLine("Size: " + tree.Size());
// Console.WriteLine("Leaves: " + tree.CountLeaves());
// Console.WriteLine(tree.Contains(19));
// Console.WriteLine(tree.AreSibling(4, 9));

// var ancestors = tree.getAncestors(15);
// for (int i = 0; i < ancestors.Count; i++)
//     Console.WriteLine(ancestors[i]);

// Tree other = new Tree();
// other.Insert(7);
// other.Insert(4);
// other.Insert(9);
// other.Insert(1);
// other.Insert(6);
// other.Insert(8);
// other.Insert(10);
// other.SwapRoot();
// Console.WriteLine(other.Equals(tree));
// Console.WriteLine(other.IsBinarySearchTree());

// var nodes = other.GetNodesAtDistance(1);
// for (int i = 0; i < nodes.Count; i++)
//     Console.WriteLine(nodes[i]);

// AVLTree tree = new AVLTree();
// tree.Insert(10);
// tree.Insert(30);
// tree.Insert(20);
// tree.Insert(5);

// Heap heap = new Heap(10);
// heap.Insert(10);
// heap.Insert(5);
// heap.Insert(17);
// heap.Insert(4);
// heap.Insert(22);
// heap.remove();
// Console.WriteLine(string.Join(",", heap.GetItems()));

// var numbers = new int[] { 3, 8, 12, 16, 22, 37 };
// Heap heapSortDesc = new Heap(numbers.Length);
// for (int i = 0; i < numbers.Length; i++)
//     heapSortDesc.Insert(numbers[i]);

// for (int i = 0; i < numbers.Length; i++)
//     numbers[i] = heapSortDesc.remove();

// Console.WriteLine(string.Join(",", numbers));

// Heap heapSortAsc = new Heap(numbers.Length);

// for (int i = 0; i < numbers.Length; i++)
//     heapSortAsc.Insert(numbers[i]);

// for (int i = numbers.Length - 1; i >= 0; i--)
//     numbers[i] = heapSortAsc.remove();

// Console.WriteLine(string.Join(",", numbers));

// var numbers = new int[] { 5, 3, 8, 4, 1, 2 };
// MaxHeap.Heapify(numbers);
// Console.WriteLine(string.Join(",", numbers));

// Console.WriteLine("Largest KTH: " + MaxHeap.GetLargestKth(numbers, 2));

// MinHeap heap = new MinHeap();
// heap.Insert(5, "1");
// heap.Insert(3, "2");
// heap.Insert(8, "3");
// heap.Insert(4, "4");
// heap.Insert(1, "5");
// heap.Insert(2, "6");
// Console.WriteLine(string.Join(",", heap.GetItems().Where(t => t != null).Select(t => t.key)));

// MinPriorityQueue queue = new MinPriorityQueue();
// queue.add("5", 3);
// queue.add("3", 1);
// queue.add("4", 2);

// Trie trie = new Trie();
// trie.Insert("car");
// trie.Insert("dog");
// trie.Insert("card");
// trie.Insert("care");
// trie.Insert("careful");
// trie.Insert("egg");
// trie.Insert("kaan");
// trie.Remove("kaan");
// Console.WriteLine(trie.Contains("Kaan"));

// var words = trie.FindWords("car");
// Console.WriteLine(string.Join(", ", words));

// Console.WriteLine($"Number of words: {trie.CountWords()}");


// Trie trie = new Trie();
// trie.Insert("car");
// trie.Insert("care");
// Console.WriteLine($"Longest Common Prefix: {trie.longestCommonPrefix()}");
// trie.PrintWords();

// Graph graph = new Graph();
// graph.AddNode("A");
// graph.AddNode("B");
// graph.AddNode("C");
// graph.AddNode("D");
// graph.AddEdge("A", "C");
// graph.AddEdge("A", "B");
// graph.Print();
// graph.RemoveEdge("A", "C");
// graph.Print();


// Graph graph = new Graph();
// graph.AddNode("A");
// graph.AddNode("B");
// graph.AddNode("C");
// graph.AddNode("D");
// graph.AddEdge("A", "B");
// graph.AddEdge("B", "D");
// graph.AddEdge("D", "C");
// graph.AddEdge("A", "C");
// graph.TraverseDepthFirst("A");
// graph.TraverseBreadthFirstIterative("A");
//graph.TraverseDepthFirstIterative("A");

// Graph graph = new Graph();
// graph.AddNode("X");
// graph.AddNode("A");
// graph.AddNode("B");
// graph.AddNode("P");
// graph.AddEdge("X", "A");
// graph.AddEdge("X", "B");
// graph.AddEdge("A", "P");
// graph.AddEdge("B", "P");
// var sorted = graph.topologicalSort();
// Console.WriteLine(string.Join(",", sorted));

// Graph graph = new Graph();
// graph.AddNode("A");
// graph.AddNode("B");
// graph.AddNode("C");
// graph.AddEdge("A", "B");
// graph.AddEdge("B", "C");
// graph.AddEdge("A", "C");
// Console.WriteLine("Has cycle: " + graph.HasCycle());

// WeightedGraph graph = new WeightedGraph();
// graph.AddNode("A");
// graph.AddNode("B");
// graph.AddNode("C");
// graph.AddEdge(from: "A", to: "B", weight: 3);
// graph.AddEdge(from: "A", to: "C", weight: 2);
// graph.Print();

// WeightedGraph graph = new WeightedGraph();
// graph.AddNode("A");
// graph.AddNode("B");
// graph.AddNode("C");
// graph.AddEdge(from: "A", to: "B", weight: 1);
// graph.AddEdge(from: "B", to: "C", weight: 2);
// graph.AddEdge(from: "A", to: "C", weight: 10);
// Console.WriteLine(graph.GetShortestPath(from: "A", to: "C"));

// WeightedGraph graph = new WeightedGraph();
// graph.AddNode("A");
// graph.AddNode("B");
// graph.AddNode("C");
// graph.AddEdge(from: "A", to: "B", weight: 1);
// graph.AddEdge(from: "B", to: "C", weight: 2);
// graph.AddEdge(from: "C", to: "A", weight: 10);
// Console.WriteLine(graph.HasCycle());


// WeightedGraph graph = new WeightedGraph();
// graph.AddNode("A");
// graph.AddNode("B");
// graph.AddNode("C");
// graph.AddNode("D");
// graph.AddEdge(from: "A", to: "B", weight: 3);
// graph.AddEdge(from: "B", to: "D", weight: 4);
// graph.AddEdge(from: "C", to: "D", weight: 5);
// graph.AddEdge(from: "A", to: "C", weight: 1);
// graph.AddEdge(from: "B", to: "C", weight: 2);
// var tree = graph.getMinimumSpanningTree();
// tree.Print();

// int[] items = new int[] { 7, 5, 2, 3, 2, 3, 1, 4 };

// BubbleSort sorter = new BubbleSort();
// sorter.Sort(items);
// Console.WriteLine(string.Join(",", items));

// SelectionSort sorter = new SelectionSort();
// sorter.Sort(items);
// Console.WriteLine(string.Join(",", items));

// InsertionSort sorter = new InsertionSort();
// sorter.Sort(items);
// Console.WriteLine(string.Join(",", items));

// MergeSort sorter = new MergeSort();
// sorter.Sort(items);
// Console.WriteLine(string.Join(",", items));

// QuickSort sorter = new QuickSort();
// sorter.Sort(items);
// Console.WriteLine(string.Join(",", items));

// CountingSort sorter = new CountingSort();
// sorter.Sort(items, max: 9);
// Console.WriteLine(string.Join(",", items));

// BucketSort sorter = new BucketSort();
// sorter.Sort(items, numberOfBuckets: 3);
// Console.WriteLine(string.Join(",", items));

// LinearSearch searcher = new LinearSearch();
// var index = searcher.Search(items, target: 1);
// Console.WriteLine($"found index: {index}");

int[] items = new int[] { 1, 3, 4, 7, 8 };

// BinarySearch searcher = new BinarySearch();
// var index = searcher.Iterative(items, target: 2);
// Console.WriteLine($"Iterative found index: {index}");

// var index2 = searcher.Recursive(items, target: 7);
// Console.WriteLine($"Recursive found index: {index2}");

// TernarySearch searcher = new TernarySearch();
// var index = searcher.Search(items, target: 4);
// Console.WriteLine($"Found index: {index}");

// JumpSearch searcher = new JumpSearch();
// var index = searcher.Search(items, target: 8);
// Console.WriteLine($"Found index: {index}");

// ExponentialSearch searcher = new ExponentialSearch();
// var index = searcher.Search(items, target: 7);
// Console.WriteLine($"Found index: {index}");

// Console.WriteLine(StringUtils.CountVowels("Hello World"));
// Console.WriteLine(StringUtils.Reverse("Hello World"));
// Console.WriteLine(StringUtils.ReverseWords("Trees are blue"));
// Console.WriteLine(StringUtils.AreRotations("TATAVA", "VATATA"));
// Console.WriteLine(StringUtils.RemoveDuplicates("RATATATA"));
// Console.WriteLine(StringUtils.GetMaxOccuringChar("Trees are beautiful"));
// Console.WriteLine(StringUtils.capitalize("trees are beautiful"));
// Console.WriteLine(StringUtils.areAnagrams("trees", "seert"));
// Console.WriteLine(StringUtils.areAnagram2("trees", "seert"));
Console.WriteLine(StringUtils.isPalindrome("kayak"));