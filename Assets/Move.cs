using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8,6.79f,-1.3f);
    void Update()
    {
        //1. MoveTowards
        /*transform.position =
            Vector3.MoveTowards(transform.position,target,1f);*/

        //2. SmoothDamp
        /*Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position,target,ref velo,0.1f);*/

        //3. Lerp (선형 보간)
        /*transform.position =
            Vector3.Lerp(transform.position,target,0.02f); */
        
        //4. SLerp (구면 선형 보간(포물선)) 
        /*transform.position =
            Vector3.Slerp(transform.position,target,0.02f);*/

    }
}
