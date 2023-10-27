using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    [SerializeField] private List<CitySpace> _citySpaces;
    [SerializeField] private Player _currentPlayer;
    [SerializeField] private GameObject _diseasePrefab;

    // Start is called before the first frame update
    void Start()
    {
        int randomCity;
        for (int i = 0; i < 3; i++)
        {
            randomCity = Random.Range(0,14);
            _citySpaces[randomCity].setDiseaseCubes(Random.Range(1,3));
            _citySpaces[randomCity].spawnDiseaseCubes(_diseasePrefab);
        }
        
        _citySpaces[7].setDiseaseCubes(3);
        _citySpaces[7].spawnDiseaseCubes(_diseasePrefab);

        
        _currentPlayer.transform.position = _citySpaces[1].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnNewDiseases()
    {
        int randomCity;
        randomCity = Random.Range(0,14);
        _citySpaces[randomCity].setDiseaseCubes(Random.Range(1,3));
        _citySpaces[randomCity].spawnDiseaseCubes(_diseasePrefab);
        
    }
    
    
    
    public void MovePlayerToMiami()
    {
        Debug.Log("Moved Miami");
        _currentPlayer.transform.position = _citySpaces[7].transform.position;
    }

    public void TreatInfection(Vector3 transformPosition)
    {
        int diseaseCubesOnCity;
        for(int i = 0; i < 14; i++)
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
}
