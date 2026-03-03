using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.XPath;

public class AstNode : Il2CppSystem.Object
{
	[OriginalName("System.Xml.dll", "", "AstType")]
	public enum AstType
	{
		Axis,
		Operator,
		Filter,
		ConstantOperand,
		Function,
		Group,
		Root,
		Variable,
		Error
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_AstType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Abstract_Virtual_New_get_XPathResultType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe virtual AstType Type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AstType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual XPathResultType ReturnType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ReturnType_Public_Abstract_Virtual_New_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(XPathResultType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AstNode()
	{
		Il2CppClassPointerStore<AstNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "AstNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstNode>.NativeClassPtr);
		NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100668652);
		NativeMethodInfoPtr_get_ReturnType_Public_Abstract_Virtual_New_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100668653);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100668654);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstNode>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AstNode(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
