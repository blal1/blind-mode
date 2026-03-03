using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Notification;

[Serializable]
[Token(Token = "0x2000C3B")]
[CreateAssetMenu(menuName = "Scriptable Object/Topics/TopicsBannerSetting")]
public class TopicsBannerSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000C3C")]
	public class KeyValue
	{
		[Token(Token = "0x4009A99")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		[Token(Token = "0x4009A9A")]
		[FieldOffset(Offset = "0x18")]
		public string value;

		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0x9346D0", Offset = "0x9338D0", VA = "0x1809346D0")]
		public KeyValue()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C3D")]
	public class BannerJson
	{
		[Token(Token = "0x4009A9B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string id;

		[Token(Token = "0x4009A9C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<KeyValue> m_KeyValues;

		[Token(Token = "0x17000A26")]
		public string ID
		{
			[Token(Token = "0x6004AAA")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AAB")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			private set
			{
			}
		}

		[Token(Token = "0x6004AAC")]
		[Address(RVA = "0x931370", Offset = "0x930570", VA = "0x180931370")]
		public BannerJson(string id)
		{
		}

		[Token(Token = "0x6004AAD")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		public List<KeyValue> GetKeyValues()
		{
			return null;
		}

		[Token(Token = "0x6004AAE")]
		[Address(RVA = "0x931290", Offset = "0x930490", VA = "0x180931290")]
		public bool IsExistKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6004AAF")]
		[Address(RVA = "0x930EC0", Offset = "0x9300C0", VA = "0x180930EC0")]
		public string GetValueFromKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6004AB0")]
		[Address(RVA = "0x930FB0", Offset = "0x9301B0", VA = "0x180930FB0")]
		public void Import(Dictionary<string, object> dic)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C40")]
	public class SettingMap
	{
		[Token(Token = "0x4009A9F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<BannerJson> m_BannerJsons;

		[Token(Token = "0x17000A27")]
		public List<BannerJson> BannerJsons
		{
			[Token(Token = "0x6004AB5")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AB6")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A28")]
		public BannerJson this[string key]
		{
			[Token(Token = "0x6004AB7")]
			[Address(RVA = "0x947E40", Offset = "0x947040", VA = "0x180947E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x947BB0", Offset = "0x946DB0", VA = "0x180947BB0")]
		public bool IsExists(string id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004AB9")]
		[Address(RVA = "0x947250", Offset = "0x946450", VA = "0x180947250")]
		public void Delete(string id)
		{
		}

		[Token(Token = "0x6004ABA")]
		[Address(RVA = "0x947DC0", Offset = "0x946FC0", VA = "0x180947DC0")]
		public SettingMap()
		{
		}
	}

	[Token(Token = "0x4009A98")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SettingMap m_BannerMap;

	[Token(Token = "0x17000A25")]
	public SettingMap BannerMap
	{
		[Token(Token = "0x6004AA4")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004AA5")]
	[Address(RVA = "0x9489F0", Offset = "0x947BF0", VA = "0x1809489F0")]
	public bool IsExitsSetting(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AA6")]
	[Address(RVA = "0x9489D0", Offset = "0x947BD0", VA = "0x1809489D0")]
	public BannerJson GetSetting(string id)
	{
		return null;
	}

	[Token(Token = "0x6004AA7")]
	[Address(RVA = "0x9488C0", Offset = "0x947AC0", VA = "0x1809488C0")]
	public void DeleteSetting(string id)
	{
	}

	[Token(Token = "0x6004AA8")]
	[Address(RVA = "0x948A10", Offset = "0x947C10", VA = "0x180948A10")]
	public TopicsBannerSetting()
	{
	}
}
