using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atmosphere : MonoBehaviour {
	public float windStrength;
	public Vector3 windDirection;
	public float turbulence;

	public float groundTemprature;

	// meters per second
	public Vector3 getWindSpeed(Vector3 position) {
		return windDirection * windStrength * Mathf.Log10(position.y);
	}

	// degrees C
	public float getTemprature(Vector3 position){
		return 15.04f - 0.00649f * position.y;
	}

	// kPa
	public float getPressure(Vector3 position){
		return 101.29f * Mathf.Pow(((getTemprature (position) + 273.1f) / 288.08f), 5.256f);
	}

	public float getDensity(Vector3 position){
		return getPressure (position) / (0.2869f * (getTemprature (position) + 273.1f));
	}
}
