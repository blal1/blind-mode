using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002B0")]
public class Painter2D : IDisposable
{
	[Token(Token = "0x20002B1")]
	private struct Painter2DJobData
	{
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x0")]
		public UnsafeMeshGenerationNode node;

		[Token(Token = "0x4000AE4")]
		[FieldOffset(Offset = "0x8")]
		public int snapshotIndex;
	}

	[Token(Token = "0x20002B2")]
	private struct Painter2DJob : IJobParallelFor
	{
		[Token(Token = "0x4000AE5")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		public IntPtr painterHandle;

		[Token(Token = "0x4000AE6")]
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		public TempMeshAllocator allocator;

		[Token(Token = "0x4000AE7")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeSlice<Painter2DJobData> jobParameters;

		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x2B69B60", Offset = "0x2B68D60", VA = "0x182B69B60", Slot = "4")]
		public void Execute(int i)
		{
		}
	}

	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0x10")]
	private MeshGenerationContext m_Ctx;

	[Token(Token = "0x4000ADA")]
	[FieldOffset(Offset = "0x18")]
	internal DetachedAllocator m_DetachedAllocator;

	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0x20")]
	internal SafeHandleAccess m_Handle;

	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0x28")]
	private List<Painter2DJobData> m_JobSnapshots;

	[Token(Token = "0x4000ADD")]
	[FieldOffset(Offset = "0x30")]
	private NativeArray<Painter2DJobData> m_JobParameters;

	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Disposed;

	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker s_StrokeMarker;

	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0x10")]
	private static readonly ProfilerMarker s_FillMarker;

	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0x48")]
	private MeshGenerationCallback m_OnMeshGenerationDelegate;

	[Token(Token = "0x17000390")]
	internal static bool isPainterActive
	{
		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x2B6A770", Offset = "0x2B69970", VA = "0x182B6A770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x2B6A4A0", Offset = "0x2B696A0", VA = "0x182B6A4A0")]
	internal Painter2D(MeshGenerationContext ctx)
	{
	}

	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x2B6A5F0", Offset = "0x2B697F0", VA = "0x182B6A5F0")]
	public Painter2D()
	{
	}

	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x2B6A0A0", Offset = "0x2B692A0", VA = "0x182B6A0A0")]
	internal void Reset()
	{
	}

	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x2B69F90", Offset = "0x2B69190", VA = "0x182B69F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x2B69F00", Offset = "0x2B69100", VA = "0x182B69F00")]
	private void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x2B6A100", Offset = "0x2B69300", VA = "0x182B6A100")]
	internal void ScheduleJobs(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x2B6A040", Offset = "0x2B69240", VA = "0x182B6A040")]
	private void OnMeshGeneration(MeshGenerationContext ctx, object data)
	{
	}
}
