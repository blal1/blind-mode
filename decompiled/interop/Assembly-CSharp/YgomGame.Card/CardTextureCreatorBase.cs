using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card;

[Token(Token = "0x2001627")]
public abstract class CardTextureCreatorBase : MonoBehaviour
{
	[Token(Token = "0x2001628")]
	public struct TaskDesc
	{
		[Token(Token = "0x400D504")]
		[FieldOffset(Offset = "0x0")]
		public int cardid;

		[Token(Token = "0x400D505")]
		[FieldOffset(Offset = "0x8")]
		public Texture2D tex;

		[Token(Token = "0x60089D5")]
		[Address(RVA = "0xD59140", Offset = "0xD58340", VA = "0x180D59140")]
		public TaskDesc(int cardid, Texture2D tex)
		{
		}
	}

	[Token(Token = "0x400D4F4")]
	protected const int MAXCARDPICTUREHEIGHT = 1054;

	[Token(Token = "0x400D4F5")]
	protected const int MAXCARDPICTUREWIDTH = 723;

	[Token(Token = "0x400D4F6")]
	public const int LAYER_CARDCREATOR = 9;

	[Token(Token = "0x400D4F7")]
	public const int CARDWIDTH = 59;

	[Token(Token = "0x400D4F8")]
	public const int CARDHEIGHT = 86;

	[Token(Token = "0x400D4F9")]
	protected const float TARGETFRAME = 40f;

	[Token(Token = "0x400D4FA")]
	[FieldOffset(Offset = "0x20")]
	public UnityAction<TaskDesc> onCancelTask;

	[Token(Token = "0x400D4FB")]
	[FieldOffset(Offset = "0x28")]
	public UnityAction<TaskDesc> onReturnInstance;

	[Token(Token = "0x400D4FC")]
	[FieldOffset(Offset = "0x30")]
	protected Dictionary<int, UnityAction<Texture2D>> m_CardidCallbackTable;

	[Token(Token = "0x400D4FD")]
	[FieldOffset(Offset = "0x38")]
	protected Queue<TaskDesc> m_TaskQueue;

	[Token(Token = "0x400D4FE")]
	[FieldOffset(Offset = "0x40")]
	protected TaskDesc m_StandByTask;

	[Token(Token = "0x400D4FF")]
	[FieldOffset(Offset = "0x50")]
	protected Canvas m_CPCanvas;

	[Token(Token = "0x400D500")]
	[FieldOffset(Offset = "0x58")]
	protected Camera m_CPCamera;

	[Token(Token = "0x400D501")]
	[FieldOffset(Offset = "0x60")]
	protected RenderTexture m_RenderTexture;

	[Token(Token = "0x400D502")]
	[FieldOffset(Offset = "0x68")]
	protected bool m_IsStandby;

	[Token(Token = "0x17001515")]
	public RenderTexture renderTexture
	{
		[Token(Token = "0x60089C3")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001516")]
	protected float m_Compression
	{
		[Token(Token = "0x60089C4")]
		[Address(RVA = "0xD51730", Offset = "0xD50930", VA = "0x180D51730")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001517")]
	public CardQuality quality
	{
		[Token(Token = "0x60089C5")]
		[Address(RVA = "0x803CD0", Offset = "0x802ED0", VA = "0x180803CD0")]
		[CompilerGenerated]
		get
		{
			return default(CardQuality);
		}
		[Token(Token = "0x60089C6")]
		[Address(RVA = "0x91E9D0", Offset = "0x91DBD0", VA = "0x18091E9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60089C7")]
	[Address(RVA = "0xD51650", Offset = "0xD50850", VA = "0x180D51650")]
	public void SetCardQuality(CardQuality quality)
	{
	}

	[Token(Token = "0x60089C8")]
	[Address(RVA = "0xD511A0", Offset = "0xD503A0", VA = "0x180D511A0")]
	public void CreateTextureAsync(UnityAction<Texture2D> onfinished, int cardid, Texture2D tex)
	{
	}

	[Token(Token = "0x60089C9")]
	[Address(RVA = "0xD51020", Offset = "0xD50220", VA = "0x180D51020")]
	public void CancelAllTask()
	{
	}

	[Token(Token = "0x60089CA")]
	[Address(RVA = "0xD51270", Offset = "0xD50470", VA = "0x180D51270")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60089CB")]
	public abstract void CancelCardPictureTask(int cardid);

	[Token(Token = "0x60089CC")]
	protected abstract void InitComponent();

	[Token(Token = "0x60089CD")]
	protected abstract void SetCanvas();

	[Token(Token = "0x60089CE")]
	protected abstract void SetCPRenderTexture();

	[Token(Token = "0x60089CF")]
	protected abstract bool CreateTaskImpl(TaskDesc desc);

	[Token(Token = "0x60089D0")]
	[Address(RVA = "0xD514A0", Offset = "0xD506A0", VA = "0x180D514A0")]
	protected void SetCamera()
	{
	}

	[Token(Token = "0x60089D1")]
	[Address(RVA = "0xD516F0", Offset = "0xD508F0", VA = "0x180D516F0")]
	protected void SetStandByTask(TaskDesc task)
	{
	}

	[Token(Token = "0x60089D2")]
	[Address(RVA = "0xD51090", Offset = "0xD50290", VA = "0x180D51090")]
	protected void CopyTexPixel()
	{
	}

	[Token(Token = "0x60089D3")]
	[Address(RVA = "0xD512D0", Offset = "0xD504D0", VA = "0x180D512D0")]
	protected bool RemoveTaskFromQueueByCardid(int cardid)
	{
		return default(bool);
	}

	[Token(Token = "0x60089D4")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected CardTextureCreatorBase()
	{
	}
}
