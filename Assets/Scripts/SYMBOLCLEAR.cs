using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SYMBOLCLEAR : MonoBehaviour
{
    public void ClearSymbols()
    {
        this.transform.parent.GetComponent<SymbolCode>().totalDigits = 0;
        this.transform.parent.GetComponent<SymbolCode>().playerCode = "";
        Debug.Log("Cleared with Button");
    }
}
