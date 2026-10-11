using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Vector3 targetPosition;
    private Vector3 mousePosition;

    private SpriteRenderer barnabee;
    
    [SerializeField] private float moveSpeed = 3f; 

    void Start()
    {
        barnabee = GetComponentInChildren<SpriteRenderer>();
        targetPosition = new Vector3(0, 0, 0);
       // CursorLockMode.Confined
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        if (targetPosition.Equals(transform.position))
        {
            barnabee.drawMode = SpriteDrawMode.Tiled;
        }
    }

    public void OnClick()
    {
        mousePosition = new Vector3(Mouse.current.position.x.ReadValue(), Mouse.current.position.y.ReadValue(), 0f);
        
        //if (mousePosition.x < 900 && mousePosition.x > 0 && mousePosition.y < 500 && mousePosition.y > 0) //bound click range
        //{
        Debug.Log("mouse: " + mousePosition.x + ", " + mousePosition.y + ", " + mousePosition.z);
        
        



        mousePosition.z = Mathf.Abs(Camera.main.transform.position.z);
        Vector3 relativePosition = Camera.main.ScreenToWorldPoint(mousePosition);
    
        targetPosition = new Vector3(relativePosition.x, relativePosition.y, transform.position.z);
        barnabee.drawMode = SpriteDrawMode.Sliced;
        //flip barnabee
        if (targetPosition.x - transform.position.x > 0)
        {
            barnabee.flipX = true;
        }
        else
        {
            barnabee.flipX = false;
        }
       // }
    }

}
