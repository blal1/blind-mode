using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200050D")]
[UnityEngine.Bindings.NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererUtility.h")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "Unity.UIElements" })]
internal class Utility
{
	[Token(Token = "0x200050E")]
	internal enum GPUBufferType
	{
		[Token(Token = "0x400109D")]
		Vertex,
		[Token(Token = "0x400109E")]
		Index
	}

	[Token(Token = "0x200050F")]
	public class GPUBuffer<T> : IDisposable where T : struct
	{
		[Token(Token = "0x400109F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr buffer;

		[Token(Token = "0x40010A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int elemCount;

		[Token(Token = "0x40010A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int elemStride;

		[Token(Token = "0x17000972")]
		public int ElementStride
		{
			[Token(Token = "0x600245D")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000973")]
		internal IntPtr BufferPointer
		{
			[Token(Token = "0x600245E")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x600245A")]
		public GPUBuffer(int elementCount, GPUBufferType type)
		{
		}

		[Token(Token = "0x600245B")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600245C")]
		public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax)
		{
		}
	}

	[Token(Token = "0x400109B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static ProfilerMarker s_MarkerRaiseEngineUpdate;

	[Token(Token = "0x14000031")]
	public static event Action<bool> GraphicsResourcesRecreate
	{
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x2A3B280", Offset = "0x2A3A480", VA = "0x182A3B280")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6002437")]
		[Address(RVA = "0x2A3B590", Offset = "0x2A3A790", VA = "0x182A3B590")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000032")]
	public static event Action EngineUpdate
	{
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x2A3B080", Offset = "0x2A3A280", VA = "0x182A3B080")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x2A3B390", Offset = "0x2A3A590", VA = "0x182A3B390")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000033")]
	public static event Action FlushPendingResources
	{
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x2A3B180", Offset = "0x2A3A380", VA = "0x182A3B180")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x2A3B490", Offset = "0x2A3A690", VA = "0x182A3B490")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600243C")]
	[Address(RVA = "0x2A3AD30", Offset = "0x2A39F30", VA = "0x182A3AD30")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void RaiseGraphicsResourcesRecreate(bool recreate)
	{
	}

	[Token(Token = "0x600243D")]
	[Address(RVA = "0x2A3AC30", Offset = "0x2A39E30", VA = "0x182A3AC30")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void RaiseEngineUpdate()
	{
	}

	[Token(Token = "0x600243E")]
	[Address(RVA = "0x2A3ACC0", Offset = "0x2A39EC0", VA = "0x182A3ACC0")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void RaiseFlushPendingResources()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600243F")]
	[Address(RVA = "0x2A3A680", Offset = "0x2A39880", VA = "0x182A3A680")]
	[UnityEngine.Bindings.ThreadSafe]
	private static extern IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer);

	[MethodImpl(4096)]
	[Token(Token = "0x6002440")]
	[Address(RVA = "0x2A3A860", Offset = "0x2A39A60", VA = "0x182A3A860")]
	[UnityEngine.Bindings.ThreadSafe]
	private static extern void FreeBuffer(IntPtr buffer);

	[MethodImpl(4096)]
	[Token(Token = "0x6002441")]
	[Address(RVA = "0x2A3AF70", Offset = "0x2A3A170", VA = "0x182A3AF70")]
	[UnityEngine.Bindings.ThreadSafe]
	private static extern void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd);

	[Token(Token = "0x6002442")]
	[Address(RVA = "0x2A3AA50", Offset = "0x2A39C50", VA = "0x182A3AA50")]
	[UnityEngine.Bindings.ThreadSafe]
	public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes)
	{
		return default(IntPtr);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6002443")]
	[Address(RVA = "0x2A3A7F0", Offset = "0x2A399F0", VA = "0x182A3A7F0")]
	[UnityEngine.Bindings.ThreadSafe]
	public unsafe static extern void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl);

	[Token(Token = "0x6002444")]
	[Address(RVA = "0x2A3ADE0", Offset = "0x2A39FE0", VA = "0x182A3ADE0")]
	[UnityEngine.Bindings.ThreadSafe]
	public static void SetPropertyBlock(MaterialPropertyBlock props)
	{
	}

	[Token(Token = "0x6002445")]
	[Address(RVA = "0x2A3AE90", Offset = "0x2A3A090", VA = "0x182A3AE90")]
	[UnityEngine.Bindings.ThreadSafe]
	public static void SetScissorRect(RectInt scissorRect)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6002446")]
	[Address(RVA = "0x2A3A7C0", Offset = "0x2A399C0", VA = "0x182A3A7C0")]
	[UnityEngine.Bindings.ThreadSafe]
	public static extern void DisableScissor();

	[Token(Token = "0x6002447")]
	[Address(RVA = "0x2A3A750", Offset = "0x2A39950", VA = "0x182A3A750")]
	[UnityEngine.Bindings.ThreadSafe]
	public static IntPtr CreateStencilState(StencilState stencilState)
	{
		return default(IntPtr);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6002448")]
	[Address(RVA = "0x2A3AF00", Offset = "0x2A3A100", VA = "0x182A3AF00")]
	[UnityEngine.Bindings.ThreadSafe]
	public static extern void SetStencilState(IntPtr stencilState, int stencilRef);

	[MethodImpl(4096)]
	[Token(Token = "0x6002449")]
	[Address(RVA = "0x2A3AB30", Offset = "0x2A39D30", VA = "0x182A3AB30")]
	[UnityEngine.Bindings.ThreadSafe]
	public static extern bool HasMappedBufferRange();

	[MethodImpl(4096)]
	[Token(Token = "0x600244A")]
	[Address(RVA = "0x2A3AB60", Offset = "0x2A39D60", VA = "0x182A3AB60")]
	[UnityEngine.Bindings.ThreadSafe]
	public static extern uint InsertCPUFence();

	[MethodImpl(4096)]
	[Token(Token = "0x600244B")]
	[Address(RVA = "0x2A3A6D0", Offset = "0x2A398D0", VA = "0x182A3A6D0")]
	[UnityEngine.Bindings.ThreadSafe]
	public static extern bool CPUFencePassed(uint fence);

	[MethodImpl(4096)]
	[Token(Token = "0x600244C")]
	[Address(RVA = "0x2A3AFE0", Offset = "0x2A3A1E0", VA = "0x182A3AFE0")]
	[UnityEngine.Bindings.ThreadSafe]
	public static extern void WaitForCPUFencePassed(uint fence);

	[MethodImpl(4096)]
	[Token(Token = "0x600244D")]
	[Address(RVA = "0x2A3AF40", Offset = "0x2A3A140", VA = "0x182A3AF40")]
	[UnityEngine.Bindings.ThreadSafe]
	public static extern void SyncRenderThread();

	[Token(Token = "0x600244E")]
	[Address(RVA = "0x2A3A8E0", Offset = "0x2A39AE0", VA = "0x182A3A8E0")]
	[UnityEngine.Bindings.ThreadSafe]
	public static RectInt GetActiveViewport()
	{
		return default(RectInt);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600244F")]
	[Address(RVA = "0x2A3ABD0", Offset = "0x2A39DD0", VA = "0x182A3ABD0")]
	[UnityEngine.Bindings.ThreadSafe]
	public static extern void ProfileDrawChainBegin();

	[MethodImpl(4096)]
	[Token(Token = "0x6002450")]
	[Address(RVA = "0x2A3AC00", Offset = "0x2A39E00", VA = "0x182A3AC00")]
	[UnityEngine.Bindings.ThreadSafe]
	public static extern void ProfileDrawChainEnd();

	[MethodImpl(4096)]
	[Token(Token = "0x6002451")]
	[Address(RVA = "0x2A3AB90", Offset = "0x2A39D90", VA = "0x182A3AB90")]
	public static extern void NotifyOfUIREvents(bool subscribe);

	[Token(Token = "0x6002452")]
	[Address(RVA = "0x2A3A990", Offset = "0x2A39B90", VA = "0x182A3A990")]
	[UnityEngine.Bindings.ThreadSafe]
	public static Matrix4x4 GetUnityProjectionMatrix()
	{
		return default(Matrix4x4);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6002454")]
	[Address(RVA = "0x2A3AA10", Offset = "0x2A39C10", VA = "0x182A3AA10")]
	private static extern IntPtr GetVertexDeclaration_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper vertexAttributes);

	[MethodImpl(4096)]
	[Token(Token = "0x6002455")]
	[Address(RVA = "0x2A3ADA0", Offset = "0x2A39FA0", VA = "0x182A3ADA0")]
	private static extern void SetPropertyBlock_Injected(IntPtr props);

	[MethodImpl(4096)]
	[Token(Token = "0x6002456")]
	[Address(RVA = "0x2A3AE50", Offset = "0x2A3A050", VA = "0x182A3AE50")]
	private static extern void SetScissorRect_Injected([In] ref RectInt scissorRect);

	[MethodImpl(4096)]
	[Token(Token = "0x6002457")]
	[Address(RVA = "0x2A3A710", Offset = "0x2A39910", VA = "0x182A3A710")]
	private static extern IntPtr CreateStencilState_Injected([In] ref StencilState stencilState);

	[MethodImpl(4096)]
	[Token(Token = "0x6002458")]
	[Address(RVA = "0x2A3A8A0", Offset = "0x2A39AA0", VA = "0x182A3A8A0")]
	private static extern void GetActiveViewport_Injected(out RectInt ret);

	[MethodImpl(4096)]
	[Token(Token = "0x6002459")]
	[Address(RVA = "0x2A3A950", Offset = "0x2A39B50", VA = "0x182A3A950")]
	private static extern void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret);
}
