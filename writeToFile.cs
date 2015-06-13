using UnityEngine;
using System.Collections;
using System.IO;
using System;


public class writeToFile : MonoBehaviour {

	public string fileName;
	public string gTextStr;
	// Use this for initialization
	public StreamWriter file1;
	public StreamReader file1Read;

	void Start () {
				
				print ("1");
				if (File.Exists(fileName)) {
					print ("File Already in use Dawg");
					file1Read = File.OpenText(fileName);
					string read = file1Read.ReadToEnd();
					gTextStr = (read);
					file1Read.Close();
					return;
				}
				print ("4");
				file1 = File.CreateText(fileName);
				file1.Close();

				
	}


	


	// Update is called once per frame
	void OnGUI () {
		gTextStr = GUI.TextField(new Rect (10, 10, 200, 200), gTextStr, 500); 
		if (GUI.Button (new Rect (10, 210, 100, 30), "save")) {
			file1 = File.CreateText(fileName);
			print(gTextStr);
			file1.WriteLine(gTextStr);
			file1.Close();

		}
		if (GUI.Button (new Rect (110, 210, 100, 30), "open")) {
			file1 = File.CreateText(fileName);
			print(gTextStr);
			file1.WriteLine(gTextStr);
			file1.Close();
		}
	}
}
