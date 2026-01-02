using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int random;
    [SerializeField] float time;
    [SerializeField] GameObject prefab;

    [SerializeField] Transform[ ] transforms;
    [SerializeField] WaitForSeconds waitForSeconds;

    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(time);
    }

    private void Start()
    {
       
    }
    // Start is called before the first frame update
    private void Update()
    {
        if (true)
        {
            GameObject clone = Instantiate(prefab);

            clone.transform.rotation = Quaternion.Euler(0f, 180.0f, 0f);

            time = 0.0f;
        }
    }
}
