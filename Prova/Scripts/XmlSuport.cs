using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System;

public class XmlSupport 
{
	public static void Serialize<T>(string fileName,T obj)
	{
		if (File.Exists (fileName)) 
		{
			File.Delete(fileName);
		}
		XmlSerializer xs = new XmlSerializer (typeof(T));
		using (FileStream fs = new FileStream(fileName,FileMode.CreateNew))
		{
			using (StreamWriter wr = new StreamWriter(fs,Encoding.UTF8))
			{
				xs.Serialize(wr,obj);
			}
		}

	}
	public static T Deserialize<T>(string fileName)
	{
		XmlSerializer xs = new XmlSerializer (typeof(T));
		using (StreamReader rd = new StreamReader(fileName,System.Text.Encoding.UTF8,true)) 
		{
			return (T)xs.Deserialize(rd);
		}
	}
}