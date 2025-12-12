using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    private void Awake()
    {
        // 클래스가 생성되는 시점에서 한번만 호출, 클래스가 비활성화되어
        // 있어도 호출되는 이벤트 함수
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // Time Step에 설정된 값에따라 일정한 간격으로 호출되는 이베트 함수
        Debug.Log("Fixed Update");
    }

    private void Update()
    {
        // 매 프레임마다 호출되는 함수
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        //Update이후 호출되는 ㅏㅁ수
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        // 게임오브젝트가 비활성화 될떄마다 호출되는 이벤트 함수입니다.
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        
    }
}
