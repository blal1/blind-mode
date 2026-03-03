using System;
using Il2CppInterop.Runtime;

namespace Unity.Audio;

public struct AudioMemoryManager
{
	private delegate System.IntPtr Internal_AllocateAudioMemoryDelegate(int size, int alignment);

	private delegate void Internal_FreeAudioMemoryDelegate(System.IntPtr memory);

	private static readonly Internal_AllocateAudioMemoryDelegate Internal_AllocateAudioMemoryDelegateField = IL2CPP.ResolveICall<Internal_AllocateAudioMemoryDelegate>("Unity.Audio.AudioMemoryManager::Internal_AllocateAudioMemory");

	private static readonly Internal_FreeAudioMemoryDelegate Internal_FreeAudioMemoryDelegateField = IL2CPP.ResolveICall<Internal_FreeAudioMemoryDelegate>("Unity.Audio.AudioMemoryManager::Internal_FreeAudioMemory");

	public unsafe static void* Internal_AllocateAudioMemory(int size, int alignment)
	{
		return (void*)Internal_AllocateAudioMemoryDelegateField(size, alignment);
	}

	public unsafe static void Internal_FreeAudioMemory(void* memory)
	{
		Internal_FreeAudioMemoryDelegateField((nint)memory);
	}
}
