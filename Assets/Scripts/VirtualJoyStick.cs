using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 키보드, 마우스,터치 이벤트를 오브젝트에 보낼 수 있는 기능 지원

public class VirtualJoyStick : MonoBehaviour,IBeginDragHandler, IDragHandler,IEndDragHandler
{
    [SerializeField]
    private RectTransform Lever;            //레버
    private RectTransform RectTransform;    //조이스틱

    [SerializeField, Range(10,150)]
    private float LeverRange;

    private Vector2 InputDirection;
    private bool isInput;

    [SerializeField]
    private TPSCharacterController controller;



    private void Awake()
    {
        RectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData) //드래그 시작
    {
        ControlJoySticklever(eventData);
        isInput = true;
    }

    public void OnDrag(PointerEventData eventData) //드래그 중, 움직임을 멈추면 이벤트가 들어오지 않는 특성이 있음 -> 캐릭터의 이동을 update함수에 구현해야하는 이유
    {
        ControlJoySticklever(eventData);
    }

    public void OnEndDrag(PointerEventData eventData) //드래그 끝
    {
        Lever.anchoredPosition = Vector2.zero;
        isInput = false;
        controller.Move(Vector2.zero);
    }

    private void InputControlVector() //캐릭터에게 입력 벡터 전달
    {
        controller.Move(InputDirection);
      //  Debug.Log(InputDirection.x + " / " + InputDirection.y);
    }

    private void ControlJoySticklever(PointerEventData eventData)
    {
        var inputPos = eventData.position - RectTransform.anchoredPosition;
        var inputVector = inputPos.magnitude < LeverRange ? inputPos : inputPos.normalized * LeverRange;
        Lever.anchoredPosition = inputVector;
        InputDirection = inputVector / LeverRange / 50;
    }


    // Update is called once per frame
    void Update()
    {
        if (isInput == true)
        {
            InputControlVector();

        }
        
    }
}
