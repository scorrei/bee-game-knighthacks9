using System.Numerics;
using Unity.Collections;
using UnityEngine;


public class BeePathfinding : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveBee(UnityEngine.Vector2 mousePosition)
    {
        this.transform.position = mousePosition;
        Debug.Log("Position changed to " + mousePosition);
    }
}
