using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogTest : MonoBehaviour
{
	[SerializeField]
	private	DialogSystem	dialogSystem01;
	[SerializeField]
	private	TextMeshProUGUI	textCountdown;
	[SerializeField]
	private	DialogSystem2	dialogSystem02;

	private IEnumerator Start()
	{
		textCountdown.gameObject.SetActive(false);

		// 첫 번째 대사 분기 시작
		yield return new WaitUntil(()=>dialogSystem01.UpdateDialog());

		// 대사 분기 사이에 원하는 행동을 추가할 수 있다.
		textCountdown.gameObject.SetActive(true);
		int count = 0;
		while ( count > 0 )
		{
			textCountdown.text = count.ToString();
			count --;

			yield return new WaitForSeconds(1);
		}
		textCountdown.gameObject.SetActive(false);

		// 두 번째 대사 분기 시작
		yield return new WaitUntil(()=>dialogSystem02.UpdateDialog());

		textCountdown.gameObject.SetActive(true);

		yield return new WaitForSeconds(2);

		UnityEditor.EditorApplication.ExitPlaymode();
	}
}

