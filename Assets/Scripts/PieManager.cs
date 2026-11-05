using UnityEngine;
using UnityEngine.InputSystem;

public class PieManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
           Debug.Log("Presionado el boton izquierdo en pantalla") ;
        }
    }
}
