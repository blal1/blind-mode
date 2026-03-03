using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class CoreMatrixUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MatrixTimesTranslation_Public_Static_Void_byref_Matrix4x4_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TranslationTimesMatrix_Public_Static_Void_byref_Matrix4x4_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyPerspectiveMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyOrthoMatrixCentered_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyGenericOrthoMatrix_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyOrthoMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0;

	static CoreMatrixUtils()
	{
		Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CoreMatrixUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr);
		NativeMethodInfoPtr_MatrixTimesTranslation_Public_Static_Void_byref_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100666571);
		NativeMethodInfoPtr_TranslationTimesMatrix_Public_Static_Void_byref_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100666572);
		NativeMethodInfoPtr_MultiplyPerspectiveMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100666573);
		NativeMethodInfoPtr_MultiplyOrthoMatrixCentered_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100666574);
		NativeMethodInfoPtr_MultiplyGenericOrthoMatrix_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100666575);
		NativeMethodInfoPtr_MultiplyOrthoMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100666576);
		NativeMethodInfoPtr_MultiplyProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100666577);
	}

	[CallerCount(0)]
	public unsafe static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref inOutMatrix);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &translation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatrixTimesTranslation_Public_Static_Void_byref_Matrix4x4_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref inOutMatrix);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &translation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TranslationTimesMatrix_Public_Static_Void_byref_Matrix4x4_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&perspective);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyPerspectiveMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ortho);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyOrthoMatrixCentered_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ortho);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyGenericOrthoMatrix_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051589, XrefRangeEnd = 1051590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ortho);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &centered;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyOrthoMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051591, RefRangeEnd = 1051592, XrefRangeStart = 1051590, XrefRangeEnd = 1051591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&projMatrix);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &orthoCentered;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CoreMatrixUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
