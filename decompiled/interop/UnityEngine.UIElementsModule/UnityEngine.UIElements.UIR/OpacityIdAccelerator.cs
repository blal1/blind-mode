using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000555")]
internal class OpacityIdAccelerator : IDisposable
{
	[Token(Token = "0x2000556")]
	private struct OpacityIdUpdateJob : IJobParallelFor
	{
		[Token(Token = "0x400128D")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableContainerSafetyRestriction]
		public NativeSlice<Vertex> oldVerts;

		[Token(Token = "0x400128E")]
		[FieldOffset(Offset = "0x10")]
		[NativeDisableContainerSafetyRestriction]
		public NativeSlice<Vertex> newVerts;

		[Token(Token = "0x400128F")]
		[FieldOffset(Offset = "0x20")]
		public Color32 opacityData;

		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x2A58920", Offset = "0x2A57B20", VA = "0x182A58920", Slot = "4")]
		public void Execute(int i)
		{
		}
	}

	[Token(Token = "0x400128A")]
	[FieldOffset(Offset = "0x10")]
	private NativeArray<JobHandle> m_Jobs;

	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0x20")]
	private int m_NextJobIndex;

	[Token(Token = "0x1700099E")]
	protected bool disposed
	{
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x5CF080", Offset = "0x5CE280", VA = "0x1805CF080")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x5CF0A0", Offset = "0x5CE2A0", VA = "0x1805CF0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60025CE")]
	[Address(RVA = "0x2A586B0", Offset = "0x2A578B0", VA = "0x182A586B0")]
	public void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount)
	{
	}

	[Token(Token = "0x60025CF")]
	[Address(RVA = "0x2A58600", Offset = "0x2A57800", VA = "0x182A58600")]
	public void CompleteJobs()
	{
	}

	[Token(Token = "0x60025D2")]
	[Address(RVA = "0x2A587E0", Offset = "0x2A579E0", VA = "0x182A587E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60025D3")]
	[Address(RVA = "0x2A58850", Offset = "0x2A57A50", VA = "0x182A58850", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x60025D4")]
	[Address(RVA = "0x2A588B0", Offset = "0x2A57AB0", VA = "0x182A588B0")]
	public OpacityIdAccelerator()
	{
	}
}
