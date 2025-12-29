using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tribune : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }


}
