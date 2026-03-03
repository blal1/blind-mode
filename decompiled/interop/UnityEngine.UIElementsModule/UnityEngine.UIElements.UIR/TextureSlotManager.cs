using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000574")]
internal class TextureSlotManager
{
	[Token(Token = "0x4001371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly int k_SlotCount;

	[Token(Token = "0x4001372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	internal static readonly int k_SlotSize;

	[Token(Token = "0x4001373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal static readonly int[] slotIds;

	[Token(Token = "0x4001374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal static readonly int textureTableId;

	[Token(Token = "0x4001375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private TextureId[] m_Textures;

	[Token(Token = "0x4001376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int[] m_Tickets;

	[Token(Token = "0x4001377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_CurrentTicket;

	[Token(Token = "0x4001378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int m_FirstUsedTicket;

	[Token(Token = "0x4001379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector4[] m_GpuTextures;

	[Token(Token = "0x400137B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal TextureRegistry textureRegistry;

	[Token(Token = "0x170009C3")]
	public int FreeSlots
	{
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002694")]
	[Address(RVA = "0x2A66C50", Offset = "0x2A65E50", VA = "0x182A66C50")]
	static TextureSlotManager()
	{
	}

	[Token(Token = "0x6002695")]
	[Address(RVA = "0x2A66DD0", Offset = "0x2A65FD0", VA = "0x182A66DD0")]
	public TextureSlotManager()
	{
	}

	[Token(Token = "0x6002696")]
	[Address(RVA = "0x2A668E0", Offset = "0x2A65AE0", VA = "0x182A668E0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002697")]
	[Address(RVA = "0x2A66BE0", Offset = "0x2A65DE0", VA = "0x182A66BE0")]
	public void StartNewBatch()
	{
	}

	[Token(Token = "0x6002698")]
	[Address(RVA = "0x2A667A0", Offset = "0x2A659A0", VA = "0x182A667A0")]
	public int IndexOf(TextureId id)
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002699")]
	[Address(RVA = "0x2A66880", Offset = "0x2A65A80", VA = "0x182A66880")]
	public void MarkUsed(int slotIndex)
	{
	}

	[Token(Token = "0x600269C")]
	[Address(RVA = "0x2A666D0", Offset = "0x2A658D0", VA = "0x182A666D0")]
	public int FindOldestSlot()
	{
		return default(int);
	}

	[Token(Token = "0x600269D")]
	[Address(RVA = "0x2A663D0", Offset = "0x2A655D0", VA = "0x182A663D0")]
	public void Bind(TextureId id, float sdfScale, float sharpness, int slot, MaterialPropertyBlock mat, [Optional] CommandList commandList)
	{
	}

	[Token(Token = "0x600269E")]
	[Address(RVA = "0x2A66A40", Offset = "0x2A65C40", VA = "0x182A66A40")]
	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale, float sharpness)
	{
	}
}
