using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
    void Update() {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*10,
        0 , Input.GetAxis("Vertical")*Time.deltaTime*10);
        transform.Translate(vec);
    }
}
