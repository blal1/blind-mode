using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000522")]
public abstract class BindingTextBase<BINDING_TEXT, TARGET> : Binding where BINDING_TEXT : BindingTextBase<BINDING_TEXT, TARGET> where TARGET : MonoBehaviour
{
	[Token(Token = "0x400191D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	private string textId;

	[Token(Token = "0x400191E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	private bool richText;

	[Token(Token = "0x400191F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	private bool replaceNbsp;

	[Token(Token = "0x4001920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private object[] m_formatArg;

	[Token(Token = "0x17000365")]
	[SerializeField]
	public string TextId
	{
		[Token(Token = "0x600214D")]
		get
		{
			return null;
		}
		[Token(Token = "0x600214E")]
		set
		{
		}
	}

	[Token(Token = "0x17000366")]
	public bool RichText
	{
		[Token(Token = "0x600214F")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002150")]
		set
		{
		}
	}

	[Token(Token = "0x17000367")]
	public bool ReplaceNbsp
	{
		[Token(Token = "0x6002151")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002152")]
		set
		{
		}
	}

	[Token(Token = "0x600214A")]
	public static void ForceRebindAllText()
	{
	}

	[Token(Token = "0x600214B")]
	public static void ForceRebindAllTextInChildren(GameObject parent, bool includeInactive)
	{
	}

	[Token(Token = "0x600214C")]
	public static void SetText(BINDING_TEXT bindingText, string id, [Optional] object[] formatArg)
	{
	}

	[Token(Token = "0x6002153")]
	public override void OnRebind()
	{
	}

	[Token(Token = "0x6002154")]
	public override bool OnBinding()
	{
		return default(bool);
	}

	[Token(Token = "0x6002155")]
	protected abstract void SetText(TARGET target, string text);

	[Token(Token = "0x6002156")]
	protected abstract string GetText(TARGET target);

	[Token(Token = "0x6002157")]
	public void SetFromatArg(object[] arg)
	{
	}

	[Token(Token = "0x6002158")]
	private static object[] AdjustFormatArg(string str, object[] formatArg)
	{
		return null;
	}

	[Token(Token = "0x6002159")]
	protected BindingTextBase()
	{
	}
}
