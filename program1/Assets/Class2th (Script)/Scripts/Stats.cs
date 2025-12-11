using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int strength=5;
    public int wisdom=1;
    public int dexterity=0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Strength : " + strength);
        Debug.Log("Strength : " + wisdom);
        Debug.Log("Strength : " + dexterity);
    }
}
