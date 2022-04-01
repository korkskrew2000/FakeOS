using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolCode : MonoBehaviour
{

    public string correctCode = "3746";
    public string playerCode = "";
    public int totalDigits = 0;
    public GameObject activateGameObject;

    // Start is called before the first frame update
    void Update()
    {
        if (totalDigits == 4) {
            if (playerCode == correctCode) {
                Debug.Log("Everything in game development is fucking hard and never worth it");
                activateGameObject.SetActive(true);
                this.gameObject.SetActive(false);
            } else {
                playerCode = "";
                totalDigits = 0;
                Debug.Log("Cleared automatically");
            }
        }
    }
}
