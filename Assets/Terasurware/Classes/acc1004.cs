using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class acc1004 : ScriptableObject
{	
	public List<Sheet> sheets = new List<Sheet> ();

	[System.SerializableAttribute]
	public class Sheet
	{
		public string name = string.Empty;
		public List<Param> list = new List<Param>();
	}

	[System.SerializableAttribute]
	public class Param
	{
		
		public double ac_x;
		public double ac_y;
		public double ac_z;
	}
}

