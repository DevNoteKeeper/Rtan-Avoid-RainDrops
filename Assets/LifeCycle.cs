using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //초기화
    void Awake(){
        Debug.Log("플레이어데이터가 준비");
    }

    //활성화
    //awake보다는 늦게 start 보다는 빠르게 실행되는 부분
    //키고 끌때마다 실행됨
    void OnEnable() {
        Debug.Log("로그인");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    

    //물리 + 게임로직 = 프레임


    //물리 파트
    //물리 연산을 하기 전에 실행되는 부분, 고정적으로 호출을 함(고정된 주기로 실행)
    //CPU 사용 과다, 1초에 50회 정도 호출됨
    //물리연산과 관련된 코드만 작성함
    void FixedUpdate() {
        Debug.Log("이동~");
    }

    //게임로직 파트
    // Update is called once per frame
    //게임 로직, 물리 연산 제외 환경에 따라서 실행주기가 떨어질 수 있음
    //60fram으로 실행됨
    void Update()
    {
        Debug.Log("몬스터 사냥");
    }
    //로직 후처리, 캐릭터를 따라가는 카메라
    //update 실행 뒤 실행됨
    void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }
    //게임 오브젝트가 비활성화 되었을 때
    void OnDisable() {
        
    }

    //해체
    //게임오브젝트가 삭제가 될때 뭘 남기고 사라질지
    void OnDestroy() {
        Debug.Log("플레이어 데이터가 해체하였습니다");
    }


}
