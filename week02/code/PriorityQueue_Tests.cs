using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 2);
        priorityQueue.Enqueue("Item2", 5);
        priorityQueue.Enqueue("Item3", 3);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Item2", result);

        // Additional checks to ensure correct behavior
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 4);
        priorityQueue.Enqueue("Item2", 4);
        priorityQueue.Enqueue("Item3", 2);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result); // Ensures FIFO order for same priority

        // Additional checks
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown.
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyDequeue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items, dequeue some, then enqueue more.
    // Expected Result: Dequeue should always remove the highest-priority item in FIFO order.
    // Defect(s) Found: None
    public void TestPriorityQueue_EnqueueAndDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 3);
        priorityQueue.Enqueue("Item3", 5);
        priorityQueue.Enqueue("Item4", 2);

        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());

        priorityQueue.Enqueue("Item5", 4);
        Assert.AreEqual("Item5", priorityQueue.Dequeue());
        Assert.AreEqual("Item4", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue a single item and dequeue it.
    // Expected Result: The same item should be dequeued.
    // Defect(s) Found: None
    public void TestPriorityQueue_SingleElement()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("OnlyItem", 10);

        Assert.AreEqual("OnlyItem", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with descending priorities and dequeue all.
    // Expected Result: Items should be dequeued in the order they were enqueued.
    // Defect(s) Found: None
    public void TestPriorityQueue_DescendingPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 5);
        priorityQueue.Enqueue("Item2", 4);
        priorityQueue.Enqueue("Item3", 3);
        priorityQueue.Enqueue("Item4", 2);
        priorityQueue.Enqueue("Item5", 1);

        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item4", priorityQueue.Dequeue());
        Assert.AreEqual("Item5", priorityQueue.Dequeue());
    }

}