using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200124B")]
public class BaseMenuViewController : TweenViewController
{
	[Token(Token = "0x400BAFA")]
	private const string k_ArgKeyUIPrefOverride = "UIPref";

	[Token(Token = "0x400BAFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected ViewCreater m_ViewCreater;

	[Token(Token = "0x400BAFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected ElementObjectManager m_View;

	[Token(Token = "0x400BAFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Selector m_ViewSelector;

	[Token(Token = "0x400BAFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected List<GameObject> m_AdditionalTweenTarget;

	[Token(Token = "0x400BAFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<IAsyncProgressContent> m_AsyncProgressContents;

	[Token(Token = "0x400BB00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<IAsyncProgressContent> m_AsyncProgressDeleteCache;

	[Token(Token = "0x400BB01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int m_LoadingCount;

	[Token(Token = "0x400BB02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool isLoading;

	[Token(Token = "0x400BB03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
	private bool isStartedProgress;

	[Token(Token = "0x400BB04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB6")]
	private bool isDispedProgress;

	[Token(Token = "0x400BB05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private UnityAction startedProgressCallback;

	[Token(Token = "0x400BB06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x400BB07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private string m_FixedOutGameBgPath;

	[Token(Token = "0x170011F5")]
	public TextGroupLoadHolder textGroupLoadHolder
	{
		[Token(Token = "0x60071DE")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F6")]
	protected virtual bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x60071DF")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170011F7")]
	protected virtual bool setProgressOnInitialize
	{
		[Token(Token = "0x60071E0")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170011F8")]
	protected virtual ResourceManager.UnloadCheckLevel unloadCheckLevel
	{
		[Token(Token = "0x60071E1")]
		[Address(RVA = "0xB72240", Offset = "0xB71440", VA = "0x180B72240", Slot = "19")]
		get
		{
			return default(ResourceManager.UnloadCheckLevel);
		}
	}

	[Token(Token = "0x170011F9")]
	protected virtual int outGameBgId
	{
		[Token(Token = "0x60071E2")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170011FA")]
	protected string outGameBgPath
	{
		[Token(Token = "0x60071E3")]
		[Address(RVA = "0xB72130", Offset = "0xB71330", VA = "0x180B72130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011FB")]
	protected bool isExistsLoading
	{
		[Token(Token = "0x60071E4")]
		[Address(RVA = "0xB72120", Offset = "0xB71320", VA = "0x180B72120")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170011FC")]
	public bool IsLoading
	{
		[Token(Token = "0x60071E5")]
		[Address(RVA = "0xB720C0", Offset = "0xB712C0", VA = "0x180B720C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60071E6")]
		[Address(RVA = "0xAA4FB0", Offset = "0xAA41B0", VA = "0x180AA4FB0")]
		set
		{
		}
	}

	[Token(Token = "0x170011FD")]
	protected virtual Type[] textIds
	{
		[Token(Token = "0x60071E7")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011FE")]
	protected Selector m_Selector
	{
		[Token(Token = "0x60071E8")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071E9")]
		[Address(RVA = "0xB72260", Offset = "0xB71460", VA = "0x180B72260")]
		set
		{
		}
	}

	[Token(Token = "0x60071EA")]
	[Address(RVA = "0xB70C40", Offset = "0xB6FE40", VA = "0x180B70C40")]
	protected bool IsPlayingTransition(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60071EB")]
	[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
	protected void SetStartedProgressCallback([Optional] UnityAction callback)
	{
	}

	[Token(Token = "0x60071EC")]
	[Address(RVA = "0xB715C0", Offset = "0xB707C0", VA = "0x180B715C0")]
	protected void ResetStartedProgressCallback()
	{
	}

	[Token(Token = "0x60071ED")]
	[Address(RVA = "0xB713A0", Offset = "0xB705A0", VA = "0x180B713A0", Slot = "9")]
	public override float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x60071EE")]
	[Address(RVA = "0xB71060", Offset = "0xB70260", VA = "0x180B71060", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x60071EF")]
	[Address(RVA = "0xB70E40", Offset = "0xB70040", VA = "0x180B70E40", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60071F0")]
	[Address(RVA = "0xB71750", Offset = "0xB70950", VA = "0x180B71750", Slot = "5")]
	public override void SetVisibleOnInitialize(bool visible)
	{
	}

	[Token(Token = "0x60071F1")]
	[Address(RVA = "0xB70B10", Offset = "0xB6FD10", VA = "0x180B70B10")]
	protected void CreateView()
	{
	}

	[Token(Token = "0x60071F2")]
	[Address(RVA = "0xB715E0", Offset = "0xB707E0", VA = "0x180B715E0", Slot = "22")]
	protected virtual void SetSelectorLabelAsUnique()
	{
	}

	[Token(Token = "0x60071F3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "23")]
	protected virtual void OnCreatedView()
	{
	}

	[Token(Token = "0x60071F4")]
	[Address(RVA = "0xB70F20", Offset = "0xB70120", VA = "0x180B70F20", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60071F5")]
	[Address(RVA = "0xB71920", Offset = "0xB70B20", VA = "0x180B71920", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60071F6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "24")]
	protected virtual void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60071F7")]
	[Address(RVA = "0xB71AD0", Offset = "0xB70CD0", VA = "0x180B71AD0", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60071F8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "25")]
	protected virtual void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x60071F9")]
	[Address(RVA = "0xB70F60", Offset = "0xB70160", VA = "0x180B70F60", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60071FA")]
	[Address(RVA = "0xB709D0", Offset = "0xB6FBD0", VA = "0x180B709D0")]
	protected void AssignProgressContent(IAsyncProgressContent progressContent)
	{
	}

	[Token(Token = "0x60071FB")]
	[Address(RVA = "0xB70780", Offset = "0xB6F980", VA = "0x180B70780")]
	protected void AssignProgressContent(IAsyncProgressContainer progressContainer)
	{
	}

	[Token(Token = "0x60071FC")]
	[Address(RVA = "0x61EA20", Offset = "0x61DC20", VA = "0x18061EA20")]
	protected void AddLoadingCount()
	{
	}

	[Token(Token = "0x60071FD")]
	[Address(RVA = "0x61FA80", Offset = "0x61EC80", VA = "0x18061FA80")]
	protected void DecLoadingCount()
	{
	}

	[Token(Token = "0x60071FE")]
	[Address(RVA = "0xB70A80", Offset = "0xB6FC80", VA = "0x180B70A80")]
	public void ChangeCreateType(ViewCreater.CreateType type)
	{
	}

	[Token(Token = "0x60071FF")]
	[Address(RVA = "0xB70FC0", Offset = "0xB701C0", VA = "0x180B70FC0", Slot = "26")]
	protected virtual void OnTransitionSetBg(TransitionType type)
	{
	}

	[Token(Token = "0x6007200")]
	[Address(RVA = "0xB71480", Offset = "0xB70680", VA = "0x180B71480", Slot = "27")]
	protected virtual void PushBackBg()
	{
	}

	[Token(Token = "0x6007201")]
	[Address(RVA = "0xB71FB0", Offset = "0xB711B0", VA = "0x180B71FB0")]
	public BaseMenuViewController()
	{
	}
}
