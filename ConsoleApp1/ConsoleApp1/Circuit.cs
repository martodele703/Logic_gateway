namespace DefaultNamespace;

public class Circuit
{
    private List<ILogicGate> gates = new List<ILogicGate>();

    public void AddGateToCircuit(ILogicGate gate)
    {
        gates.Add(gate);
    }

    public bool FinalEvaluate()
    {
        if (gates.Count > 0)
        {
            return gates[gates.Count - 1].Evaluate(); // Evaluamos la última compuerta
        }
        throw new InvalidOperationException("No hay compuertas en el circuito");
    }
}