using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teather : MonoBehaviour {
	public Kite kite;
	public Generator generator;

	private 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float getTension(){
		// ((air_density*(wind_speed**2))/(2))*self.kite_area*cos(self.zenith_ang)*(self.kite_glide_ratio+1)*sqrt((self.kite_glide_ratio**2)+1)
		return 0.0f;
	}
}
