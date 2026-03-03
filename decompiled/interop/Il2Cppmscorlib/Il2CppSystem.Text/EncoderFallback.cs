using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text;

[System.Serializable]
public class EncoderFallback : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_replacementFallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_exceptionFallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe static EncoderFallback s_replacementFallback
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_replacementFallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_replacementFallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EncoderFallback s_exceptionFallback
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_exceptionFallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_exceptionFallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EncoderFallback ReplacementFallback
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 777033, RefRangeEnd = 777035, XrefRangeStart = 777024, XrefRangeEnd = 777033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
		}
	}

	public unsafe static EncoderFallback ExceptionFallback
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 777044, RefRangeEnd = 777047, XrefRangeStart = 777035, XrefRangeEnd = 777044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
		}
	}

	public unsafe virtual int MaxCharCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static EncoderFallback()
	{
		Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallback");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr);
		NativeFieldInfoPtr_s_replacementFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "s_replacementFallback");
		NativeFieldInfoPtr_s_exceptionFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "s_exceptionFallback");
		NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668616);
		NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668617);
		NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668618);
		NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668619);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668620);
	}

	[CallerCount(0)]
	public unsafe virtual EncoderFallbackBuffer CreateFallbackBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EncoderFallback()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public EncoderFallback(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
