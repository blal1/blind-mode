using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Utility;

[Serializable]
[Token(Token = "0x2000912")]
public class GlobalTextData
{
	[Token(Token = "0x400897C")]
	[FieldOffset(Offset = "0x10")]
	public bool useId;

	[Token(Token = "0x400897D")]
	[FieldOffset(Offset = "0x18")]
	public string tid;

	[Token(Token = "0x400897E")]
	[FieldOffset(Offset = "0x20")]
	[TextArea(1, 5)]
	public string ja_JP;

	[Token(Token = "0x400897F")]
	[FieldOffset(Offset = "0x28")]
	[TextArea(1, 5)]
	public string en_US;

	[Token(Token = "0x4008980")]
	[FieldOffset(Offset = "0x30")]
	[TextArea(1, 5)]
	public string fr_FR;

	[Token(Token = "0x4008981")]
	[FieldOffset(Offset = "0x38")]
	[TextArea(1, 5)]
	public string it_IT;

	[Token(Token = "0x4008982")]
	[FieldOffset(Offset = "0x40")]
	[TextArea(1, 5)]
	public string de_DE;

	[Token(Token = "0x4008983")]
	[FieldOffset(Offset = "0x48")]
	[TextArea(1, 5)]
	public string es_ES;

	[Token(Token = "0x4008984")]
	[FieldOffset(Offset = "0x50")]
	[TextArea(1, 5)]
	public string pt_BR;

	[Token(Token = "0x4008985")]
	[FieldOffset(Offset = "0x58")]
	[TextArea(1, 5)]
	public string ko_KR;

	[Token(Token = "0x4008986")]
	[FieldOffset(Offset = "0x60")]
	[TextArea(1, 5)]
	public string zh_TW;

	[Token(Token = "0x4008987")]
	[FieldOffset(Offset = "0x68")]
	[TextArea(1, 5)]
	public string zh_CN;

	[Token(Token = "0x4008988")]
	[FieldOffset(Offset = "0x70")]
	public List<string> args;

	[Token(Token = "0x4008989")]
	[FieldOffset(Offset = "0x78")]
	private string m_ParsedTid;

	[Token(Token = "0x400898A")]
	[FieldOffset(Offset = "0x80")]
	private string m_TextGroup;

	[Token(Token = "0x400898B")]
	[FieldOffset(Offset = "0x88")]
	private string m_TextId;

	[Token(Token = "0x400898C")]
	[FieldOffset(Offset = "0x90")]
	private List<object> m_BoxedArgs;

	[Token(Token = "0x400898D")]
	[FieldOffset(Offset = "0x98")]
	private TextGroupLoadHolder m_TextHolder;

	[Token(Token = "0x17000688")]
	public string rawText
	{
		[Token(Token = "0x600366C")]
		[Address(RVA = "0x7BCFB0", Offset = "0x7BC1B0", VA = "0x1807BCFB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600366D")]
		[Address(RVA = "0x7BDD70", Offset = "0x7BCF70", VA = "0x1807BDD70")]
		set
		{
		}
	}

	[Token(Token = "0x600366E")]
	[Address(RVA = "0x7BC470", Offset = "0x7BB670", VA = "0x1807BC470")]
	public void Clear()
	{
	}

	[Token(Token = "0x600366F")]
	[Address(RVA = "0x7BD740", Offset = "0x7BC940", VA = "0x1807BD740")]
	private void ParseTextId()
	{
	}

	[Token(Token = "0x6003670")]
	[Address(RVA = "0x7BCA70", Offset = "0x7BBC70", VA = "0x1807BCA70")]
	public void FormatByParams(object[] formatParams)
	{
	}

	[Token(Token = "0x6003671")]
	[Address(RVA = "0x7BD680", Offset = "0x7BC880", VA = "0x1807BD680")]
	public void LoadCheckTextHolder(TextGroupLoadHolder textHolder)
	{
	}

	[Token(Token = "0x6003672")]
	[Address(RVA = "0x7BD010", Offset = "0x7BC210", VA = "0x1807BD010")]
	public string GetTextGroup()
	{
		return null;
	}

	[Token(Token = "0x6003673")]
	[Address(RVA = "0x7BD090", Offset = "0x7BC290", VA = "0x1807BD090")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x6003674")]
	[Address(RVA = "0x7BCBA0", Offset = "0x7BBDA0", VA = "0x1807BCBA0")]
	public string GetConvertedText()
	{
		return null;
	}

	[Token(Token = "0x6003675")]
	public void SetTextId<T>(T textId)
	{
	}

	[Token(Token = "0x6003676")]
	[Address(RVA = "0x7BCFB0", Offset = "0x7BC1B0", VA = "0x1807BCFB0")]
	public string GetRawText()
	{
		return null;
	}

	[Token(Token = "0x6003677")]
	[Address(RVA = "0x7BD860", Offset = "0x7BCA60", VA = "0x1807BD860")]
	public void SetRawText(string rawText)
	{
	}

	[Token(Token = "0x6003678")]
	[Address(RVA = "0x7BC680", Offset = "0x7BB880", VA = "0x1807BC680")]
	public GlobalTextData Copy()
	{
		return null;
	}

	[Token(Token = "0x6003679")]
	[Address(RVA = "0x7BC560", Offset = "0x7BB760", VA = "0x1807BC560")]
	public void CopyTo(GlobalTextData target)
	{
	}

	[Token(Token = "0x600367A")]
	[Address(RVA = "0x7BCD10", Offset = "0x7BBF10", VA = "0x1807BCD10")]
	private string GetLangText(string langKey)
	{
		return null;
	}

	[Token(Token = "0x600367B")]
	[Address(RVA = "0x7BC7D0", Offset = "0x7BB9D0", VA = "0x1807BC7D0")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x600367C")]
	[Address(RVA = "0x7BD170", Offset = "0x7BC370", VA = "0x1807BD170")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x600367D")]
	[Address(RVA = "0x7BDB30", Offset = "0x7BCD30", VA = "0x1807BDB30")]
	private void SetupBoxedArgs()
	{
	}

	[Token(Token = "0x600367E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public GlobalTextData()
	{
	}
}
