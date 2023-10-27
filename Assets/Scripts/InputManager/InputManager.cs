using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static Controls controls;
    public static void Init(Player myPlayer)
    {
        controls = new Controls();
        
        
        controls.Game.Move.performed += ctx =>
        {
            Debug.Log("Called Miami");
            
            myPlayer.MoveToMiami();
        };
        
        controls.Enable();
    }
    
    
}
