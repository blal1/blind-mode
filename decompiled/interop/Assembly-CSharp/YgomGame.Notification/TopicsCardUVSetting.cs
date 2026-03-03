using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Notification;

[Serializable]
[Token(Token = "0x2000C44")]
[CreateAssetMenu(menuName = "Scriptable Object/Topics/TopicsCardUVSetting")]
public class TopicsCardUVSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000C45")]
	public class ThumbSetting
	{
		[Token(Token = "0x4009AA4")]
		[FieldOffset(Offset = "0x10")]
		public string mrk;

		[Token(Token = "0x4009AA5")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 uvRectPos;

		[Token(Token = "0x4009AA6")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 uvRectSize;

		[Token(Token = "0x6004ACB")]
		[Address(RVA = "0x9487F0", Offset = "0x9479F0", VA = "0x1809487F0")]
		public ThumbSetting(string mrk)
		{
		}

		[Token(Token = "0x6004ACC")]
		[Address(RVA = "0x948740", Offset = "0x947940", VA = "0x180948740")]
		public void ImportRawImage(RawImage rawImage)
		{
		}

		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x9487E0", Offset = "0x9479E0", VA = "0x1809487E0")]
		public void ImportUVRect(Vector2 pos, Vector2 size)
		{
		}

		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0x7787D0", Offset = "0x7779D0", VA = "0x1807787D0")]
		public void ExportRawImage(RawImage rawImage)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C46")]
	public class SettingMap
	{
		[Token(Token = "0x4009AA7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<ThumbSetting> m_Settings;

		[Token(Token = "0x4009AA8")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, ThumbSetting> m_SettingsMap;

		[Token(Token = "0x17000A2A")]
		public List<ThumbSetting> Settings
		{
			[Token(Token = "0x6004ACF")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AD0")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			private set
			{
			}
		}

		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x947330", Offset = "0x946530", VA = "0x180947330")]
		public ThumbSetting GetSetting(string mrk)
		{
			return null;
		}

		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0x947AD0", Offset = "0x946CD0", VA = "0x180947AD0")]
		public bool IsExists(string mrk)
		{
			return default(bool);
		}

		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0x9477F0", Offset = "0x9469F0", VA = "0x1809477F0")]
		public void Import(string mrk, RawImage rawImage)
		{
		}

		[Token(Token = "0x6004AD4")]
		[Address(RVA = "0x947930", Offset = "0x946B30", VA = "0x180947930")]
		public void Import(string mrk, Vector2 pos, Vector2 size)
		{
		}

		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x947A20", Offset = "0x946C20", VA = "0x180947A20")]
		public void Import(string mrk)
		{
		}

		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x947C90", Offset = "0x946E90", VA = "0x180947C90")]
		public void Remove(string mrk)
		{
		}

		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x9475A0", Offset = "0x9467A0", VA = "0x1809475A0")]
		public void ImportWithSort(string mrk, RawImage rawImage)
		{
		}

		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x947D00", Offset = "0x946F00", VA = "0x180947D00")]
		public SettingMap()
		{
		}
	}

	[Token(Token = "0x4009AA3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SettingMap m_BannerMap;

	[Token(Token = "0x17000A29")]
	public SettingMap BannerMap
	{
		[Token(Token = "0x6004AC2")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004AC3")]
	[Address(RVA = "0x948AE0", Offset = "0x947CE0", VA = "0x180948AE0")]
	public ThumbSetting GetSetting(string mrk)
	{
		return null;
	}

	[Token(Token = "0x6004AC4")]
	[Address(RVA = "0x948E10", Offset = "0x948010", VA = "0x180948E10")]
	public bool IsExitsSetting(string mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AC5")]
	[Address(RVA = "0x948CD0", Offset = "0x947ED0", VA = "0x180948CD0")]
	public void ImportData(string mrk, RawImage rawImage)
	{
	}

	[Token(Token = "0x6004AC6")]
	[Address(RVA = "0x948B20", Offset = "0x947D20", VA = "0x180948B20")]
	public void ImportData(string mrk)
	{
	}

	[Token(Token = "0x6004AC7")]
	[Address(RVA = "0x948BE0", Offset = "0x947DE0", VA = "0x180948BE0")]
	public void ImportData(string mrk, Vector2 pos, Vector2 size)
	{
	}

	[Token(Token = "0x6004AC8")]
	[Address(RVA = "0x948EF0", Offset = "0x9480F0", VA = "0x180948EF0")]
	public void RemoveData(string mrk)
	{
	}

	[Token(Token = "0x6004AC9")]
	[Address(RVA = "0x948B00", Offset = "0x947D00", VA = "0x180948B00")]
	public void ImportDataWithSort(string mrk, RawImage rawImage)
	{
	}

	[Token(Token = "0x6004ACA")]
	[Address(RVA = "0x949040", Offset = "0x948240", VA = "0x180949040")]
	public TopicsCardUVSetting()
	{
	}
}
