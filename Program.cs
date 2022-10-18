Console.WriteLine("Hello, World!");
Input a = new Input();
Input b = new Input();
Input c = new Input();
AndGate and = new AndGate();
OrGate or = new OrGate();
NotGate not = new NotGate();

a.Connect(and);
b.Connect(and);

public class Gate
{
    public bool valor{ get; set;}
    public bool Input {get; set;}
    public bool Output { get; set;}
    public abstract void Connect(Gate resposta);
    public abstract void Answer()
}
public class AndGate : Gate
{
    public override void Connect(Gate resposta)
    {
        
    }
}

