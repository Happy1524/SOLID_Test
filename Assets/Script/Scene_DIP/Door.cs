using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, ISwitchable
{ //Open�� Close����� �ϴ� Ŭ����.
    private bool isActive;
    public bool IsActive => isActive;


    public void Activate()
    {
        isActive = true;
        Debug.Log("The door is Open.");
    }

    public void Deactivate()
    {
        isActive = false;
        Debug.Log("The door is Closed.");
    }
}
