using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OpenCtrl : MonoBehaviour {

	// Use this for initialization

	//오프닝 창에서 아무데나 누르면 메인화면으로 넘어간다.

	public void OnButtonClicked()
	{
		SceneManager.LoadScene ("Main");
	}

	//메인화면에서 게임시작버튼누르면 스테이지화면으로넘어간다.
	public void OnStartButtonClicked()
	{
		SceneManager.LoadScene ("Stage");
	}

	//메인창에서 게임 설명 버튼 누르면 설명씬으로 넘어간다.
	public void OnExplainButtonClicked()
	{
		SceneManager.LoadScene ("Explain");
	}

	//메인창에서종료버튼누르면 게임이꺼진다.
	public void OnExitButtonClicked()
	{
		Application.Quit();
	}

	//back버튼을 누르면 메인화면으로 넘어간다.

	public void OnBackButtonClicked()
	{
		Application.Quit();
		SceneManager.LoadScene ("Main");
	}

	//스테이지씬에서 튜토리얼버튼을누르면 튜토리얼씬으로넘어간다.
	public void OnTutorialButtonClicked()
	{
		SceneManager.LoadScene ("Tutorial");
	}
}
