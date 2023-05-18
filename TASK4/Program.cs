namespace WorkEvents 
{ 
class Program
    {
        static void Main(string[] args)
        {
            Work workflow = new Work();
            WorkHandler handler = new WorkHandler();
            workflow.WorkflowAction += handler.HandleWorkflowAction;

            workflow.Run();

            Console.ReadLine();
        }
    }
}