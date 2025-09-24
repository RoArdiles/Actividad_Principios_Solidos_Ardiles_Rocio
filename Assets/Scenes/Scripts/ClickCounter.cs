using UnityEngine;
using UnityEngine.InputSystem;

public class ClickCounter : MonoBehaviour, IClickHandler
{
    private int count = 0;

    public void HandleClick()
    {
        count++;
        Debug.Log("Clic numero: " + count);
    }
}