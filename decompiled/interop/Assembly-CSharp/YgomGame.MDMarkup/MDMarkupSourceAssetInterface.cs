using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CB4")]
public abstract class MDMarkupSourceAssetInterface : ScriptableObject, IMDMarkupSourceAsset, IMDMarkupSource
{
	[Token(Token = "0x4009BD4")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, object> m_Args;

	[Token(Token = "0x17000AE8")]
	protected Dictionary<string, object> Args
	{
		[Token(Token = "0x6004CFD")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AE9")]
	public bool isValidData
	{
		[Token(Token = "0x6004CFE")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004CFF")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6004D00")]
	[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80", Slot = "4")]
	public void SetArgs(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004D01")]
	public abstract IEnumerator ySetup();

	[Token(Token = "0x6004D02")]
	public abstract void Output(List<IMDMarkupContent> res);

	[Token(Token = "0x6004D03")]
	[Address(RVA = "0x958710", Offset = "0x957910", VA = "0x180958710")]
	protected MDMarkupSourceAssetInterface()
	{
	}
}
