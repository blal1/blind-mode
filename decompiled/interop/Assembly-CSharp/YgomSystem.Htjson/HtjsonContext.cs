using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Htjson;

[Token(Token = "0x20001E7")]
public interface HtjsonContext
{
	[Token(Token = "0x6000B9A")]
	void SetTextColor(Color col);

	[Token(Token = "0x6000B9B")]
	Color GetTextColor();

	[Token(Token = "0x6000B9C")]
	void InsertItem(Transform item);

	[Token(Token = "0x6000B9D")]
	void SetStyle(string id, object dic);

	[Token(Token = "0x6000B9E")]
	Dictionary<string, object> GetStyle(string id);

	[Token(Token = "0x6000B9F")]
	HtjsonReceiver GetReceiver();

	[Token(Token = "0x6000BA0")]
	string ProcPath(string path);

	[Token(Token = "0x6000BA1")]
	void AddReplaceParam(Dictionary<string, object> param);

	[Token(Token = "0x6000BA2")]
	Dictionary<string, object> GetReplaceParam();
}
