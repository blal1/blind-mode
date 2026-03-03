using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame;

[Token(Token = "0x20006E3")]
public class PopUpTextManager
{
	[Token(Token = "0x20006E4")]
	private struct PUTData
	{
		[Token(Token = "0x40022BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<string> text;

		[Token(Token = "0x40022BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool isforui;

		[Token(Token = "0x6002E01")]
		[Address(RVA = "0x71DA70", Offset = "0x71CC70", VA = "0x18071DA70")]
		public PUTData(Func<string> text, bool isforui)
		{
		}
	}

	[Token(Token = "0x20006E5")]
	public enum Mode
	{
		[Token(Token = "0x40022C1")]
		OnPointerEnter,
		[Token(Token = "0x40022C2")]
		OnSelected
	}

	[Token(Token = "0x40022B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool isSpecialWinEffect;

	[Token(Token = "0x40022B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject m_Template;

	[Token(Token = "0x40022BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<PopUpText> m_FreeInstanceQueue;

	[Token(Token = "0x40022BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Queue<PopUpText> m_AllInstanceQueue;

	[Token(Token = "0x40022BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<Mode, Dictionary<SelectionButton, PUTData>> m_PopUpBtnTable;

	[Token(Token = "0x40022BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<SelectionButton, PopUpText> m_SbtnPutTable;

	[Token(Token = "0x170005B0")]
	public bool Initialized
	{
		[Token(Token = "0x6002DF0")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002DF1")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002DF2")]
	[Address(RVA = "0x71E560", Offset = "0x71D760", VA = "0x18071E560")]
	public static PopUpTextManager Create([Optional] UnityAction onFinish)
	{
		return null;
	}

	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x71E800", Offset = "0x71DA00", VA = "0x18071E800")]
	private void Initialize(UnityAction onFinish)
	{
	}

	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x71F590", Offset = "0x71E790", VA = "0x18071F590")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x71ED10", Offset = "0x71DF10", VA = "0x18071ED10")]
	public void RegistPopUpCallback(SelectionButton sbtn, Func<string> text, bool isforui = true, Mode mode = Mode.OnPointerEnter, [Optional] UnityAction onHideCallback, bool followTarget = false)
	{
	}

	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0x71EA10", Offset = "0x71DC10", VA = "0x18071EA10")]
	private void OnEnterPopUpArea(SelectionButton sbtn, Mode mode = Mode.OnPointerEnter, bool followTarget = false)
	{
	}

	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x71EC60", Offset = "0x71DE60", VA = "0x18071EC60")]
	private void OnExitPopUpArea(SelectionButton sbtn)
	{
	}

	[Token(Token = "0x6002DF8")]
	[Address(RVA = "0x71F340", Offset = "0x71E540", VA = "0x18071F340")]
	public void RemovePopUpCallback(SelectionButton sbtn, Mode mode = Mode.OnPointerEnter, bool removeFromTbl = false)
	{
	}

	[Token(Token = "0x6002DF9")]
	[Address(RVA = "0x71F050", Offset = "0x71E250", VA = "0x18071F050")]
	public void RemoveCallbackAll()
	{
	}

	[Token(Token = "0x6002DFA")]
	[Address(RVA = "0x71F680", Offset = "0x71E880", VA = "0x18071F680")]
	public bool UpdatePopUpText(SelectionButton sbtn, Func<string> text, Mode mode = Mode.OnPointerEnter)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DFB")]
	[Address(RVA = "0x71F830", Offset = "0x71EA30", VA = "0x18071F830")]
	public void UpdateTextData(SelectionButton sbtn, Mode mode, Func<string> text)
	{
	}

	[Token(Token = "0x6002DFC")]
	[Address(RVA = "0x71E6E0", Offset = "0x71D8E0", VA = "0x18071E6E0")]
	public void HidePopUpText()
	{
	}

	[Token(Token = "0x6002DFD")]
	[Address(RVA = "0x71E670", Offset = "0x71D870", VA = "0x18071E670")]
	private PopUpText GetPutInstance()
	{
		return null;
	}

	[Token(Token = "0x6002DFE")]
	[Address(RVA = "0x71E370", Offset = "0x71D570", VA = "0x18071E370")]
	private void CreatePutInstance()
	{
	}

	[Token(Token = "0x6002DFF")]
	[Address(RVA = "0x71F530", Offset = "0x71E730", VA = "0x18071F530")]
	private void ReturnInstance(PopUpText instance)
	{
	}

	[Token(Token = "0x6002E00")]
	[Address(RVA = "0x71F9B0", Offset = "0x71EBB0", VA = "0x18071F9B0")]
	public PopUpTextManager()
	{
	}
}
