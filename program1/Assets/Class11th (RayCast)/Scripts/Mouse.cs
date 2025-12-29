using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;

    [SerializeField] float duration = 1.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
            {
                Debug.DrawLine(ray.origin, raycastHit.point, Color.green, duration);

                if (TryGetComponent<Equipment>(out Equipment equipment))
                {
                    equipment.Operate();
                }
            }
        }

    }
}
