using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardScript : MonoBehaviour
{
    [SerializeField] private List<CitySpace> _citySpaces;
    [SerializeField] private Player _currentPlayer;
    [SerializeField] private GameObject _diseasePrefab;
    [SerializeField] private TMP_Text updateText;
    [SerializeField] List<String> _cityNames;

    // Start is called before the first frame update
    void Start()
    {
        int randomCity;
        for (int i = 0; i < 3; i++)
        {
            randomCity = Random.Range(1,24);
            _citySpaces[randomCity].setDiseaseCubes(Random.Range(1,3));
            _citySpaces[randomCity].spawnDiseaseCubes(_diseasePrefab);
        }
        
        _citySpaces[9].setDiseaseCubes(3);
        _citySpaces[9].spawnDiseaseCubes(_diseasePrefab);

        
        _currentPlayer.transform.position = _citySpaces[1].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnNewDiseases()
    {
        int randomCity;
        randomCity = Random.Range(0,24);
        int playerCurrentCity = CheckForPlayerOnCity();
        if (playerCurrentCity != randomCity)
        {
            _citySpaces[randomCity].setDiseaseCubes(Random.Range(1, 3));
            _citySpaces[randomCity].spawnDiseaseCubes(_diseasePrefab);
            updateText.text = "New Diseases spawned at " + _cityNames[randomCity];
        }
        else
        {
            updateText.text = "Player stopped disease at " + _cityNames[randomCity];
        }
    }
    
    
    
    public void MovePlayer(String movedMiami)
    {
        if (movedMiami.Equals("Miami"))
        {
            _currentPlayer.transform.position = _citySpaces[9].transform.position;
        }
        else
        {
            _currentPlayer.transform.position = _citySpaces[Random.Range(0, 24)].transform.position;
        }

    }

    public void TreatInfection(Vector3 transformPosition)
    {
        int diseaseCubesOnCity;
        for(int i = 0; i < 24; i++)
        {
            if (_citySpaces[i].transform.position == transformPosition)
            {
                diseaseCubesOnCity = _citySpaces[i].getDiseaseCubes();
                if (diseaseCubesOnCity > 0)
                {
                    _citySpaces[i].removeDiseaseCube();
                }

                break;
            }
        }
    }

    public int CheckForPlayerOnCity()
    {
        for(int i = 0; i < 24; i++)
        {
            if (_citySpaces[i].transform.position == _currentPlayer.transform.position)
            {
                return i;
                
            }
        }
        return -1;
    }
}
