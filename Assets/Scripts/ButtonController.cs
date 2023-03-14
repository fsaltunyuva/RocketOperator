using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    private bool canMove = false;
    
    public void Continue()
    {
        canvas.SetActive(false);
        canMove = true;
    }

    public void setcanMove(bool obj)
    {
        canMove = obj;
    }

    public bool getcanMove()
    {
        return canMove;
    }
    

    
}
