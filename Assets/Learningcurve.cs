using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learningcurve : MonoBehaviour
{

    public int CurrentAge = 30;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public string FirstName = "Harrison";
    public bool IsAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(30 + 1);
        Debug.Log(CurrentAge + 1);
        PrintMyName();
        ComputeAge();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void PrintMyName ()
    {
        Debug.Log("Jacque");
    }
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }
}
