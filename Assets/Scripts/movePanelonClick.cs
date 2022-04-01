using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePanelonClick : MonoBehaviour
{
   public void MoveUI() {
        this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y,0);
        Debug.Log("Currently dragging: " + this.gameObject);
    }
}
