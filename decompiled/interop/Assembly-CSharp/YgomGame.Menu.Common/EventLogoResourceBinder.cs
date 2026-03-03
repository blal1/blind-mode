using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Colosseum;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001468")]
public class EventLogoResourceBinder : ResourceBinderBase
{
	[Serializable]
	[Token(Token = "0x2001469")]
	public class EventLogoPathData
	{
		[Token(Token = "0x400C69D")]
		[FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_EventLogoPath;

		[Token(Token = "0x400C69E")]
		[FieldOffset(Offset = "0x18")]
		public string m_EventDeckSelectBGPath;

		[Token(Token = "0x400C69F")]
		[FieldOffset(Offset = "0x20")]
		public string m_EventBGPath;

		[Token(Token = "0x400C6A0")]
		[FieldOffset(Offset = "0x28")]
		public string m_DCBGPath;

		[Token(Token = "0x400C6A1")]
		[FieldOffset(Offset = "0x30")]
		public string m_DCDeckSelectBGPath;

		[Token(Token = "0x400C6A2")]
		[FieldOffset(Offset = "0x38")]
		public string k_EventLogoMonsterPrefabPath;

		[Token(Token = "0x400C6A3")]
		[FieldOffset(Offset = "0x40")]
		public string m_DeckSelectRankBGPath;

		[Token(Token = "0x400C6A4")]
		[FieldOffset(Offset = "0x48")]
		public string m_DeckSelectRateBGPath;

		[Token(Token = "0x400C6A5")]
		[FieldOffset(Offset = "0x50")]
		public string m_DeckSelectRankAndRateBGPath;

		[Token(Token = "0x6007F36")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public EventLogoPathData()
		{
		}
	}

	[Token(Token = "0x400C69C")]
	[FieldOffset(Offset = "0x10")]
	private EventLogoPathData m_PathData;

	[Token(Token = "0x6007F23")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(EventLogoPathData pathData)
	{
	}

	[Token(Token = "0x6007F24")]
	[Address(RVA = "0xC73850", Offset = "0xC72A50", VA = "0x180C73850")]
	public string GetLogoPath(int id, bool isLarge)
	{
		return null;
	}

	[Token(Token = "0x6007F25")]
	[Address(RVA = "0xC75450", Offset = "0xC74650", VA = "0x180C75450")]
	public BindingEventLogo BindEventLogo(Image target, int id, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007F26")]
	[Address(RVA = "0xC75260", Offset = "0xC74460", VA = "0x180C75260")]
	public BindingEventLogo BindEventLogo(GameObject target, object json)
	{
		return null;
	}

	[Token(Token = "0x6007F27")]
	[Address(RVA = "0xC75430", Offset = "0xC74630", VA = "0x180C75430")]
	public BindingEventLogo BindEventLogo(GameObject target, BindingEventLogo.Context context)
	{
		return null;
	}

	[Token(Token = "0x6007F28")]
	[Address(RVA = "0xC75930", Offset = "0xC74B30", VA = "0x180C75930")]
	public string GetLogoBGPath(int id)
	{
		return null;
	}

	[Token(Token = "0x6007F29")]
	[Address(RVA = "0xC75980", Offset = "0xC74B80", VA = "0x180C75980")]
	public string GetLogoPathWithCorrection(int id, bool isLarge)
	{
		return null;
	}

	[Token(Token = "0x6007F2A")]
	[Address(RVA = "0xC75810", Offset = "0xC74A10", VA = "0x180C75810")]
	public string GetLogoBGPathWithCorrection(int id)
	{
		return null;
	}

	[Token(Token = "0x6007F2B")]
	[Address(RVA = "0xC751E0", Offset = "0xC743E0", VA = "0x180C751E0")]
	public BindingImageEx BindEventLogoBG(Image target, int id, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F2C")]
	[Address(RVA = "0xC751B0", Offset = "0xC743B0", VA = "0x180C751B0")]
	public BindingImageEx BindEventLogoBG(Image target, string path, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F2D")]
	[Address(RVA = "0xC75750", Offset = "0xC74950", VA = "0x180C75750")]
	public string GetBGPath(int id, int stage)
	{
		return null;
	}

	[Token(Token = "0x6007F2E")]
	[Address(RVA = "0xC750E0", Offset = "0xC742E0", VA = "0x180C750E0")]
	public BindingImageEx BindEventBG(Image target, int id, int stage = 0, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F2F")]
	[Address(RVA = "0xC75A20", Offset = "0xC74C20", VA = "0x180C75A20")]
	public string GetTemplateBGPath(int id, int stage)
	{
		return null;
	}

	[Token(Token = "0x6007F30")]
	[Address(RVA = "0xC754F0", Offset = "0xC746F0", VA = "0x180C754F0")]
	public BindingImageEx BindEventTemplateBG(Image target, int id, int stage = 0, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F31")]
	[Address(RVA = "0x534350", Offset = "0x533550", VA = "0x180534350")]
	public string GetEventLogoMonsterPrefabPath()
	{
		return null;
	}

	[Token(Token = "0x6007F32")]
	[Address(RVA = "0xC75650", Offset = "0xC74850", VA = "0x180C75650")]
	public BindingImageEx BindRankDeckBG(GameObject target, int rankId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F33")]
	[Address(RVA = "0xC756D0", Offset = "0xC748D0", VA = "0x180C756D0")]
	public BindingImageEx BindRateDeckBG(GameObject target, int rateId = 1, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F34")]
	[Address(RVA = "0xC755C0", Offset = "0xC747C0", VA = "0x180C755C0")]
	public BindingImageEx BindRankAndRateDeckBG(GameObject target, int rankId, int rateId = 1, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F35")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public EventLogoResourceBinder()
	{
	}
}
