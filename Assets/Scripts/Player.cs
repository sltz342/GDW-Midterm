using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool movedToMiamiAlready = false;
    [SerializeField] public BoardScript _board;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToMiami()
    {
        if (!movedToMiamiAlready)
        {
            movedToMiamiAlready = true;
            _board.MovePlayer("Miami");
        }
        else
        {
            _board.MovePlayer("");
        }
        
        
        
    }
}
