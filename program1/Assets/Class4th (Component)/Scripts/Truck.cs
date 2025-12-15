using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] GameObject[ ] wheels;
    // Start is called before the first frame update

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        transform.GetChild(0).GetComponent<Material>().color = new Color(0.5f,0.5f,0.5f,0.5f);
        for (int i = 0; i < wheels.Length; i++)
        {
            Debug.Log(wheels[i].name);
        }
        rigidbody.useGravity = false;
    }

    
}
