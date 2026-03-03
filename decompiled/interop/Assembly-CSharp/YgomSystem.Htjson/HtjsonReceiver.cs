using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Htjson;

[Token(Token = "0x20001E6")]
public interface HtjsonReceiver
{
	[Token(Token = "0x6000B93")]
	void HtjsonLink(object path);

	[Token(Token = "0x6000B94")]
	void SetOption(string key, object value);

	[Token(Token = "0x6000B95")]
	object GetOption(string key);

	[Token(Token = "0x6000B96")]
	Dictionary<string, object> GetOptions();

	[Token(Token = "0x6000B97")]
	void RegisterId(string id, GameObject entry);

	[Token(Token = "0x6000B98")]
	List<GameObject> GetIdObjects(string id);

	[Token(Token = "0x6000B99")]
	string GetIdObjectName(GameObject go);
}
