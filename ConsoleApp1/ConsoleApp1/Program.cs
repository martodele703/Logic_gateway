namespace DefaultNamespace;

public class Program
{
    static void Main()
    {
        // Definir valores de las entradas a, b, y c
        bool a = true; // valor de la entrada 'a'
        bool b = false; // valor de la entrada 'b'
        bool c = true; // valor de la entrada 'c'

        // Crear la compuerta NOT que niega 'b'
        NotGate notGateB = new NotGate(logicValues: b);

        // Crear la primera compuerta AND (a AND b)
        AndGate andGate1 = new AndGate(logicValues: new List<bool> { a, b });

        // Crear la segunda compuerta AND (c AND NOT(b))
        AndGate andGate2 = new AndGate(
            composedEntry: new List<ILogicGate> { notGateB },
            logicValues: new List<bool> { c }
            );
        
        // Crear la compuerta OR (resultado de las dos AND gates)
        OrGate orGate = new OrGate(
                inputs: new List<ILogicGate> { andGate1, andGate2 }
            );
        

        bool resultadoFinal = orGate.Evaluate();

        // Imprimir el resultado
        Console.WriteLine("Resultado del circuito: " + resultadoFinal);
    }
}