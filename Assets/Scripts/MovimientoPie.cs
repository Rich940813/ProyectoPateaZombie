using UnityEngine;

public class MovimientoPie : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    void Awake()
    {
        inputActions = new InputSystem_Actions();
    }   
    
    void OnEnable()
    {
        inputActions.Player.Enable();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detectar mouse position
    }
}
