using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// playerInput을 받아 캐릭터 움직임
public class PlayerMovement : MonoBehaviour
{
    // 컴포넌트 가져오기
    public PlayerInput playerInput; // 입력 컴포넌트
    public PlayerRigidbody playerRigidbody; 

    // 전역변수
    public float walkSpeed;

    private void Start(){
        // 시작 시 사용할 컴포넌트 가져옴
        playerInput = GetComponent<playerInput>();
        playerRigidbody = GetComponent<playerRigidbody>();

    }
    private FixedUpdate(){
        // 키보드 입력으로 상하좌우 움직임
        // 마우스로 화면과 캐릭터를 회전
        Move();
        CameraRotation();
    }
    private void Move(){
        // playerInput 컴포넌트의 키보드 입력값을 가져온다
        //  방향을 나타내는 이동 벡터값 transform.right 좌우/x축, transform.forward 앞뒤/y축
        Vector3 moveVel = playerInput.hor * transform.right + playerInput.ver * transform.forward;

        // 대각선 이동을 위해 정규화 Vector 함수 대입에 .normalize 사용하거나
        // 함수.normalize를 사용한다
        moveVel.normalize();

        // movePosition으로 이동, 초당 움직임을 위해 deltaTime 사용
        playerRigidbody.MovePosition(playerRigidbody.position + moveVel * Time.deltaTime);
    }
    private void CameraRotation(){

    }
}
