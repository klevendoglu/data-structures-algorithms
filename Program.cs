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

MinStack stack = new MinStack();
stack.push(1);
stack.push(11);
stack.push(12);
stack.push(10);
stack.push(17);
stack.pop();
Console.WriteLine(stack.min());