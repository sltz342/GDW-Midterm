using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputActions
{
    private static Controls controls;

    public static void Init(Player myPlayer)
    {
        controls = new Controls();
        Debug.Log("Fuck");
        controls.Game.Move.performed += ctx =>
        {
            Debug.Log("Called Miami");
            myPlayer.MoveToMiami();
        };
        
        controls.Enable();
    }
    
    
}
