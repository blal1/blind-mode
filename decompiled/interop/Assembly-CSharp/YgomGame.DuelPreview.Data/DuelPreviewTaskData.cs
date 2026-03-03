using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomGame.DuelPreview.Data;

[Serializable]
[Token(Token = "0x2000E48")]
public class DuelPreviewTaskData : DuelPreviewTaskRawData
{
	[Token(Token = "0x400A2F7")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("m_Children2")]
	private DuelPreviewTaskRawData[] m_Children;

	[Token(Token = "0x17000D09")]
	public DuelPreviewTaskRawData[] children
	{
		[Token(Token = "0x6005675")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005676")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTaskData()
	{
	}
}
