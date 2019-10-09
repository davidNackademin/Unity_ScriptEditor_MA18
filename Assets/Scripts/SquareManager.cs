using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareManager : MonoBehaviour
{
    public GameObject squarePrefab;


    public void NewSquare()
    {
        Instantiate(squarePrefab);
    }


}
