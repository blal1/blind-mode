using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000452")]
public interface IGenericScrollViewSupport
{
	[Token(Token = "0x6001B9F")]
	void OnItemSetData(GameObject gob, int dataindex);

	[Token(Token = "0x6001BA0")]
	void OnItemEntry(GameObject gob, int dataindex);

	[Token(Token = "0x6001BA1")]
	void OnItemExit(GameObject gob, int dataindex);

	[Token(Token = "0x6001BA2")]
	void OnItemInitialize(GameObject gob);

	[Token(Token = "0x6001BA3")]
	void OnGsvStanby();

	[Token(Token = "0x6001BA4")]
	void UpdateLayout();
}
