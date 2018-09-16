using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using MiniJSON;

public class JsonTool : Singleton<JsonTool> {

	public string jsonPath = "xxxxx";

	public Dictionary<string, object> LoadJson(string path)
	{
		string jsonData = ReadJsonFile(path);
		Dictionary<string, object> result = Json.Deserialize(jsonData) as Dictionary<string, object>;
		return result;
	}

	public string ReadJsonFile(string path)
    {
        string json = string.Empty;
        using (FileStream fs = new FileStream(path, FileMode.Open, System.IO.FileAccess.Read, FileShare.ReadWrite))
        {
            using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("UTF-8")))
            {
                json = sr.ReadToEnd().ToString();
            }
        }
        return json;
    }


}
