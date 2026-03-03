using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000518")]
internal class CommandList : IDisposable
{
	[Token(Token = "0x40010C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public VisualElement m_Owner;

	[Token(Token = "0x40010C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly IntPtr m_VertexDecl;

	[Token(Token = "0x40010C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly IntPtr m_StencilState;

	[Token(Token = "0x40010C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MaterialPropertyBlock constantProps;

	[Token(Token = "0x40010C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MaterialPropertyBlock batchProps;

	[Token(Token = "0x40010CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GCHandle handle;

	[Token(Token = "0x40010CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<SerializedCommand> m_Commands;

	[Token(Token = "0x40010CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector4[] m_GpuTextureData;

	[Token(Token = "0x40010CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private NativeList<DrawBufferRange> m_DrawRanges;

	[Token(Token = "0x17000975")]
	protected bool disposed
	{
		[Token(Token = "0x600247F")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002480")]
		[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002479")]
	[Address(RVA = "0x2A2BCE0", Offset = "0x2A2AEE0", VA = "0x182A2BCE0")]
	public CommandList(VisualElement owner, IntPtr vertexDecl, IntPtr stencilState)
	{
	}

	[Token(Token = "0x600247A")]
	[Address(RVA = "0x2A2BAB0", Offset = "0x2A2ACB0", VA = "0x182A2BAB0")]
	public void Reset(VisualElement newOwner)
	{
	}

	[Token(Token = "0x600247B")]
	[Address(RVA = "0x2A2B6B0", Offset = "0x2A2A8B0", VA = "0x182A2B6B0")]
	public void Execute()
	{
	}

	[Token(Token = "0x600247C")]
	[Address(RVA = "0x2A2BBD0", Offset = "0x2A2ADD0", VA = "0x182A2BBD0")]
	public void SetTexture(int name, Texture texture, int gpuDataOffset, Vector4 gpuData0, Vector4 gpuData1)
	{
	}

	[Token(Token = "0x600247D")]
	[Address(RVA = "0x2A2B300", Offset = "0x2A2A500", VA = "0x182A2B300")]
	public void ApplyBatchProps()
	{
	}

	[Token(Token = "0x600247E")]
	[Address(RVA = "0x2A2B510", Offset = "0x2A2A710", VA = "0x182A2B510")]
	public void DrawRanges(Utility.GPUBuffer<ushort> ib, Utility.GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges)
	{
	}

	[Token(Token = "0x6002481")]
	[Address(RVA = "0x2A2B460", Offset = "0x2A2A660", VA = "0x182A2B460", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6002482")]
	[Address(RVA = "0x2A2B3D0", Offset = "0x2A2A5D0", VA = "0x182A2B3D0")]
	protected void Dispose(bool disposing)
	{
	}
}
