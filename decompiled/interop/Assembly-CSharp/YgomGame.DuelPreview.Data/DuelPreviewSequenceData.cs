using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E3F")]
[CreateAssetMenu]
public class DuelPreviewSequenceData : ScriptableObject
{
	[Token(Token = "0x400A2C4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CardRunEffectSetting.Position m_EffectPosition;

	[Token(Token = "0x400A2C5")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool m_UseCenterEffectBySetting;

	[Token(Token = "0x400A2C6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<DuelPreviewTaskData> m_TaskDatas;

	[Token(Token = "0x17000CF8")]
	public CardRunEffectSetting.Position effectPosition
	{
		[Token(Token = "0x6005649")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		get
		{
			return default(CardRunEffectSetting.Position);
		}
	}

	[Token(Token = "0x17000CF9")]
	public bool useCenterEffectBySetting
	{
		[Token(Token = "0x600564A")]
		[Address(RVA = "0x9B6B90", Offset = "0x9B5D90", VA = "0x1809B6B90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000CFA")]
	public List<DuelPreviewTaskData> taskDatas
	{
		[Token(Token = "0x600564B")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600564C")]
	[Address(RVA = "0x9B6B10", Offset = "0x9B5D10", VA = "0x1809B6B10")]
	public DuelPreviewSequenceData()
	{
	}
}
