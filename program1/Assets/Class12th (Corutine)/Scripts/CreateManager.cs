using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float time;

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
