using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPlacement : MonoBehaviour
{
    int[] zPosition = { -10, 0, 10 };
    int interval = 60;
    int antalForhindringer = 200;

    public GameObject[] forhindringer;

    // Start is called before the first frame update
    void Start()
    {
       //int firstforhindringz = -100;
        //int secondforhindringz = -200;
        
        for (int i = 1; i < antalForhindringer; i++)
        {
            List<GameObject> listForhindringer = new List<GameObject>();
            listForhindringer.AddRange(forhindringer);

            for (int j = 0; j < zPosition.Length; j++)
            {
                GameObject valgtForhindring = listForhindringer[Random.Range(0, listForhindringer.Count)];

                Instantiate(valgtForhindring, new Vector3(i * interval, valgtForhindring.transform.position.y, zPosition[j]), Quaternion.identity);
                listForhindringer.Remove(valgtForhindring);
            }


            /*for (int j = 1; j <= 3; j++)
            {
                int xCord = i * interval;
                int zCord = zPosition[Random.Range(0, 3)];

                int xCord2 = i * interval;
                int zCord2 = zPosition[Random.Range(0, 3)];

                while (firstforhindringz == zCord)
                {
                    zCord = zPosition[Random.Range(0, 3)];
                }

                GameObject valgtForhindring = forhindringer[Random.Range(0, forhindringer.Length)];

                Vector3 forhindringPosition = new Vector3(xCord, valgtForhindring.transform.position.y, zCord);

                Instantiate(valgtForhindring, forhindringPosition, Quaternion.identity);
                firstforhindringz = zCord;


                while (secondforhindringz == zCord2)
                {
                    zCord2 = zPosition[Random.Range(0, 3)];
                }

                GameObject valgtForhindring2 = forhindringer[Random.Range(0, forhindringer.Length)];

                Vector3 forhindringPosition2 = new Vector3(xCord2, valgtForhindring2.transform.position.y, zCord2);

                Instantiate(valgtForhindring2, forhindringPosition2, Quaternion.identity);
                secondforhindringz = zCord2;
            }*/      
        }     

        for (int i = 1; i <= 2; ++i)
        {
            Debug.Log("Outer: " + i);  // Executes 2 times

            // Inner loop
            for (int j = 1; j <= 3; j++)
            {
               Debug.Log(" Inner: " + j); // Executes 6 times (2 * 3)
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
