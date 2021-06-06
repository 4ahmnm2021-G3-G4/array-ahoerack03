using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrays : MonoBehaviour
{
        //Arrays
        //Deklaration Arrays vom Datentym string, float und int
        string [] array;
        float [] array;
        int[] array;
        
       
        string[] array1 = new string [4];
        float[] array2 = new float {1f,2f,3f,4f};
        int[] array3 = {1,2,3,4}
        GameObject[] array4 = new GameObject[4];
    
    //1) Durchlaufen ausgeben der Werte 
    //2) Länge des Arrays ausgeben als Debug 
    //3) 2 Werte direkt ändern 
    //4) Gameobjects Images anlegen, Tag vergeben, zuweisen und Farbe ändern

    void Start()
    {
        foreach (float array2f in array2)
        {
            Debug.Log("array2_inhalt " + array2f);
        }
        Debug.Log("array1_length: " + array1.Length);
        array3[1] = 2;
        array3[2] = 1;
        array4 = GameObject.FindGameObjectsWithTag("BlueImage");
        array4[2].GetComponent<Image>().color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
