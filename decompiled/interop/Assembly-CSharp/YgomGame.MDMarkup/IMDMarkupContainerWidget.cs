using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CD1")]
public interface IMDMarkupContainerWidget
{
	[Token(Token = "0x6004D85")]
	void Initialize(IMDMarkupContainer containerData);

	[Token(Token = "0x6004D86")]
	void Output(MDMarkupGraphFactory graphFactory, Action onComplete);

	[Token(Token = "0x6004D87")]
	void OnStart(Dictionary<string, object> args);

	[Token(Token = "0x6004D88")]
	GameObject FindById(string id);
}
