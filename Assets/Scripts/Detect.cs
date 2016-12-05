using UnityEngine;
using System.Collections;

public class Detect : MonoBehaviour
{

    public GameObject trace;
    void Update()
    {
        GameObject go = Instantiate(trace);
        go.transform.position = this.transform.position;
    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name);
    }
}
