using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text;

[System.Serializable]
public class DecoderFallback : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_replacementFallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_exceptionFallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe static DecoderFallback s_replacementFallback
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_replacementFallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_replacementFallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DecoderFallback s_exceptionFallback
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_exceptionFallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_exceptionFallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DecoderFallback ReplacementFallback
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 776587, RefRangeEnd = 776589, XrefRangeStart = 776578, XrefRangeEnd = 776587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
		}
	}

	public unsafe static DecoderFallback ExceptionFallback
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 776598, RefRangeEnd = 776601, XrefRangeStart = 776589, XrefRangeEnd = 776598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
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

	static DecoderFallback()
	{
		Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderFallback");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr);
		NativeFieldInfoPtr_s_replacementFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "s_replacementFallback");
		NativeFieldInfoPtr_s_exceptionFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "s_exceptionFallback");
		NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668535);
		NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668536);
		NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668537);
		NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668538);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668539);
	}

	[CallerCount(0)]
	public unsafe virtual DecoderFallbackBuffer CreateFallbackBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecoderFallback()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DecoderFallback(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
