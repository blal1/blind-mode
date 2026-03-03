using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Solo;

[Token(Token = "0x2000882")]
[CreateAssetMenu(menuName = "Scriptable Object/SoloCardThumbSettings")]
public class SoloCardThumbSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000883")]
	public class ThumbSetting
	{
		[Token(Token = "0x400868C")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400868D")]
		[FieldOffset(Offset = "0x14")]
		public int mrk;

		[Token(Token = "0x400868E")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 uvRectPos;

		[Token(Token = "0x400868F")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 uvRectSize;

		[Token(Token = "0x4008690")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 uvRectPosOther;

		[Token(Token = "0x4008691")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 uvRectSizeOther;

		[Token(Token = "0x600338B")]
		[Address(RVA = "0x7788D0", Offset = "0x777AD0", VA = "0x1807788D0")]
		public ThumbSetting(int id)
		{
		}

		[Token(Token = "0x600338C")]
		[Address(RVA = "0x778880", Offset = "0x777A80", VA = "0x180778880")]
		public void ImportRawImage(RawImage rawImage)
		{
		}

		[Token(Token = "0x600338D")]
		[Address(RVA = "0x778830", Offset = "0x777A30", VA = "0x180778830")]
		public void ImportRawImageOther(RawImage rawImage)
		{
		}

		[Token(Token = "0x600338E")]
		[Address(RVA = "0x7787D0", Offset = "0x7779D0", VA = "0x1807787D0")]
		public void ExportRawImage(RawImage rawImage)
		{
		}

		[Token(Token = "0x600338F")]
		[Address(RVA = "0x778770", Offset = "0x777970", VA = "0x180778770")]
		public void ExportRawImageOther(RawImage rawImage)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000884")]
	private class SettingMap
	{
		[Token(Token = "0x4008692")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<ThumbSetting> m_Settings;

		[Token(Token = "0x4008693")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, ThumbSetting> m_SettingsMap;

		[Token(Token = "0x6003390")]
		[Address(RVA = "0x769650", Offset = "0x768850", VA = "0x180769650")]
		public ThumbSetting GetSetting(int id)
		{
			return null;
		}

		[Token(Token = "0x6003391")]
		[Address(RVA = "0x769A70", Offset = "0x768C70", VA = "0x180769A70")]
		public bool IsExists(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6003392")]
		[Address(RVA = "0x7698F0", Offset = "0x768AF0", VA = "0x1807698F0")]
		public void Import(int id, int mrk, RawImage rawImage, RawImage rawImageOther)
		{
		}

		[Token(Token = "0x6003393")]
		[Address(RVA = "0x769B40", Offset = "0x768D40", VA = "0x180769B40")]
		public void RemoveData(int id)
		{
		}

		[Token(Token = "0x6003394")]
		[Address(RVA = "0x769C90", Offset = "0x768E90", VA = "0x180769C90")]
		public SettingMap()
		{
		}
	}

	[Token(Token = "0x2000888")]
	public enum Format
	{
		[Token(Token = "0x4008698")]
		Gate,
		[Token(Token = "0x4008699")]
		Chapter,
		[Token(Token = "0x400869A")]
		LootSource
	}

	[Token(Token = "0x4008689")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SettingMap m_GateMap;

	[Token(Token = "0x400868A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SettingMap m_ChapterMap;

	[Token(Token = "0x400868B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SettingMap m_LootSourceMap;

	[Token(Token = "0x6003386")]
	[Address(RVA = "0x769D50", Offset = "0x768F50", VA = "0x180769D50")]
	public ThumbSetting GetSetting(Format format, int id)
	{
		return null;
	}

	[Token(Token = "0x6003387")]
	[Address(RVA = "0x769E00", Offset = "0x769000", VA = "0x180769E00")]
	public bool IsExitsSetting(Format format, int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6003388")]
	[Address(RVA = "0x769DA0", Offset = "0x768FA0", VA = "0x180769DA0")]
	public void ImportData(Format format, int id, int mrk, RawImage rawImage, RawImage rawImageOther)
	{
	}

	[Token(Token = "0x6003389")]
	[Address(RVA = "0x769E50", Offset = "0x769050", VA = "0x180769E50")]
	public void RemoveData(Format format, int id)
	{
	}

	[Token(Token = "0x600338A")]
	[Address(RVA = "0x769E90", Offset = "0x769090", VA = "0x180769E90")]
	public SoloCardThumbSettings()
	{
	}
}
