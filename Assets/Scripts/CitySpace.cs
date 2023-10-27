using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitySpace : MonoBehaviour
{
    private static int maxDiseaseCubes = 3;
    private int diseaseCubesOnCity = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setDiseaseCubes(int diseaseAmount)
    {
        diseaseCubesOnCity = diseaseAmount;
    }
}
