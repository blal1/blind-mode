using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;

namespace Il2CppSystem;

public sealed class TypeNameParser : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetType_Internal_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0;

	static TypeNameParser()
	{
		Il2CppClassPointerStore<TypeNameParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeNameParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNameParser>.NativeClassPtr);
		NativeMethodInfoPtr_GetType_Internal_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameParser>.NativeClassPtr, 100667049);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759781, RefRangeEnd = 759782, XrefRangeStart = 759765, XrefRangeEnd = 759781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assemblyResolver);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeResolver);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &throwOnError;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreCase;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stackMark);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetType_Internal_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	public TypeNameParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
