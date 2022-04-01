using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressSymbol : MonoBehaviour
{
    public void PressSymbolButton() {
        this.transform.parent.GetComponent<SymbolCode>().playerCode += gameObject.name;
        this.transform.parent.GetComponent<SymbolCode>().totalDigits += 1;
        Debug.Log("press");
    }
}
