using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    private int Score;
    private int NumberOfLevel;
    private List<Vector3> SavePoint;
    private Vector3 PositionStartL;
    private Vector3 PositionEndL;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void setScore(int Score)
    {
        this.Score = Score;
    }

    public int getScore()
    {
        return Score;
    }
    public void setNumberOfLevel(int NumberOfLevel)
    {
        this.NumberOfLevel = NumberOfLevel;
    }

    public int getNumberOfLevel()
    {
        return NumberOfLevel;
    }


}
