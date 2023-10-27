using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    [SerializeField] private List<CitySpace> _citySpaces;
    [SerializeField] private Player _currentPlayer;
    

    // Start is called before the first frame update
    void Start()
    {
        int randomCity;
        for (int i = 0; i < 3; i++)
        {
            randomCity = Random.Range(0,14);
            _citySpaces[randomCity].setDiseaseCubes(Random.Range(1,3));
        }

        _currentPlayer.transform.position = _citySpaces[1].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovePlayerToMiami()
    {
        Debug.Log("Moved Miami");
        _currentPlayer.transform.position = _citySpaces[7].transform.position;
    }
}
