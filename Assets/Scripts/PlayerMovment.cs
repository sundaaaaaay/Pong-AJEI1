using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovment : MonoBehaviour
{

    [SerializeField] private float playerMovment = 5;

    [SerializeField] bool player1;
    [SerializeField] bool player2;


    void Update()
    {
        Vector3 dir = new Vector3(0, 0);

        if (player1 == true)//Keyboard (player1)
        {
            
            //W
            if (Keyboard.current.wKey.isPressed)
            {
                dir.y = 1;
            }
            //S
            if (Keyboard.current.sKey.isPressed)
            {
                dir.y = -1;
            }
        }
        else//Arrow Keys (player2)
        {
            //up Arrow
            if (Keyboard.current.upArrowKey.isPressed)
            {
                dir.y = 1;
            }
            //down Arrow
            if (Keyboard.current.downArrowKey.isPressed)
            {
                dir.y = -1;
            }
        }

        transform.position = transform.position + dir * playerMovment * Time.deltaTime;

                        

    }
}
