using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E35")]
[CreateAssetMenu]
public class DuelPreviewAsset : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000E36")]
	public class DuelEffectMap
	{
		[Token(Token = "0x400A2A8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DuelEffectPool.Type m_Type;

		[Token(Token = "0x400A2A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_Path;

		[Token(Token = "0x17000CEA")]
		public DuelEffectPool.Type type
		{
			[Token(Token = "0x6005626")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			get
			{
				return default(DuelEffectPool.Type);
			}
		}

		[Token(Token = "0x17000CEB")]
		public string path
		{
			[Token(Token = "0x6005627")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005628")]
		[Address(RVA = "0x9B3EE0", Offset = "0x9B30E0", VA = "0x1809B3EE0")]
		public DuelEffectMap()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000E37")]
	public class DurationOverride
	{
		[Token(Token = "0x2000E38")]
		public enum Behaviour
		{
			[Token(Token = "0x400A2AE")]
			Override,
			[Token(Token = "0x400A2AF")]
			Add
		}

		[Token(Token = "0x400A2AA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Label;

		[Token(Token = "0x400A2AB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Duration;

		[Token(Token = "0x400A2AC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Behaviour m_Behaviour;

		[Token(Token = "0x17000CEC")]
		public string label
		{
			[Token(Token = "0x6005629")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CED")]
		public float duration
		{
			[Token(Token = "0x600562A")]
			[Address(RVA = "0x52B490", Offset = "0x52A690", VA = "0x18052B490")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000CEE")]
		public Behaviour behaviour
		{
			[Token(Token = "0x600562B")]
			[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
			get
			{
				return default(Behaviour);
			}
		}

		[Token(Token = "0x600562C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DurationOverride()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000E39")]
	public class Params
	{
		[Token(Token = "0x400A2B0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Key;

		[Token(Token = "0x400A2B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_Value;

		[Token(Token = "0x17000CEF")]
		public string key
		{
			[Token(Token = "0x600562D")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF0")]
		public string value
		{
			[Token(Token = "0x600562E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600562F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Params()
		{
		}
	}

	[Token(Token = "0x400A2A3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int m_Mrk;

	[Token(Token = "0x400A2A4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DuelPreviewSequenceData m_SequenceData;

	[Token(Token = "0x400A2A5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<DuelEffectMap> m_DuelEffectMaps;

	[Token(Token = "0x400A2A6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<DurationOverride> m_DurationOverrides;

	[Token(Token = "0x400A2A7")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<Params> m_Params;

	[Token(Token = "0x17000CE8")]
	public int mrk
	{
		[Token(Token = "0x6005620")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000CE9")]
	public DuelPreviewSequenceData sequenceData
	{
		[Token(Token = "0x6005621")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005622")]
	[Address(RVA = "0x9B3EF0", Offset = "0x9B30F0", VA = "0x1809B3EF0")]
	public string FindParam(string key)
	{
		return null;
	}

	[Token(Token = "0x6005623")]
	[Address(RVA = "0x9B4190", Offset = "0x9B3390", VA = "0x1809B4190")]
	public string SearchDuelEffectPath(DuelEffectPool.Type effectType)
	{
		return null;
	}

	[Token(Token = "0x6005624")]
	[Address(RVA = "0x9B4050", Offset = "0x9B3250", VA = "0x1809B4050")]
	public DurationOverride GetDurationOverride(string label)
	{
		return null;
	}

	[Token(Token = "0x6005625")]
	[Address(RVA = "0x9B42D0", Offset = "0x9B34D0", VA = "0x1809B42D0")]
	public DuelPreviewAsset()
	{
	}
}
