using System.Collections;
using System.Collections.Generic ;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEngine.UI;

[RequireComponent(typeof(TextMesh))]

public class textGet : MonoBehaviour
{
    public static List<string> textArray;

    private bool display;
    private TextMesh textComp;

    [SerializeField]

    public int[] rowsToReadFrom;


    public string Filename;

    private TextAsset textAsset;



    void start()
    {
        textAsset = Resources.Load("textFiles/" + Filename) as TextAsset;
        textComp = GetComponent<TextMesh>();
        ReadTextFile();
        // Update i 5 called once per frame 
    }



    // Update is called once per frame
    void Update()
    {
        if (display)
        {
            GetComponent<Renderer>().enabled = true;
        }
        else if (!display)
        {
            GetComponent<Renderer>().enabled = false;
        }

    }

    public void ReadTextFile()
    {
        textArray = textAsset.text.Split('\n').ToList();
        // Strings. Close ( ) ; 
        for (int i = 0; i < rowsToReadFrom.Length; i++)
        {
            if (rowsToReadFrom[0] < 0 || rowsToReadFrom.Length == 0)
            {
                textComp.text = textAsset.text;//textCorp.text File. ReadAIIText (filePeth); 

            }
            else
            {
                textComp.text += textArray[rowsToReadFrom[i]] + "\n";
            }
        }



    }


}


    


