using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
        _board.MovePlayerToMiami();
    }
}
