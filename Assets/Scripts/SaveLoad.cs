using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{

	public Transform CurrentPlayerPosition;

	void Update()
	{

		if (Input.GetKeyDown(KeyCode.R))
			savePosition();

		if (Input.GetKeyDown(KeyCode.L))
			if (PlayerPrefs.HasKey("PosX"))
				loadPosition();

		if (Input.GetKeyDown(KeyCode.D))
			PlayerPrefs.DeleteAll();
	}

	public void savePosition()
	{

		Transform CurrentPlayerPosition = this.gameObject.transform;

		PlayerPrefs.SetFloat("PosX", CurrentPlayerPosition.position.x);
		PlayerPrefs.SetFloat("PosY", CurrentPlayerPosition.position.y);
		PlayerPrefs.SetFloat("PosZ", CurrentPlayerPosition.position.z);

		PlayerPrefs.SetFloat("AngX", CurrentPlayerPosition.eulerAngles.x);
		PlayerPrefs.SetFloat("AngY", CurrentPlayerPosition.eulerAngles.y);

		PlayerPrefs.SetString("level", Application.loadedLevelName);
		PlayerPrefs.SetInt("level_id", Application.loadedLevel);
	}

	public void loadPosition()
	{

		Transform CurrentPlayerPosition = this.gameObject.transform;

		Vector3 PlayerPosition = new Vector3(PlayerPrefs.GetFloat("PosX"),
					PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
		Vector3 PlayerDirection = new Vector3(PlayerPrefs.GetFloat("AngX"),
					PlayerPrefs.GetFloat("AngY"), 0);

		CurrentPlayerPosition.position = PlayerPosition;
		CurrentPlayerPosition.eulerAngles = PlayerDirection;
	}
}