using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Equation : MonoBehaviour {

	
	[SerializeField]
	private int _state;
	[SerializeField]
	private int _equationValue;
	[SerializeField]
	private bool _initialized = false;


	void Start() {
		_state = 0;

	}

	public int state{
		get{return _state;}
		set{_state = value;}
	}

	public bool initialized{
		get{return _initialized;}
		set{_initialized = value;}
	}

	public int equationValue{
		get{return _equationValue;}
		set{_equationValue = value;}
	}
	

	public void setEquation(){
		if (_state == 0)
			_state = 1;
	}

	
}
