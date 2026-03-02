using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private InputAction thrust;
    private void OnEnable()
    {
        thrust.Enable();
        Debug.Log("Enabled");
    }
    private void Update(){
        if (thrust.IsPressed())
        {
            Debug.Log("space is pressed");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
}
