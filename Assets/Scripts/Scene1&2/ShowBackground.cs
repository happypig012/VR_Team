using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class SpriteRendererClickHandler : MonoBehaviour
    {
        // 스프라이트 배열
        [SerializeField]
        public Sprite[] sprites;

        // 현재 표시되는 스프라이트의 인덱스
        private int currentIndex = 0;

        // SpriteRenderer 컴포넌트
        private SpriteRenderer spriteRenderer;

        void Start()
        {
            // SpriteRenderer 컴포넌트 가져오기
            spriteRenderer = GetComponent<SpriteRenderer>();

            // 처음에 첫 번째 스프라이트 표시
            spriteRenderer.sprite = sprites[currentIndex];
        }

        // SpriteRenderer 클릭 이벤트 핸들러
        void OnMouseDown()
        {
            // 다음 스프라이트 인덱스로 이동
            currentIndex++;

            // 인덱스가 배열 범위를 벗어나면 처음으로 돌아감
            if (currentIndex >= sprites.Length)
            {
                spriteRenderer.gameObject.SetActive(false);
            }

            // 다음 스프라이트 표시
            spriteRenderer.sprite = sprites[currentIndex];
        }
    }

