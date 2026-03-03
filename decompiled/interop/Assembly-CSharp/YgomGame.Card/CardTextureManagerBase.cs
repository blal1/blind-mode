using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card;

[Token(Token = "0x2001629")]
public abstract class CardTextureManagerBase
{
	[Token(Token = "0x200162A")]
	protected class TexInfo
	{
		[Token(Token = "0x400D512")]
		[FieldOffset(Offset = "0x10")]
		public Texture2D tex;

		[Token(Token = "0x400D513")]
		[FieldOffset(Offset = "0x18")]
		public int refCount;

		[Token(Token = "0x60089F3")]
		[Address(RVA = "0xCC8CE0", Offset = "0xCC7EE0", VA = "0x180CC8CE0")]
		public TexInfo(Texture2D tex)
		{
		}
	}

	[Token(Token = "0x400D506")]
	[FieldOffset(Offset = "0x0")]
	protected static Texture2D m_DummyCard;

	[Token(Token = "0x400D507")]
	protected const string DUMMYCARDPATH = "Card/dummyCard";

	[Token(Token = "0x400D508")]
	[FieldOffset(Offset = "0x10")]
	protected CardTextureCreatorBase m_CardCreator;

	[Token(Token = "0x400D509")]
	[FieldOffset(Offset = "0x18")]
	protected List<int> m_NoReferenceCardIdList;

	[Token(Token = "0x400D50A")]
	[FieldOffset(Offset = "0x20")]
	protected Queue<Texture2D> m_FreeTexInstances;

	[Token(Token = "0x400D50B")]
	[FieldOffset(Offset = "0x28")]
	protected Dictionary<int, TexInfo> m_CardIdTextureTable;

	[Token(Token = "0x400D50C")]
	[FieldOffset(Offset = "0x30")]
	protected Dictionary<int, Dictionary<int, UnityAction<Texture2D, bool>>> m_CallbackTable;

	[Token(Token = "0x400D50D")]
	[FieldOffset(Offset = "0x38")]
	protected bool m_EnableCache;

	[Token(Token = "0x400D50E")]
	[FieldOffset(Offset = "0x3C")]
	protected int m_TaskIndex;

	[Token(Token = "0x400D50F")]
	[FieldOffset(Offset = "0x40")]
	protected string m_Tag;

	[Token(Token = "0x400D510")]
	[FieldOffset(Offset = "0x48")]
	protected int m_CardInstanceNumBsae;

	[Token(Token = "0x400D511")]
	[FieldOffset(Offset = "0x4C")]
	protected int m_AddCardInstanceNum;

