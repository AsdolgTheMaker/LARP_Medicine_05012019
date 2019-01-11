using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Reflection;
using System.IO;
using System.Threading.Tasks;

namespace TapaniMedicine_v2.Classes
{
    public static class SoundLibrary
    {
        // universal player for all sounds playback
        private static SoundPlayer player = new SoundPlayer();

        // assembly required to get embedded sound resources
        private static Assembly assembly = Assembly.GetExecutingAssembly();

        // contains all embedded resources names
        private static string[] resNames = assembly.GetManifestResourceNames();

        // dictionary contains loaded streams of required sounds
        private static Dictionary<SoundType, string> library = new Dictionary<SoundType, string>()
        {
            [SoundType.BEEP] = "TapaniMedicine_v2.Resources.Beep.wav",
            [SoundType.BEEEEEEP] = "TapaniMedicine_v2.Resources.Beeeeeeeeeeeeeeeep.wav",
            [SoundType.MouseDown_01] = "TapaniMedicine_v2.Resources.MouseDown_01.wav",
            [SoundType.MouseEnter_01] = "TapaniMedicine_v2.Resources.MouseEnter_01.wav"
        };

        public enum SoundType
        {
            BEEP,
            BEEEEEEP,

            MouseDown_01,
            MouseEnter_01
        }

        // plays sound once
        public static void PlaySound(SoundType soundType)
        {
            player = new SoundPlayer(assembly.GetManifestResourceStream(library[soundType]));
            player.Load();
            player.Play();
        }

        // plays sound looping until Stop() is called
        public static void PlaySoundLooping(SoundType soundType)
        {
            player = new SoundPlayer(assembly.GetManifestResourceStream(library[soundType]));
            player.Load();
            player.PlayLooping();
        }

        // immideately stops playing all sounds
        public static void Stop()
        {
            player.Stop();
        }
    }
}
