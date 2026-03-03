using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace CrossSpeak;

internal class ScreenReaderMac : IScreenReader
{
	protected class LibSpeakAPI
	{
		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void init_speaker();

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void speak(string text);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void set_voice(int index);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint available_voices_count();

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void set_language(int index);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint available_languages_count();

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void get_voice_name(uint idx, string pszOut);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void set_volume(float volume);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float get_volume();

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void set_rate(float rate);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float get_rate();

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void stop();

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void cleanup_speaker();

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void mainloop_speaker(IntPtr speaker);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool is_speaking(IntPtr speaker);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr make_speaker();

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", BestFitMapping = false, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
		internal static extern void speak_with(IntPtr speaker, [MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void set_voice_with(IntPtr speaker, int index);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void set_volume_with(IntPtr speaker, float volume);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float get_volume_with(IntPtr speaker);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void set_rate_with(IntPtr speaker, float rate);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float get_rate_with(IntPtr speaker);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void stop_with(IntPtr speaker);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void cleanup_with(IntPtr speaker);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void register_will_speak_word_callback(IntPtr speaker, [MarshalAs(UnmanagedType.FunctionPtr)] wsw_callback cb);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void register_will_speak_phoneme_callback(IntPtr speaker, [MarshalAs(UnmanagedType.FunctionPtr)] wsp_callback cb);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void register_did_finish_speaking_callback(IntPtr speaker, [MarshalAs(UnmanagedType.FunctionPtr)] dfs_callback cb);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr make_listener();

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void start_listening(IntPtr listener);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void stop_listening(IntPtr listener);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void add_command(IntPtr listener, string command);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void cleanup_listener(IntPtr listener);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void mainloop_listener(IntPtr listener);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool is_listening(IntPtr listener);

		[DllImport("lib/screen-reader-libs/macos/libspeak.dylib", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void register_did_recognize_command_callback(IntPtr listener, drc_callback cb);
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void wsw_callback(string p1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void wsp_callback(short p1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void dfs_callback();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void drc_callback(string p1);

	private static IntPtr speaker;

	private readonly CancellationTokenSource cts = new CancellationTokenSource();

	private Thread rt;

	private static readonly Queue<string> speechQueue = new Queue<string>();

	private readonly dfs_callback fscb = DoneSpeaking;

	private static void SpeakLoop(object obj)
	{
		if (obj != null)
		{
			CancellationToken cancellationToken = (CancellationToken)obj;
			while (!cancellationToken.IsCancellationRequested)
			{
				LibSpeakAPI.mainloop_speaker(speaker);
				Thread.Sleep(20);
			}
		}
	}

	private static void DoneSpeaking()
	{
		if (speechQueue.Count != 0)
		{
			LibSpeakAPI.speak_with(speaker, speechQueue.Dequeue());
		}
	}

	public bool Initialize()
	{
		if (IsLoaded())
		{
			Close();
		}
		speaker = LibSpeakAPI.make_speaker();
		rt = new Thread(SpeakLoop);
		rt.Start(cts.Token);
		LibSpeakAPI.register_did_finish_speaking_callback(speaker, fscb);
		return true;
	}

	public bool IsLoaded()
	{
		return speaker != IntPtr.Zero;
	}

	public string DetectScreenReader()
	{
		return null;
	}

	public bool HasSpeech()
	{
		return IsLoaded();
	}

	public bool Speak(string text, bool interrupt = true)
	{
		if (text == null)
		{
			return false;
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			return false;
		}
		if (interrupt)
		{
			speechQueue.Clear();
			LibSpeakAPI.speak_with(speaker, text);
		}
		else
		{
			speechQueue.Enqueue(text);
		}
		return true;
	}

	public bool Output(string text, bool interrupt)
	{
		if (!Speak(text, interrupt))
		{
			return Braille(text);
		}
		return true;
	}

	public bool IsSpeaking()
	{
		if (LibSpeakAPI.is_speaking(speaker))
		{
			return speechQueue.Count != 0;
		}
		return false;
	}

	public float GetVolume()
	{
		if (!IsLoaded())
		{
			return 0f;
		}
		return LibSpeakAPI.get_volume_with(speaker);
	}

	public void SetVolume(float volume)
	{
		if (IsLoaded())
		{
			LibSpeakAPI.set_volume_with(speaker, volume);
		}
	}

	public float GetRate()
	{
		if (!IsLoaded())
		{
			return 0f;
		}
		return LibSpeakAPI.get_rate_with(speaker);
	}

	public void SetRate(float rate)
	{
		if (IsLoaded())
		{
			LibSpeakAPI.set_rate_with(speaker, rate);
		}
	}

	public void TrySAPI(bool trySAPI)
	{
	}

	public void PreferSAPI(bool preferSAPI)
	{
	}

	public bool HasBraille()
	{
		return false;
	}

	public bool Braille(string text)
	{
		return false;
	}

	public bool Silence()
	{
		return false;
	}

	public void Close()
	{
		cts.Cancel();
		rt?.Join();
		cts.Dispose();
		LibSpeakAPI.cleanup_with(speaker);
	}
}
