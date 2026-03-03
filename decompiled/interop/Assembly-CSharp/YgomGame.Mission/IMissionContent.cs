using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Mission;

[Token(Token = "0x2000C19")]
public interface IMissionContent
{
	[Token(Token = "0x17000A05")]
	bool initialized
	{
		[Token(Token = "0x60049E6")]
		get;
	}

	[Token(Token = "0x17000A06")]
	Dictionary<string, object> Args
	{
		[Token(Token = "0x60049E7")]
		get;
		[Token(Token = "0x60049E8")]
		set;
	}

	[Token(Token = "0x17000A07")]
	TextGroupLoadHolder textGroupLoadHolder
	{
		[Token(Token = "0x60049E9")]
		get;
		[Token(Token = "0x60049EA")]
		set;
	}

	[Token(Token = "0x17000A08")]
	Func<int, int> onGetSelectorPriorityAdditional
	{
		[Token(Token = "0x60049EB")]
		get;
		[Token(Token = "0x60049EC")]
		set;
	}

	[Token(Token = "0x14000068")]
	event Action onRequestedPopVC;

	[Token(Token = "0x14000069")]
	event Action onRequestedRefreshBadge;

	[Token(Token = "0x1400006A")]
	event Action onRequestedTopPanelTransition;

	[Token(Token = "0x1400006B")]
	event Action<SelectionButton> onRequestedClickContent;

	[Token(Token = "0x60049ED")]
	void SetActiveFooter(bool active);

	[Token(Token = "0x60049F6")]
	IEnumerator yInitialize(ElementObjectManager eom, Action onComplete, bool isOnlyMission = false, bool isSelectTab = false);

	[Token(Token = "0x60049F7")]
	void SetSurfaceActive(bool active);

	[Token(Token = "0x60049F8")]
	Selector GetSelector();

	[Token(Token = "0x60049F9")]
	int GetSelectorPriorityAdditional(int addPos);

	[Token(Token = "0x60049FA")]
	void NotificationStackEntry();

	[Token(Token = "0x60049FB")]
	void NotificationStackRemove();

	[Token(Token = "0x60049FC")]
	void TransitionStart(ViewController.TransitionType type);
}
