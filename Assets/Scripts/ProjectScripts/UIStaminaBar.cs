using UnityEngine;
using System.Collections;

public class UIStaminaBar : MonoBehaviour
{
	public Stamina stamina;
	public UISlider bar;

	// Update is called once per frame
	void Update ()
	{
		if (bar != null) {
			bar.sliderValue = stamina.CalculateDisplayPercent ();
		} else {
			Debug.LogWarning ("Stamina Slider not set in editor. Attach slider to StaminaBar script in HUD.");
		}
	}
}