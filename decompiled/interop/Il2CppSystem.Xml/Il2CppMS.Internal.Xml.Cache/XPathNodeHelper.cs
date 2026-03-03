using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMS.Internal.Xml.Cache;

public class XPathNodeHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0;

	static XPathNodeHelper()
	{
		Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100668784);
		NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100668785);
		NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100668786);
		NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100668787);
		NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100668788);
		NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100668789);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953712, XrefRangeEnd = 953713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLocalNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pageElem);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idxElem;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		pageNmsp = ((num3 == 0) ? null : new Il2CppReferenceArray<XPathNode>((System.IntPtr)num3));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953713, XrefRangeEnd = 953714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetInScopeNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pageElem);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idxElem;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		pageNmsp = ((num3 == 0) ? null : new Il2CppReferenceArray<XPathNode>((System.IntPtr)num3));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953714, XrefRangeEnd = 953715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetParent(ref Il2CppReferenceArray<XPathNode> pageNode, ref int idxNode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pageNode);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idxNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		pageNode = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	public unsafe static int GetLocation(Il2CppReferenceArray<XPathNode> pageNode, int idxNode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pageNode);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idxNode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 953720, RefRangeEnd = 953722, XrefRangeStart = 953715, XrefRangeEnd = 953720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetTextFollowing(ref Il2CppReferenceArray<XPathNode> pageCurrent, ref int idxCurrent, Il2CppReferenceArray<XPathNode> pageEnd, int idxEnd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pageCurrent);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idxCurrent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pageEnd);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &idxEnd;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		pageCurrent = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953722, XrefRangeEnd = 953724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetNonDescendant(ref Il2CppReferenceArray<XPathNode> pageNode, ref int idxNode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pageNode);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idxNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		pageNode = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	public XPathNodeHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
