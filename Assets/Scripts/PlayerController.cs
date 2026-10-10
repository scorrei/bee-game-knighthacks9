using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Vector3 targetPosition;
    private Vector3 mousePosition;
    
    [SerializeField] private float moveSpeed = 3f; 

    void Start()
    {
        
        targetPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    public void OnClick()
    {
        mousePosition = new Vector3(Mouse.current.position.x.ReadValue(), Mouse.current.position.y.ReadValue(), 0f);
        
        if (mousePosition.x < 900 && mousePosition.x > 0 && mousePosition.y < 500 && mousePosition.y > 0) //bound click range
        {
            Debug.Log("mouse: " + mousePosition.x + ", " + mousePosition.y + ", " + mousePosition.z);
            
            mousePosition.z = Mathf.Abs(Camera.main.transform.position.z);
            Vector3 relativePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
            targetPosition = new Vector3(relativePosition.x, relativePosition.y, transform.position.z);
        }
    }
    
}
