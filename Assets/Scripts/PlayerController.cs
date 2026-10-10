using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    
     private Vector3 targetPosition;
     private Vector3 mousePosition;
     //private BeePathfinding bee;

    /*void Start()
    {
        bee = gameObject.GetComponentInChildren<BeePathfinding>();
    }*/

    // Update is called once per frame
    void Update()
    {
        mousePosition = new Vector3(Mouse.current.position.x.ReadValue(), Mouse.current.position.y.ReadValue(), 0f);
    }

    public void OnClick()
    {
        Debug.Log("mouse: " + mousePosition.x + ", " + mousePosition.y + ", " + mousePosition.z);
        
        mousePosition.z = Mathf.Abs(Camera.main.transform.position.z);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
    
        targetPosition = new Vector3(worldPosition.x, worldPosition.y, transform.position.z);
      
        this.transform.position = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
    }
    
}
