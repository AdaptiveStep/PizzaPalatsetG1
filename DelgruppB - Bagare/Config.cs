using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace DelgruppB___Bagare
{
    class Config
    {

        public static List<SoundFile> SoundFiles = new List<SoundFile>();

        public static bool ConfigurateConsole()
        {
            Console.CursorVisible = false;
            return true;
        }

        public static bool SetEnvironment()
        {
            try
            {
                string current_dir = Environment.CurrentDirectory; // not used in Windows
                string solution_path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\"));
                string audio_folder = Path.Combine(solution_path, @"audio");

                foreach (string audioFile in Directory.GetFiles(audio_folder))
                {
                    FileInfo file_info = new FileInfo(audioFile);
                    var sound_file = new SoundFile()
                    {
                        name = Regex.Replace(file_info.Name, @"/\.[a-zA-Z0-9]{2,7}$/", ""),
                        location = audioFile,
                        byteLength = file_info.Length
                    };
                    SoundFiles.Add(sound_file);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write(e);
                throw;
            }

            return true;
        }
    }

    public struct SoundFile
    {
        public string name { get; set; }
        public string location { get; set; }
        public long byteLength { get; set; }
    }
}
