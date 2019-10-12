using System.Collections;// using은 미리 만들어진 코드를 가져오는 것입니다.
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 주석 , 컴퓨터가 처리하지 않는 라인 - 메모로 사용
        /*
         * 
        */

        // 콘솔 출력
        Debug.Log("Hello World");

        // 숫자형 변수
        int age = 23;
        int money = -1000;


        Debug.Log(age);
        Debug.Log(money);

        // floating point - float : 소숫점을 가지는 실수 32비트
        // 소숫점 아래 7자리까지만 정확합니다.
        float height = 169.1234567f;

        // float 의 2배 메모리 사용 64비트 사용
        // 소숫점 아래 15자리만 정확
        double pi = 3.14159265359;

        bool isBoy = true;
        bool isGirl = false;

        // char character 는 한 문자
        char grade = 'A';

        // string 은 문장
        string movieTitle = "러브라이브";

        Debug.Log("내 나이는 : " + age);
        Debug.Log("내 키는 : " + height);


        // var 는 할당하는 값을 기준으로 타입을 결정
        var myName = "I_Jemin";
        var myAge = 23;

        Debug.Log("제민의 닉네임 : " + myName);





    }
}
