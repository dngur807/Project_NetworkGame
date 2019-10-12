using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloClass : MonoBehaviour // 유니티가 제공하는 기능 미리 받은 상태에서 사용 가능
{
    // Start is called before the first frame update
    void Start()
    {
        Animal jack = new Animal();
        jack.name = "JACK";
        jack.sound = "Bark";
        jack.weight = 4.5f;

        Animal nate = new Animal();
        nate.name = "nate";
        nate.sound = "Nyaa";
        nate.weight = 1.2f;


        nate = jack;

        nate.name = "JIMMY";

        Debug.Log(jack.name);
        Debug.Log(jack.sound);

        Debug.Log(nate.name);
        Debug.Log(nate.sound);


    }
}


public class Animal
{
    public string name;
    public string sound;
    public float weight;

}