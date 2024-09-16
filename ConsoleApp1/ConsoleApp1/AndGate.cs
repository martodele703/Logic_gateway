namespace DefaultNamespace;

public class AndGate: ILogicGate
{
    private List<ILogicGate> entradas;
    
    /*public LogicGate(List<ILogicGate> inputs = null, List<bool> directInputs = null)
    {
        this.inputs = inputs ?? new List<ILogicGate>(); // Inicializamos las entradas
        this.directInputs = directInputs ?? new List<bool>();
    }*/

    public AndGate(List<ILogicGate> entradas)
    {
        this.entradas = entradas;
    }

    public bool Evaluate()
    {
        foreach (var entrada in entradas)
        {
            if (!entrada.Evaluate())
            {
                return false;
            }
        }
        return true;
    }

    public bool GetValue(int index)
    {
        
    }
}

