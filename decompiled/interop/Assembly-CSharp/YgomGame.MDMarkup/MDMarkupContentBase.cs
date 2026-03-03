using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C7A")]
public abstract class MDMarkupContentBase : IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId, ISerializationCallbackReceiver
{
	[Token(Token = "0x4009B27")]
	[FieldOffset(Offset = "0x10")]
	public string id;

	[Token(Token = "0x4009B29")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, object> m_Args;

	[Token(Token = "0x17000A49")]
	public abstract MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004B7B")]
		get;
	}

	[Token(Token = "0x17000A4A")]
	public abstract int contentIndent
	{
		[Token(Token = "0x6004B7C")]
		get;
	}

	[Token(Token = "0x17000A4B")]
	public virtual bool isValidData
	{
		[Token(Token = "0x6004B7D")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004B7E")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770", Slot = "18")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000A4C")]
	protected Dictionary<string, object> Args
	{
		[Token(Token = "0x6004B7F")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A4D")]
	private string YgomGame_002EMDMarkup_002EIMDMarkupId_002Eid
	{
		[Token(Token = "0x6004B80")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B81")]
	[Address(RVA = "0x936D20", Offset = "0x935F20", VA = "0x180936D20", Slot = "19")]
	public virtual void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004B82")]
	[Address(RVA = "0x936D90", Offset = "0x935F90", VA = "0x180936D90", Slot = "7")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004B83")]
	[Address(RVA = "0x936EF0", Offset = "0x9360F0", VA = "0x180936EF0", Slot = "8")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004B84")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "20")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6004B85")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "21")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6004B86")]
	protected abstract object OnExportJsonObj(object jsonObj);

	[Token(Token = "0x6004B87")]
	protected abstract void OnImportJsonObj(object jsonObj);

	[Token(Token = "0x6004B88")]
	[Address(RVA = "0x936FA0", Offset = "0x9361A0", VA = "0x180936FA0", Slot = "6")]
	public string ToJson()
	{
		return null;
	}

	[Token(Token = "0x6004B89")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380", Slot = "9")]
	public void SetArgs(Dictionary<string, object> value)
	{
	}

	[Token(Token = "0x6004B8A")]
	[Address(RVA = "0x936FB0", Offset = "0x9361B0", VA = "0x180936FB0")]
	protected MDMarkupContentBase()
	{
	}
}
