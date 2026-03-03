using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card;

[Token(Token = "0x200160B")]
public class CardIllustManager
{
	[Token(Token = "0x200160C")]
	private class TexInfo
	{
		[Token(Token = "0x400D461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D tex;

		[Token(Token = "0x400D462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int refCount;

		[Token(Token = "0x400D463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IllustLoadStep step;

		[Token(Token = "0x400D464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int cardid;

		[Token(Token = "0x400D465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<UnityAction<int, Texture2D>> handlerList;

		[Token(Token = "0x6008925")]
		[Address(RVA = "0xD59160", Offset = "0xD58360", VA = "0x180D59160")]
		public TexInfo([Optional] Texture2D texture)
		{
		}

		[Token(Token = "0x6008926")]
		[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
		public void ChangeStep(IllustLoadStep step)
		{
		}
	}

	[Token(Token = "0x200160D")]
	private class CallBackInfo
	{
		[Token(Token = "0x400D466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<int, Texture2D> callback;

		[Token(Token = "0x400D467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D tex;

		[Token(Token = "0x400D468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int cardid;

		[Token(Token = "0x6008927")]
		[Address(RVA = "0xD45DB0", Offset = "0xD44FB0", VA = "0x180D45DB0")]
		public CallBackInfo(int cardid, UnityAction<int, Texture2D> callback, Texture2D tex)
		{
		}
	}

	[Token(Token = "0x200160E")]
	private enum IllustLoadStep
	{
		[Token(Token = "0x400D46A")]
		WAIT,
		[Token(Token = "0x400D46B")]
		LOADING,
		[Token(Token = "0x400D46C")]
		END
	}

	[Token(Token = "0x400D459")]
	private const string BASEPATH = "Card/Images/";

	[Token(Token = "0x400D45A")]
	private const string DUMMYILLUSTPATH = "Card/dummyCard";

	[Token(Token = "0x400D45B")]
	private const string MrkZero = "0000";

	[Token(Token = "0x400D45C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<uint, TexInfo> pathToTexDictionary;

	[Token(Token = "0x400D45D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Queue<CallBackInfo> loadCompleteCallBackQueue;

	[Token(Token = "0x400D45E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private StringBuilder stringBuilder;

	[Token(Token = "0x400D45F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<int> m_AsyncLoadQueue;

	[Token(Token = "0x400D460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, Texture2D> m_SPIllustTable;

	[Token(Token = "0x17001501")]
	public int CardIllustCount
	{
		[Token(Token = "0x6008916")]
		[Address(RVA = "0xD475E0", Offset = "0xD467E0", VA = "0x180D475E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008914")]
	[Address(RVA = "0xD46660", Offset = "0xD45860", VA = "0x180D46660")]
	public static CardIllustManager Create()
	{
		return null;
	}

	[Token(Token = "0x6008915")]
	[Address(RVA = "0xD47420", Offset = "0xD46620", VA = "0x180D47420")]
	public static void SetRichTextCardPath()
	{
	}

	[Token(Token = "0x6008917")]
	[Address(RVA = "0xD46BF0", Offset = "0xD45DF0", VA = "0x180D46BF0")]
	public string GetPathByCardId(int mrk, bool checkvalid = true)
	{
		return null;
	}

	[Token(Token = "0x6008918")]
	[Address(RVA = "0xD46DB0", Offset = "0xD45FB0", VA = "0x180D46DB0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6008919")]
	[Address(RVA = "0xD474C0", Offset = "0xD466C0", VA = "0x180D474C0")]
	public bool UpdateIllustLoadProcess()
	{
		return default(bool);
	}

	[Token(Token = "0x600891A")]
	[Address(RVA = "0xD464B0", Offset = "0xD456B0", VA = "0x180D464B0")]
	private bool AsyncLoadImpl()
	{
		return default(bool);
	}

	[Token(Token = "0x600891B")]
	[Address(RVA = "0xD46420", Offset = "0xD45620", VA = "0x180D46420")]
	private bool AsyncLoadComplete()
	{
		return default(bool);
	}

	[Token(Token = "0x600891C")]
	[Address(RVA = "0xD46840", Offset = "0xD45A40", VA = "0x180D46840")]
	private void releaseAll()
	{
	}

	[Token(Token = "0x600891D")]
	[Address(RVA = "0xD47630", Offset = "0xD46830", VA = "0x180D47630")]
	private void requestCompleteHandler(string path)
	{
	}

	[Token(Token = "0x600891E")]
	[Address(RVA = "0xD470A0", Offset = "0xD462A0", VA = "0x180D470A0")]
	public bool Release(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x600891F")]
	[Address(RVA = "0xD46F00", Offset = "0xD46100", VA = "0x180D46F00")]
	public void ReleaseAll()
	{
	}

	[Token(Token = "0x6008920")]
	[Address(RVA = "0xD46840", Offset = "0xD45A40", VA = "0x180D46840")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6008921")]
	[Address(RVA = "0xD46890", Offset = "0xD45A90", VA = "0x180D46890")]
	public void GetIllustAsync(UnityAction<int, Texture2D> handler, int cardid, bool immediateOnReuse = false)
	{
	}

	[Token(Token = "0x6008922")]
	[Address(RVA = "0xD47240", Offset = "0xD46440", VA = "0x180D47240")]
	protected void RemoveCompleteCallbackByCardid(int cardid)
	{
	}

	[Token(Token = "0x6008923")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void CardIllustDebugMessage(int cardid, bool isrelease)
	{
	}

	[Token(Token = "0x6008924")]
	[Address(RVA = "0xD47560", Offset = "0xD46760", VA = "0x180D47560")]
	public CardIllustManager()
	{
	}
}
