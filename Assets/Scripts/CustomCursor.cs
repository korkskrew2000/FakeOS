using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    Vector2 mouse;
    public GameObject normalCursor;
    public GameObject handCursor;

   
    // Use this for initialization
    void Start() {
        Cursor.visible = false;
    }

   void Update() {
        this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }

}
