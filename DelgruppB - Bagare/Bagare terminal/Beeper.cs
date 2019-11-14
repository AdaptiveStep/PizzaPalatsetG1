using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgruppB___Bagare
{
    class Beeper
    {
        protected static System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        //public Beeper()
        //{
        //    player = 
        //    //string current_dir = System.Environment.CurrentDirectory;
        //    //string audio_dir = System.IO.Path.Combine(current_dir, @"audio/beep1.wav");
        //}

        public static void PlayError()
        {
            string f = Config.SoundList[0];
            player.SoundLocation = f;
            player.Play(); //in another thread
        }

        //        protected player;
        // List<Sound> Sounds=new List<Sound>()

        //private LoadFromFolder()
        // "Folder" foreach=>
        //    var _ new = Sound()
        //    _.data= File.ReadAllBytes(@"in.wav"
        //  _.name = filename
        //    Sounds.add(_)

        //public Beeper()
        // Player player = new Player()
        //LoadFromFolder("/audio"
        //public Beeper(string foldername)

        //public Play(string title)
        // try{
        //  bar sound = Sounds.get(title)
        //  sound.Play()
        //}
        //catch()
    }
}
