using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Htjson;

[Token(Token = "0x20001E9")]
public class HtjsonNode : MonoBehaviour, HtjsonContext
{
	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x20")]
	private bool getColor;

	[Token(Token = "0x4000A67")]
	[FieldOffset(Offset = "0x21")]
	private bool parentGet;

	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x22")]
	private bool replaceGet;

	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x24")]
	private Color textColor;

	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, object> replaceParam;

	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x40")]
	private HtjsonContext parentContext;

	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<string, object> styles;

	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0xC0AA90", Offset = "0xC09C90", VA = "0x180C0AA90", Slot = "13")]
	public virtual void SetTextColor(Color col)
	{
	}

	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0xC09B80", Offset = "0xC08D80", VA = "0x180C09B80", Slot = "14")]
	public virtual void AddReplaceParam(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0xC0AAA0", Offset = "0xC09CA0", VA = "0x180C0AAA0")]
	private bool StandbyParentContext()
	{
		return default(bool);
	}

	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0xC0A4E0", Offset = "0xC096E0", VA = "0x180C0A4E0", Slot = "15")]
	public virtual Color GetTextColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0xC09E80", Offset = "0xC09080", VA = "0x180C09E80", Slot = "16")]
	public virtual Dictionary<string, object> GetReplaceParam()
	{
		return null;
	}

	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0xC09DA0", Offset = "0xC08FA0", VA = "0x180C09DA0", Slot = "9")]
	public HtjsonReceiver GetReceiver()
	{
		return null;
	}

	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0xC0A840", Offset = "0xC09A40", VA = "0x180C0A840", Slot = "10")]
	public string ProcPath(string path)
	{
		return null;
	}

	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0xC0A5E0", Offset = "0xC097E0", VA = "0x180C0A5E0")]
	public void LoadStyle(string path)
	{
	}

	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0xC0A9D0", Offset = "0xC09BD0", VA = "0x180C0A9D0", Slot = "7")]
	public void SetStyle(string id, object dic)
	{
	}

	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0xC0A170", Offset = "0xC09370", VA = "0x180C0A170", Slot = "8")]
	public Dictionary<string, object> GetStyle(string id)
	{
		return null;
	}

	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "17")]
	public virtual void InsertItem(Transform item)
	{
	}

	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	public virtual void InsertItemList(List<object> list)
	{
	}

	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void InsertItemHtjson(object obj)
	{
	}

	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "19")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0xC0A930", Offset = "0xC09B30", VA = "0x180C0A930")]
	public void SetBgEnable(bool enable)
	{
	}

	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void SetNodeParam(Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0xC0ABF0", Offset = "0xC09DF0", VA = "0x180C0ABF0")]
	public HtjsonNode()
	{
	}
}
