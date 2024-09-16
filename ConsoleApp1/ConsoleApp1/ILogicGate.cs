namespace DefaultNamespace;
using System.Collections.Generic;
public interface ILogicGate
{
    //Evalua la compuerta
    bool Evaluate();

    // Obtiene el valor de una entrada (puede ser una compuerta o un valor booleano directo)
    bool GetValue(int index);
}
