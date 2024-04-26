using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    // 클릭하여 숨길 버튼
    public Button button;

    // Start() 함수는 처음 실행될 때 호출됩니다.
    void Start()
    {
        // 버튼의 클릭 이벤트에 함수 연결
        button.onClick.AddListener(HideButton);
    }

    // 버튼 숨기는 함수
    void HideButton()
    {
        // 버튼 비활성화
        button.gameObject.SetActive(false);
    }
}
