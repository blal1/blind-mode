using Il2CppDummyDll;

namespace YgomGame.Card;

[Token(Token = "0x200160F")]
public class CardMaskCreator : CardTextureCreatorBase
{
	[Token(Token = "0x400D46D")]
	[FieldOffset(Offset = "0x70")]
	private CardPictureTop m_CardPictureTopBase;

	[Token(Token = "0x6008928")]
	[Address(RVA = "0xD47A00", Offset = "0xD46C00", VA = "0x180D47A00")]
	public static CardMaskCreator CreateCardMaskCreator()
	{
		return null;
	}

	[Token(Token = "0x6008929")]
	[Address(RVA = "0xD47AE0", Offset = "0xD46CE0", VA = "0x180D47AE0", Slot = "8")]
	protected override bool CreateTaskImpl(TaskDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x600892A")]
	[Address(RVA = "0xD47C60", Offset = "0xD46E60", VA = "0x180D47C60", Slot = "5")]
	protected override void InitComponent()
	{
	}

	[Token(Token = "0x600892B")]
	[Address(RVA = "0xD48130", Offset = "0xD47330", VA = "0x180D48130", Slot = "6")]
	protected override void SetCanvas()
	{
	}

	[Token(Token = "0x600892C")]
	[Address(RVA = "0xD47F50", Offset = "0xD47150", VA = "0x180D47F50", Slot = "7")]
	protected override void SetCPRenderTexture()
	{
	}

	[Token(Token = "0x600892D")]
	[Address(RVA = "0xD48290", Offset = "0xD47490", VA = "0x180D48290")]
	private void Update()
	{
	}

	[Token(Token = "0x600892E")]
	[Address(RVA = "0xD47970", Offset = "0xD46B70", VA = "0x180D47970", Slot = "4")]
	public override void CancelCardPictureTask(int cardid)
	{
	}

	[Token(Token = "0x600892F")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardMaskCreator()
	{
	}
}
