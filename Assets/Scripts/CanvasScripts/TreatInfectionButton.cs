using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatInfectionButton : MonoBehaviour
{
    [SerializeField] private BoardScript _board;

    [SerializeField] private Player _player;
    
    public void TreatInfectionClicked()
    {
        _board.TreatInfection(_player.transform.position);
    }

    public void SpawnInfectionClicked()
    {
        _board.spawnNewDiseases();
    }
}
