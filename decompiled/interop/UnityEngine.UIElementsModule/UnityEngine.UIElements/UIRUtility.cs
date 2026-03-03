using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002B9")]
internal static class UIRUtility
{
	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ProfilerMarker k_ComputeTransformMatrixMarker;

	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string k_DefaultShaderName;

	[Token(Token = "0x4000AFE")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string k_DefaultWorldSpaceShaderName;

	[Token(Token = "0x4000AFF")]
	[ThreadStatic]
	private static int? s_ThreadIndex;

	[MethodImpl(256)]
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x2B72A40", Offset = "0x2B71C40", VA = "0x182B72A40")]
	public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef)
	{
		return default(bool);
	}

	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x2B72710", Offset = "0x2B71910", VA = "0x182B72710")]
	public static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform)
	{
	}

	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x2B72360", Offset = "0x2B71560", VA = "0x182B72360")]
	internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result)
	{
	}

	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x2B728D0", Offset = "0x2B71AD0", VA = "0x182B728D0")]
	public static bool IsRoundRect(VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x2B729B0", Offset = "0x2B71BB0", VA = "0x182B729B0")]
	public static bool IsVectorImageBackground(VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x2B72500", Offset = "0x2B71700", VA = "0x182B72500")]
	public static void Destroy(Object obj)
	{
	}

	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x2B72600", Offset = "0x2B71800", VA = "0x182B72600")]
	public static int GetPrevPow2(int n)
	{
		return default(int);
	}

	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x2B725E0", Offset = "0x2B717E0", VA = "0x182B725E0")]
	public static int GetNextPow2(int n)
	{
		return default(int);
	}

	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x2B725C0", Offset = "0x2B717C0", VA = "0x182B725C0")]
	public static int GetNextPow2Exp(int n)
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x2B72620", Offset = "0x2B71820", VA = "0x182B72620")]
	public static int GetThreadIndex()
	{
		return default(int);
	}
}
