using UnityEngine;
using UnityEngine.InputSystem;

public class ClickDetector : MonoBehaviour
{
    public MonoBehaviour clickHandlerComponent;
    private IClickHandler clickHandler;

    void Start()
    {
        clickHandler = clickHandlerComponent as IClickHandler;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            clickHandler?.HandleClick();
        }
    }
}