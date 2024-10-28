//Ex:1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Githup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
         int counter = 0;
         while(true)
        {
            int randomNumber = Random.Range(1,21);
             counter++;
             if(randomNumber == 5)continue;
             else if (randomNumber == 15) break;
             Debug.Log(randomNumber);
        }

    }
    //Ex:2
    

}


