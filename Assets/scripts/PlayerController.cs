using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//библиотеки 
public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1)* Time.deltaTime * speed);
        speed += 1;
    }
}
