using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    
     private Vector2 mousePosition;
     private BeePathfinding bee;

    void Start()
    {
        bee = gameObject.GetComponentInChildren<BeePathfinding>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = new Vector2(Mouse.current.position.x.ReadValue(), Mouse.current.position.y.ReadValue());
    }

    public void OnClick()
    {
        Debug.Log("mouse: " + mousePosition.x + ", " + mousePosition.y);
        bee.moveBee(mousePosition);
    }
    
}
