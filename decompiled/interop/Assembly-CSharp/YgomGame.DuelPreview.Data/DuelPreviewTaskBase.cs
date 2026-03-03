using System.Collections;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E42")]
public abstract class DuelPreviewTaskBase : IDuelPreviewTask
{
	[Token(Token = "0x400A2CB")]
	[FieldOffset(Offset = "0x10")]
	protected DuelPreviewTaskRawData m_TaskData;

	[Token(Token = "0x400A2CC")]
	[FieldOffset(Offset = "0x18")]
	protected DuelPreviewPlayer m_Player;

	[Token(Token = "0x17000CFE")]
	public DuelPreviewTaskRawData.TransitionType transitionType
	{
		[Token(Token = "0x6005657")]
		[Address(RVA = "0x9B70D0", Offset = "0x9B62D0", VA = "0x1809B70D0", Slot = "4")]
		get
		{
			return default(DuelPreviewTaskRawData.TransitionType);
		}
	}

	[Token(Token = "0x6005658")]
	[Address(RVA = "0x9B7080", Offset = "0x9B6280", VA = "0x1809B7080", Slot = "5")]
	public void Init(DuelPreviewTaskRawData taskData, DuelPreviewPlayer player)
	{
	}

	[Token(Token = "0x6005659")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x600565A")]
	public abstract IEnumerator ySetup();

	[Token(Token = "0x600565B")]
	public abstract IEnumerator Play();

	[Token(Token = "0x600565C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected DuelPreviewTaskBase()
	{
	}
}