	[Token(Token = "0x17001518")]
	public static Texture2D DUMMYCARD
	{
		[Token(Token = "0x60089D6")]
		[Address(RVA = "0xD535A0", Offset = "0xD527A0", VA = "0x180D535A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001519")]
	protected int m_CardInstanceNum
	{
		[Token(Token = "0x60089D7")]
		[Address(RVA = "0xD53860", Offset = "0xD52A60", VA = "0x180D53860")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700151A")]
	public int RefedTextureCount
	{
		[Token(Token = "0x60089D8")]
		[Address(RVA = "0xD53760", Offset = "0xD52960", VA = "0x180D53760")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700151B")]
	public int NoRefTextureCount
	{
		[Token(Token = "0x60089D9")]
		[Address(RVA = "0xD53720", Offset = "0xD52920", VA = "0x180D53720")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700151C")]
	public int TaskCount
	{
		[Token(Token = "0x60089DA")]
		[Address(RVA = "0xD537C0", Offset = "0xD529C0", VA = "0x180D537C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700151D")]
	public int UsedInstanceCount
	{
		[Token(Token = "0x60089DB")]
		[Address(RVA = "0xD53810", Offset = "0xD52A10", VA = "0x180D53810")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700151E")]
	public int FreeInstanceCount
	{
		[Token(Token = "0x60089DC")]
		[Address(RVA = "0xD536E0", Offset = "0xD528E0", VA = "0x180D536E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700151F")]
	public int AllInstanceCount
	{
		[Token(Token = "0x60089DD")]
		[Address(RVA = "0xD53540", Offset = "0xD52740", VA = "0x180D53540")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001520")]
	public int AddInstanceCount
	{
		[Token(Token = "0x60089DE")]
		[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60089DF")]
	[Address(RVA = "0xD52570", Offset = "0xD51770", VA = "0x180D52570")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x60089E0")]
	[Address(RVA = "0xD51AB0", Offset = "0xD50CB0", VA = "0x180D51AB0")]
	protected bool ExecuteCallback(int cardid, Texture2D cardpicture)
	{
		return default(bool);
	}

	[Token(Token = "0x60089E1")]
	[Address(RVA = "0xD52AB0", Offset = "0xD51CB0", VA = "0x180D52AB0")]
	protected void ReduceNoReferenceData()
	{
	}

	[Token(Token = "0x60089E2")]
	[Address(RVA = "0xD53360", Offset = "0xD52560", VA = "0x180D53360")]
	public void SetCacheActive(bool enable)
	{
	}

	[Token(Token = "0x60089E3")]
	[Address(RVA = "0xD517A0", Offset = "0xD509A0", VA = "0x180D517A0")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x60089E4")]
	[Address(RVA = "0xD52E60", Offset = "0xD52060", VA = "0x180D52E60")]
	public void Release(int cardid, int taskid = 0)
	{
	}

	[Token(Token = "0x60089E5")]
	[Address(RVA = "0xD52C40", Offset = "0xD51E40", VA = "0x180D52C40")]
	public void ReleaseAll()
	{
	}

	[Token(Token = "0x60089E6")]
	[Address(RVA = "0xD51AA0", Offset = "0xD50CA0", VA = "0x180D51AA0")]
	public void Destroy()
	{
	}

	[Token(Token = "0x60089E7")]
	[Address(RVA = "0xD51D40", Offset = "0xD50F40", VA = "0x180D51D40")]
	public int GetCardTextureAsync(UnityAction<Texture2D, bool> onFinished, int cardid)
	{
		return default(int);
	}

	[Token(Token = "0x60089E8")]
	[Address(RVA = "0xD533A0", Offset = "0xD525A0", VA = "0x180D533A0")]
	public void SetCardQuality(CardQuality quality)
	{
	}

	[Token(Token = "0x60089E9")]
	[Address(RVA = "0xD528A0", Offset = "0xD51AA0", VA = "0x180D528A0")]
	public bool PreLoadCardPictureAsync(int cardid, bool force)
	{
		return default(bool);
	}

	[Token(Token = "0x60089EA")]
	[Address(RVA = "0xD521E0", Offset = "0xD513E0", VA = "0x180D521E0")]
	protected Texture2D GetTexInstance(int cardid, bool force = true)
	{
		return null;
	}

	[Token(Token = "0x60089EB")]
	[Address(RVA = "0xD53170", Offset = "0xD52370", VA = "0x180D53170")]
	protected void ResetTexInstance()
	{
	}

	[Token(Token = "0x60089EC")]
	[Address(RVA = "0xD519A0", Offset = "0xD50BA0", VA = "0x180D519A0")]
	protected void CreateTextureImpl(int cardid)
	{
	}

	[Token(Token = "0x60089ED")]
	[Address(RVA = "0xD51770", Offset = "0xD50970", VA = "0x180D51770")]
	protected void CancelTaskImpl(int cardid)
	{
	}

	[Token(Token = "0x60089EE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void CardPictureDebugMessage(int cardid, bool isrelease)
	{
	}

	[Token(Token = "0x60089EF")]
	public abstract void RecreateCardCreator();

	[Token(Token = "0x60089F0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected CardTextureManagerBase()
	{
	}
}
