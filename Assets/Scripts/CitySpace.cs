using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitySpace : MonoBehaviour
{
    private static int maxDiseaseCubes = 3;
    private int diseaseCubesOnCity = 0;
    private List<GameObject> thisCityDisease;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnDiseaseCubes(GameObject diseasePrefab)
    {
        Vector3 diseasePosistion = new Vector3(0.1f, -0.1f, 0);
        for (int i = 0; i < diseaseCubesOnCity; i++)
        {
            GameObject thisCityDisease = Instantiate(diseasePrefab, transform.position + (diseasePosistion*i), Quaternion.identity);
            thisCityDisease.transform.parent = transform;
        }
    }

    public void removeDiseaseCube()
    {
        if (diseaseCubesOnCity > 0)
        {
            Destroy(transform.GetChild(0).gameObject);
            diseaseCubesOnCity--;
        }
        else
        {
            Debug.Log("NO DISEASES TO TREAT");
        }
        
    }
    
    public void setDiseaseCubes(int diseaseAmount)
    {
        diseaseCubesOnCity = diseaseAmount;
    }

    public int getDiseaseCubes()
    {
        return diseaseCubesOnCity;
    }
}
